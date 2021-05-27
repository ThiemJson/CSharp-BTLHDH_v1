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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace BTLHeDieuHanh
{
    public partial class Form1 : Form
    {
        int timeLeft = 0;

        // Lưu trữ danh sách các tiến trình hiện tại
        Process[] processList;

        // Lưu trữ tiến trình đang chọn hiện tại ( để quản lý )
        Process currentProcess;

        // Khai báo thư viện API đang sử dụng
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWnNewParent);
         
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

            txt_timeleft.Text = getTimeOut().ToString();
        }

        private void numberMinutes_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if(box.Value >= 60)
            {
                numberHours.Value += 1;
                box.Value = 0;
            }

            txt_timeleft.Text = getTimeOut().ToString();
        }

        private void numberHours_ValueChanged(object sender, EventArgs e)
        {
            txt_timeleft.Text = getTimeOut().ToString();
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
            DialogResult dialog = MessageBox.Show("Are you sure you want to reset your computer in "+getTimeOut()+"s", "Restart computer", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                startTimer();
                lockUI();
                this.shutDown("-r -t " + getTimeOut());
            }
            else
            {
                Console.WriteLine("Cancel clicked.");
            }
        }

        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to shutdown your computer in " + getTimeOut() + "s", "Shutdown computer", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                startTimer();
                lockUI();
                this.shutDown("-s -t " + getTimeOut());
            }
            else
            {
                Console.WriteLine("Cancel clicked.");
            }
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
            progressBar.Maximum = getTimeOut();
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

            progressBar.Increment(-1);
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
            // Lấy toàn bộ danh sách Process hiện tại đang sử dụng trong máy tính
            processList = Process.GetProcesses();


            txt_processcount.Text = processList.Length.ToString();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // Tạo một danh sách tưởng tượng sẽ lưu trữ các biểu tượng của mọi quy trình
            ImageList Imagelist = new ImageList();

            // Lặp qua array chứa các tiến trình và hiển thị toàn bộ thông tin của chúng
            foreach (Process process in processList)
            {
                // Xác định trạng thái từ boolean thành một chuỗi đơn giản

                string status = (process.Responding == true ? "Responding" : "Not responding");

                // Truy xuất đối tượng thông tin bổ sung của quy trình (để truy xuất Tên người dùng và Mô tả)
                dynamic extraProcessInfo = GetProcessExtraInformation(process.Id);

                // Tạo một mảng chuỗi sẽ lưu trữ thông tin để hiển thị  
                string[] row = {

                    // 1 Tên tiến trình
                    process.ProcessName,

                    // 2 ID Tiến trình
                    process.Id.ToString(),

                    // 3 Trạng thái tiến trình
                    status,

                    // 4 Người dùng mở tiến trình
                    extraProcessInfo.Username,

                    // 5 Dung lượng sử dụng
                    BytesToReadableValue(process.PrivateMemorySize64),
                    
                    // 6 Thông tin ứng dụng
                    extraProcessInfo.Description
                };

                try
                {
                    Imagelist.Images.Add(
                        process.Id.ToString(),
                        Icon.ExtractAssociatedIcon(process.MainModule.FileName).ToBitmap()
                    );
                }
                catch { }

                ListViewItem item = new ListViewItem(row)
                {
                    ImageIndex = Imagelist.Images.IndexOfKey(process.Id.ToString())
                };
                listView1.Items.Add(item);
            }

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

                currentProcess = processList[item.Index];
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
            if ( currentProcess == null)
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to kill Process", "Confirmation", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Console.WriteLine("OK clicked.");

                ListViewItem item = listView1.SelectedItems[0];
                item.Remove();
                killProcess(currentProcess);
            }
            else
            {
                Console.WriteLine("Cancel clicked.");
            }
        }

        private void killProcess(Process process)
        {
            process.Kill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_openApp_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                Process process = Process.Start(od.FileName);
                process.WaitForInputIdle();

                while (process.MainWindowHandle == IntPtr.Zero)
                {
                    Thread.Sleep(100);
                    process.Refresh();
                }

                SetParent(process.MainWindowHandle, this.panel2.Handle);
            }
        }

        private void btn_startprocess_Click_1(object sender, EventArgs e)
        {
            if (currentProcess == null)
            {
                return;
            }

            DialogResult dialog = MessageBox.Show("Are you sure you want to start Process", "Confirmation", MessageBoxButtons.OKCancel);
            if (dialog == DialogResult.OK)
            {
                Console.WriteLine("OK clicked.");
                currentProcess.Start();
            }
            else
            {
                Console.WriteLine("Cancel clicked.");
            }
        }
    }
}
