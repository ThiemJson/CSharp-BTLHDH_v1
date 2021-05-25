using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLHeDieuHanh
{
    public partial class Form1 : Form
    {
        int timeLeft = 0;
        double progressBarPercent = 0.0;

        public Form1()
        {
            InitializeComponent(); 
        }

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
    }
}
