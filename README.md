# When2Zip
A standalone Windows desktop application that enables users to selectively zip files that fall within a specific date range. The application can also be automated via services.msc and Windows' built-in Task Scheduler to periodically zip old or unused files. That way, one can reduce system clutter in the background without running the risk of potentially deleting something important. 


## GUI
![alt text](https://github.com/pavangovu/When2Zip/blob/main/Demo.JPG)

## Compression Modes
- **Best Compression:** The "best" compression, where best means greatest reduction in size of the input data stream. This is also the slowest compression.
- **Best Speed:** The fastest but least effective compression (i.e. resulting files could still be compressed further).
- **Normal:** The default compression level, with a good balance of speed and compression efficiency.

## Automation
### 1. Open 'Task Scheduler' by going to the Start Menu and typing in "Task Scheduler"
![alt text](https://github.com/pavangovu/When2Zip/blob/main/Demo%20Screenshots/SearchDemo.png)

### 2. Click on "Run" to start the application. You should arrive here.
![alt text](https://github.com/pavangovu/When2Zip/blob/main/Demo%20Screenshots/TaskSchedulerNoCircle.JPG)

### 3. Click on 'Create Basic Task'
![alt text](https://github.com/pavangovu/When2Zip/blob/main/Demo%20Screenshots/TaskSchedulerDemo.JPG)

### 4. Follow the prompts and click "Finish".
![alt text](https://github.com/pavangovu/When2Zip/blob/main/Demo%20Screenshots/BasicTaskDemo.JPG)

