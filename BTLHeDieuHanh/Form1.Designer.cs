namespace BTLHeDieuHanh
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.KillProcess = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_timeleft = new System.Windows.Forms.Label();
            this.txt_time_left_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_shutdown = new System.Windows.Forms.Button();
            this.numberSeconds = new System.Windows.Forms.NumericUpDown();
            this.numberMinutes = new System.Windows.Forms.NumericUpDown();
            this.numberHours = new System.Windows.Forms.NumericUpDown();
            this.txt_processcount = new System.Windows.Forms.Label();
            this.btn_endprocess = new System.Windows.Forms.Button();
            this.btn_startprocess = new System.Windows.Forms.Button();
            this.processList = new System.Windows.Forms.ListBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.KillProcess.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberHours)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.KillProcess);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // KillProcess
            // 
            this.KillProcess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KillProcess.Controls.Add(this.label6);
            this.KillProcess.Controls.Add(this.panel1);
            this.KillProcess.Controls.Add(this.txt_processcount);
            this.KillProcess.Controls.Add(this.btn_endprocess);
            this.KillProcess.Controls.Add(this.btn_startprocess);
            this.KillProcess.Controls.Add(this.processList);
            this.KillProcess.Location = new System.Drawing.Point(4, 22);
            this.KillProcess.Name = "KillProcess";
            this.KillProcess.Padding = new System.Windows.Forms.Padding(3);
            this.KillProcess.Size = new System.Drawing.Size(638, 372);
            this.KillProcess.TabIndex = 0;
            this.KillProcess.Text = "Task Management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Task Managements";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_timeleft);
            this.panel1.Controls.Add(this.txt_time_left_label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_restart);
            this.panel1.Controls.Add(this.btn_shutdown);
            this.panel1.Controls.Add(this.numberSeconds);
            this.panel1.Controls.Add(this.numberMinutes);
            this.panel1.Controls.Add(this.numberHours);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 108);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "seconds";
            // 
            // txt_timeleft
            // 
            this.txt_timeleft.AutoSize = true;
            this.txt_timeleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timeleft.Location = new System.Drawing.Point(246, 11);
            this.txt_timeleft.Name = "txt_timeleft";
            this.txt_timeleft.Size = new System.Drawing.Size(51, 55);
            this.txt_timeleft.TabIndex = 16;
            this.txt_timeleft.Text = "0";
            // 
            // txt_time_left_label
            // 
            this.txt_time_left_label.AutoSize = true;
            this.txt_time_left_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time_left_label.Location = new System.Drawing.Point(172, 39);
            this.txt_time_left_label.Name = "txt_time_left_label";
            this.txt_time_left_label.Size = new System.Drawing.Size(77, 20);
            this.txt_time_left_label.TabIndex = 15;
            this.txt_time_left_label.Text = "Time left: ";
            this.txt_time_left_label.Click += new System.EventHandler(this.txt_time_left_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Minutes ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hours";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.Location = new System.Drawing.Point(521, 13);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 29);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_restart.Location = new System.Drawing.Point(406, 57);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(90, 29);
            this.btn_restart.TabIndex = 11;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_shutdown
            // 
            this.btn_shutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shutdown.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_shutdown.Location = new System.Drawing.Point(406, 13);
            this.btn_shutdown.Name = "btn_shutdown";
            this.btn_shutdown.Size = new System.Drawing.Size(90, 29);
            this.btn_shutdown.TabIndex = 10;
            this.btn_shutdown.Text = "Shutdown";
            this.btn_shutdown.UseVisualStyleBackColor = true;
            this.btn_shutdown.Click += new System.EventHandler(this.btn_shutdown_Click);
            // 
            // numberSeconds
            // 
            this.numberSeconds.Location = new System.Drawing.Point(9, 75);
            this.numberSeconds.Name = "numberSeconds";
            this.numberSeconds.Size = new System.Drawing.Size(55, 20);
            this.numberSeconds.TabIndex = 2;
            this.numberSeconds.ValueChanged += new System.EventHandler(this.numberSeconds_ValueChanged);
            // 
            // numberMinutes
            // 
            this.numberMinutes.Location = new System.Drawing.Point(9, 43);
            this.numberMinutes.Name = "numberMinutes";
            this.numberMinutes.Size = new System.Drawing.Size(55, 20);
            this.numberMinutes.TabIndex = 1;
            this.numberMinutes.ValueChanged += new System.EventHandler(this.numberMinutes_ValueChanged);
            // 
            // numberHours
            // 
            this.numberHours.Location = new System.Drawing.Point(9, 13);
            this.numberHours.Name = "numberHours";
            this.numberHours.Size = new System.Drawing.Size(55, 20);
            this.numberHours.TabIndex = 0;
            this.numberHours.ValueChanged += new System.EventHandler(this.numberHours_ValueChanged);
            // 
            // txt_processcount
            // 
            this.txt_processcount.AutoSize = true;
            this.txt_processcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_processcount.Location = new System.Drawing.Point(9, 153);
            this.txt_processcount.Name = "txt_processcount";
            this.txt_processcount.Size = new System.Drawing.Size(64, 16);
            this.txt_processcount.TabIndex = 7;
            this.txt_processcount.Text = "Process: ";
            this.txt_processcount.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_endprocess
            // 
            this.btn_endprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_endprocess.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_endprocess.Location = new System.Drawing.Point(483, 135);
            this.btn_endprocess.Name = "btn_endprocess";
            this.btn_endprocess.Size = new System.Drawing.Size(131, 34);
            this.btn_endprocess.TabIndex = 6;
            this.btn_endprocess.Text = "End Process";
            this.btn_endprocess.UseVisualStyleBackColor = true;
            // 
            // btn_startprocess
            // 
            this.btn_startprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startprocess.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_startprocess.Location = new System.Drawing.Point(317, 135);
            this.btn_startprocess.Name = "btn_startprocess";
            this.btn_startprocess.Size = new System.Drawing.Size(142, 34);
            this.btn_startprocess.TabIndex = 5;
            this.btn_startprocess.Text = "Start Process";
            this.btn_startprocess.UseVisualStyleBackColor = true;
            // 
            // processList
            // 
            this.processList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.processList.FormattingEnabled = true;
            this.processList.Location = new System.Drawing.Point(3, 183);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(632, 186);
            this.processList.TabIndex = 4;
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(176, 75);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(209, 19);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 398);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nguyen Cao Thiem - BTL Hệ điều hành";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.KillProcess.ResumeLayout(false);
            this.KillProcess.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage KillProcess;
        private System.Windows.Forms.Button btn_endprocess;
        private System.Windows.Forms.Button btn_startprocess;
        private System.Windows.Forms.ListBox processList;
        private System.Windows.Forms.Label txt_processcount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_shutdown;
        private System.Windows.Forms.NumericUpDown numberSeconds;
        private System.Windows.Forms.NumericUpDown numberMinutes;
        private System.Windows.Forms.NumericUpDown numberHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_time_left_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_timeleft;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

