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
            this.label11 = new System.Windows.Forms.Label();
            this.txtBox_memory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_description = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_pid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_currenttask = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_openApp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_startprocess = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.KillProcess.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberHours)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.KillProcess);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // KillProcess
            // 
            this.KillProcess.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KillProcess.Controls.Add(this.btn_startprocess);
            this.KillProcess.Controls.Add(this.label11);
            this.KillProcess.Controls.Add(this.txtBox_memory);
            this.KillProcess.Controls.Add(this.label10);
            this.KillProcess.Controls.Add(this.txtBox_description);
            this.KillProcess.Controls.Add(this.label9);
            this.KillProcess.Controls.Add(this.txtBox_username);
            this.KillProcess.Controls.Add(this.label8);
            this.KillProcess.Controls.Add(this.txtBox_pid);
            this.KillProcess.Controls.Add(this.label7);
            this.KillProcess.Controls.Add(this.txtBox_currenttask);
            this.KillProcess.Controls.Add(this.listView1);
            this.KillProcess.Controls.Add(this.label4);
            this.KillProcess.Controls.Add(this.label6);
            this.KillProcess.Controls.Add(this.panel1);
            this.KillProcess.Controls.Add(this.txt_processcount);
            this.KillProcess.Controls.Add(this.btn_endprocess);
            this.KillProcess.Location = new System.Drawing.Point(4, 22);
            this.KillProcess.Name = "KillProcess";
            this.KillProcess.Padding = new System.Windows.Forms.Padding(3);
            this.KillProcess.Size = new System.Drawing.Size(805, 476);
            this.KillProcess.TabIndex = 0;
            this.KillProcess.Text = "Task Management";
            this.KillProcess.Click += new System.EventHandler(this.KillProcess_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(423, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Memory";
            // 
            // txtBox_memory
            // 
            this.txtBox_memory.Enabled = false;
            this.txtBox_memory.Location = new System.Drawing.Point(426, 152);
            this.txtBox_memory.Name = "txtBox_memory";
            this.txtBox_memory.Size = new System.Drawing.Size(50, 20);
            this.txtBox_memory.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(486, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Description";
            // 
            // txtBox_description
            // 
            this.txtBox_description.Enabled = false;
            this.txtBox_description.Location = new System.Drawing.Point(489, 152);
            this.txtBox_description.Name = "txtBox_description";
            this.txtBox_description.Size = new System.Drawing.Size(139, 20);
            this.txtBox_description.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Username";
            // 
            // txtBox_username
            // 
            this.txtBox_username.Enabled = false;
            this.txtBox_username.Location = new System.Drawing.Point(327, 153);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(89, 20);
            this.txtBox_username.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(279, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "PID";
            // 
            // txtBox_pid
            // 
            this.txtBox_pid.Enabled = false;
            this.txtBox_pid.Location = new System.Drawing.Point(282, 153);
            this.txtBox_pid.Name = "txtBox_pid";
            this.txtBox_pid.Size = new System.Drawing.Size(33, 20);
            this.txtBox_pid.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Process";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBox_currenttask
            // 
            this.txtBox_currenttask.Enabled = false;
            this.txtBox_currenttask.Location = new System.Drawing.Point(179, 153);
            this.txtBox_currenttask.Name = "txtBox_currenttask";
            this.txtBox_currenttask.Size = new System.Drawing.Size(89, 20);
            this.txtBox_currenttask.TabIndex = 13;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(799, 284);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Username";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Memory ( private working set )";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Desciption";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Process: ";
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
            this.panel1.BackgroundImage = global::BTLHeDieuHanh.Properties.Resources._4kPaper;
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
            this.panel1.Size = new System.Drawing.Size(799, 108);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(176, 75);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(341, 19);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "seconds";
            // 
            // txt_timeleft
            // 
            this.txt_timeleft.AutoSize = true;
            this.txt_timeleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timeleft.Location = new System.Drawing.Point(298, 17);
            this.txt_timeleft.Name = "txt_timeleft";
            this.txt_timeleft.Size = new System.Drawing.Size(36, 39);
            this.txt_timeleft.TabIndex = 16;
            this.txt_timeleft.Text = "0";
            // 
            // txt_time_left_label
            // 
            this.txt_time_left_label.AutoSize = true;
            this.txt_time_left_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time_left_label.Location = new System.Drawing.Point(225, 32);
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
            this.btn_cancel.Location = new System.Drawing.Point(686, 17);
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
            this.btn_restart.Location = new System.Drawing.Point(571, 61);
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
            this.btn_shutdown.Location = new System.Drawing.Point(571, 17);
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
            this.txt_processcount.Location = new System.Drawing.Point(73, 153);
            this.txt_processcount.Name = "txt_processcount";
            this.txt_processcount.Size = new System.Drawing.Size(15, 16);
            this.txt_processcount.TabIndex = 7;
            this.txt_processcount.Text = "0";
            this.txt_processcount.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_endprocess
            // 
            this.btn_endprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_endprocess.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_endprocess.Location = new System.Drawing.Point(722, 139);
            this.btn_endprocess.Name = "btn_endprocess";
            this.btn_endprocess.Size = new System.Drawing.Size(69, 34);
            this.btn_endprocess.TabIndex = 6;
            this.btn_endprocess.Text = "End Process";
            this.btn_endprocess.UseVisualStyleBackColor = true;
            this.btn_endprocess.Click += new System.EventHandler(this.btn_endprocess_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::BTLHeDieuHanh.Properties.Resources._4kPaper;
            this.tabPage1.Controls.Add(this.btn_openApp);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 476);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Open apps";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_openApp
            // 
            this.btn_openApp.BackgroundImage = global::BTLHeDieuHanh.Properties.Resources.CCCP2;
            this.btn_openApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openApp.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_openApp.Location = new System.Drawing.Point(69, 190);
            this.btn_openApp.Name = "btn_openApp";
            this.btn_openApp.Size = new System.Drawing.Size(126, 36);
            this.btn_openApp.TabIndex = 2;
            this.btn_openApp.Text = "Open Application";
            this.btn_openApp.UseVisualStyleBackColor = true;
            this.btn_openApp.Click += new System.EventHandler(this.btn_openApp_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BTLHeDieuHanh.Properties.Resources.CCCP2;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(283, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 470);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // btn_startprocess
            // 
            this.btn_startprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startprocess.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_startprocess.Location = new System.Drawing.Point(647, 139);
            this.btn_startprocess.Name = "btn_startprocess";
            this.btn_startprocess.Size = new System.Drawing.Size(69, 34);
            this.btn_startprocess.TabIndex = 23;
            this.btn_startprocess.Text = "Start Process";
            this.btn_startprocess.UseVisualStyleBackColor = true;
            this.btn_startprocess.Click += new System.EventHandler(this.btn_startprocess_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTLHeDieuHanh.Properties.Resources.CCCP2;
            this.ClientSize = new System.Drawing.Size(813, 502);
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
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage KillProcess;
        private System.Windows.Forms.Button btn_endprocess;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_currenttask;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_pid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBox_memory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_openApp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_startprocess;
    }
}

