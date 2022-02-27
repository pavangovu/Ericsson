
namespace GUI_File_Compressor
{
    partial class Visuals
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label_parentFolderPath = new System.Windows.Forms.Label();
            this.button_compressionTrigger = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.RadioButton();
            this.compression = new System.Windows.Forms.RadioButton();
            this.defaultCompression = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.startDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(180, 35);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_path.Multiline = true;
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(1100, 34);
            this.textBox_path.TabIndex = 0;
            // 
            // label_parentFolderPath
            // 
            this.label_parentFolderPath.AutoSize = true;
            this.label_parentFolderPath.Location = new System.Drawing.Point(19, 40);
            this.label_parentFolderPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_parentFolderPath.Name = "label_parentFolderPath";
            this.label_parentFolderPath.Size = new System.Drawing.Size(159, 25);
            this.label_parentFolderPath.TabIndex = 1;
            this.label_parentFolderPath.Text = "Parent Folder Path:";
            // 
            // button_compressionTrigger
            // 
            this.button_compressionTrigger.Location = new System.Drawing.Point(1131, 197);
            this.button_compressionTrigger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_compressionTrigger.Name = "button_compressionTrigger";
            this.button_compressionTrigger.Size = new System.Drawing.Size(216, 47);
            this.button_compressionTrigger.TabIndex = 2;
            this.button_compressionTrigger.Text = "Compress Files";
            this.button_compressionTrigger.UseVisualStyleBackColor = true;
            this.button_compressionTrigger.Click += new System.EventHandler(this.button_compressionTrigger_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1291, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(321, 115);
            this.speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(125, 29);
            this.speed.TabIndex = 4;
            this.speed.TabStop = true;
            this.speed.Text = "Best Speed";
            this.speed.UseVisualStyleBackColor = true;
            // 
            // compression
            // 
            this.compression.AutoSize = true;
            this.compression.Location = new System.Drawing.Point(447, 115);
            this.compression.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.compression.Name = "compression";
            this.compression.Size = new System.Drawing.Size(180, 29);
            this.compression.TabIndex = 5;
            this.compression.TabStop = true;
            this.compression.Text = "Best Compression";
            this.compression.UseVisualStyleBackColor = true;
            // 
            // defaultCompression
            // 
            this.defaultCompression.AutoSize = true;
            this.defaultCompression.Location = new System.Drawing.Point(224, 115);
            this.defaultCompression.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.defaultCompression.Name = "defaultCompression";
            this.defaultCompression.Size = new System.Drawing.Size(96, 29);
            this.defaultCompression.TabIndex = 6;
            this.defaultCompression.TabStop = true;
            this.defaultCompression.Text = "Normal";
            this.defaultCompression.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Compression Algorithm:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 270);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1329, 32);
            this.progressBar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Only compress files between";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(431, 191);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(104, 31);
            this.startDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "days old.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "and";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(263, 191);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(110, 31);
            this.endDate.TabIndex = 15;
            this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
            // 
            // Visuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 322);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defaultCompression);
            this.Controls.Add(this.compression);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_compressionTrigger);
            this.Controls.Add(this.label_parentFolderPath);
            this.Controls.Add(this.textBox_path);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Visuals";
            this.Text = "Directory Compression Tool";
            ((System.ComponentModel.ISupportInitialize)(this.startDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label_parentFolderPath;
        private System.Windows.Forms.Button button_compressionTrigger;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton speed;
        private System.Windows.Forms.RadioButton compression;
        private System.Windows.Forms.RadioButton defaultCompression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown startDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown endDate;
    }
}

