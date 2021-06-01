using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace GUI_File_Compressor
{
    public partial class Visuals : Form
    {
        public Visuals()
        {
            InitializeComponent();
            progressBar.Hide();
        }

        private void button_compressionTrigger_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_path.Text))
            {
                MessageBox.Show("Please select your folder.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_path.Focus();
                return;
            }

            progressBar.Show();

            string path = textBox_path.Text;

            Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile();
            if (compression.Checked)
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;

            else if (speed.Checked)
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestSpeed;

            zip.AddDirectory(path);
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
            zip.SaveProgress += Zip_SaveProgress;
            string destination = string.Format(@"{0}\archive.zip", di.Parent);


            zip.Save(destination);

            MessageBox.Show("Zipped file saved at: \n\n" + destination, "Compression Successful!");
            textBox_path.Clear();           
            progressBar.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select your path.";
            if (fbd.ShowDialog() == DialogResult.OK)
                textBox_path.Text = fbd.SelectedPath;

        }

        private void Zip_SaveProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = e.EntriesTotal;
                    progressBar.Value = e.EntriesSaved + 1;
                }));
            }
        }
    }
}
