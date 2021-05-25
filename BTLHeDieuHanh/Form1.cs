using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace BTLHeDieuHanh
{
    public partial class Form1 : Form
    {
        int timeLeft = 0;
        Process[] processList;
        #region Unused code
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_time_left_Click(object sender, EventArgs e)
        {

        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            renderProcessesOnListView();
        }

        // Handler Shutdown timeInterval
        private void numberSeconds_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if (box.Value >= 60)
            {
                numberMinutes.Value += 1;
                box.Value = 0;
            }
        }

        private void numberMinutes_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if(box.Value >= 60)
            {
                numberHours.Value += 1;
                box.Value = 0;
            }
        }

        private void numberHours_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Shutdown computer
        /// </summary>
        private void shutDown(string command)
        {
            System.Diagnostics.Process.Start("shutdown", command);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.shutDown("-a");
            endTimer();
            clearData();
            unlockUI();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            startTimer();
            lockUI();
            // this.shutDown("-r -t" + getTimeOut());
        }

        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            startTimer();
            lockUI();
            // this.shutDown("-s -t" + getTimeOut());
        }

        private int getTimeOut()
        {
            return (int)(numberHours.Value * 60 * 60 + numberMinutes.Value * 60 + numberSeconds.Value);
        }

        /// <summary>
        /// Timer
        /// </summary>
        private void startTimer()
        {
            progressBar.Maximum = timeLeft;
            progressBar.Minimum = 0;
            
            progressBar.Value = progressBar.Maximum;
            timeLeft = getTimeOut();
            txt_timeleft.Text = timeLeft.ToString();
            mainTimer.Start();
        }

        private void endTimer()
        {
            mainTimer.Stop();
            txt_timeleft.Text = "0";
        }

        private void handlerTimeEnd()
        {
            endTimer();
        }

        private void inCreaseProgressbar()
        {
            if (progressBar.Value == 0)
            {
                return;
            }

            progressBar.Value -= 1;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft == 0)
            {
                handlerTimeEnd();
                clearData();
                unlockUI();
                return;
            }

            inCreaseProgressbar();
            timeLeft -= 1;
            txt_timeleft.Text = timeLeft.ToString();
        }

        private void clearData()
        {
            timeLeft = 0;
            txt_timeleft.Text = "0";
            numberHours.Value = 0;
            numberMinutes.Value = 0;
            numberSeconds.Value = 0;
            progressBar.Value = 0;
        }

        private void lockUI()
        {
            numberHours.Enabled = false;
            numberMinutes.Enabled = false;
            numberSeconds.Enabled = false;
            btn_restart.Enabled = false;
            btn_shutdown.Enabled = false;
        }

        private void unlockUI()
        {
            numberHours.Enabled = true;
            numberMinutes.Enabled = true;
            numberSeconds.Enabled = true;
            btn_restart.Enabled = true;
            btn_shutdown.Enabled = true;
        }

        /// <summary>
        /// This method renders all the processes of Windows on a ListView with some values and icons.
        /// </summary>
        public void renderProcessesOnListView()
        {
            // Create an array to store the processes
            processList = Process.GetProcesses();
            txt_processcount.Text = processList.Length.ToString();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // Create an Imagelist that will store the icons of every process
            ImageList Imagelist = new ImageList();

            // Loop through the array of processes to show information of every process in your console
            foreach (Process process in processList)
            {
                // Define the status from a boolean to a simple string
                string status = (process.Responding == true ? "Responding" : "Not responding");

                // Retrieve the object of extra information of the process (to retrieve Username and Description)
                dynamic extraProcessInfo = GetProcessExtraInformation(process.Id);

                // Create an array of string that will store the information to display in our 
                string[] row = {
                    // 1 Process name
                    process.ProcessName,
                    // 2 Process ID
                    process.Id.ToString(),
                    // 3 Process status
                    status,
                    // 4 Username that started the process
                    extraProcessInfo.Username,
                    // 5 Memory usage
                    BytesToReadableValue(process.PrivateMemorySize64),
                    // 6 Description of the process
                    extraProcessInfo.Description
                };

                //
                // As not every process has an icon then, prevent the app from crash
                try
                {
                    Imagelist.Images.Add(
                        // Add an unique Key as identifier for the icon (same as the ID of the process)
                        process.Id.ToString(),
                        // Add Icon to the List 
                        Icon.ExtractAssociatedIcon(process.MainModule.FileName).ToBitmap()
                    );
                }
                catch { }

                // Create a new Item to add into the list view that expects the row of information as first argument
                ListViewItem item = new ListViewItem(row)
                {
                    // Set the ImageIndex of the item as the same defined in the previous try-catch
                    ImageIndex = Imagelist.Images.IndexOfKey(process.Id.ToString())
                };

                // Add the Item
                listView1.Items.Add(item);
            }

            // Set the imagelist of your list view the previous created list :)
            listView1.LargeImageList = Imagelist;
            listView1.SmallImageList = Imagelist;
        }

        /// <summary>
        /// Method that converts bytes to its human readable value
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string BytesToReadableValue(long number)
        {
            List<string> suffixes = new List<string> { " B", " KB", " MB", " GB", " TB", " PB" };

            for (int i = 0; i < suffixes.Count; i++)
            {
                long temp = number / (int)Math.Pow(1024, i + 1);

                if (temp == 0)
                {
                    return (number / (int)Math.Pow(1024, i)) + suffixes[i];
                }
            }

            return number.ToString();
        }

        /// <summary>
        /// Returns an Expando object with the description and username of a process from the process ID.
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        public ExpandoObject GetProcessExtraInformation(int processId)
        {
            // Query the Win32_Process
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            // Create a dynamic object to store some properties on it
            dynamic response = new ExpandoObject();
            response.Description = "";
            response.Username = "Unknown";

            foreach (ManagementObject obj in processList)
            {
                // Retrieve username 
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    // return Username
                    response.Username = argList[0];

                    // You can return the domain too like (PCDesktop-123123\Username using instead
                    //response.Username = argList[1] + "\\" + argList[0];
                }

                // Retrieve process description if exists
                if (obj["ExecutablePath"] != null)
                {
                    try
                    {
                        FileVersionInfo info = FileVersionInfo.GetVersionInfo(obj["ExecutablePath"].ToString());
                        response.Description = info.FileDescription;
                    }
                    catch { }
                }
            }

            return response;
        }

        private void KillProcess_Click(object sender, EventArgs e)
        {
        }

        private void btn_startprocess_Click(object sender, EventArgs e)
        {
            renderProcessesOnListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtBox_currenttask.Text = item.SubItems[0].Text;
                txtBox_pid.Text = item.SubItems[1].Text;
                txtBox_username.Text = item.SubItems[3].Text;
                txtBox_description.Text = item.SubItems[5].Text;
                txtBox_memory.Text = item.SubItems[4].Text;
            }
            else
            {
                txtBox_currenttask.Text = "";
                txtBox_pid.Text = "";
                txtBox_username.Text = "";
                txtBox_description.Text = "";
                txtBox_memory.Text = "";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_endprocess_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to kill Process", "Confirmation", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Console.WriteLine("OK clicked.");

                ListViewItem item = listView1.SelectedItems[0];
                item.Remove();
            }
            else
            {
                Console.WriteLine("Cancel clicked.");
            }
        }
    }
}
