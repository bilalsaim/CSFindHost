namespace otomatikPaylas
{
    partial class CSFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSFinder));
            this.bQuit = new System.Windows.Forms.Button();
            this.bBrowser = new System.Windows.Forms.Button();
            this.gbFrame1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lCity = new System.Windows.Forms.Label();
            this.lFile = new System.Windows.Forms.Label();
            this.cbFile = new System.Windows.Forms.ComboBox();
            this.bPreviousProfile = new System.Windows.Forms.Button();
            this.bNextProfile = new System.Windows.Forms.Button();
            this.lbProfileList = new System.Windows.Forms.ListBox();
            this.bGetProfiles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAflexible = new System.Windows.Forms.CheckBox();
            this.cbDflexible = new System.Windows.Forms.CheckBox();
            this.lArrive = new System.Windows.Forms.Label();
            this.lDeparture = new System.Windows.Forms.Label();
            this.lPassenger = new System.Windows.Forms.Label();
            this.nudPassenger = new System.Windows.Forms.NumericUpDown();
            this.dtpArrive = new System.Windows.Forms.DateTimePicker();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bPostPaste = new System.Windows.Forms.Button();
            this.bPostSend = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.bRequest = new System.Windows.Forms.Button();
            this.bwAutomatic = new System.ComponentModel.BackgroundWorker();
            this.bAutomaticStart = new System.Windows.Forms.Button();
            this.bAutomaticStop = new System.Windows.Forms.Button();
            this.tbIntroduce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.numWait = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.bSaveInfo = new System.Windows.Forms.Button();
            this.bRefreshInfo = new System.Windows.Forms.Button();
            this.saveCity = new System.Windows.Forms.Button();
            this.gbFrame1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassenger)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWait)).BeginInit();
            this.SuspendLayout();
            // 
            // bQuit
            // 
            this.bQuit.Location = new System.Drawing.Point(388, 852);
            this.bQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bQuit.Name = "bQuit";
            this.bQuit.Size = new System.Drawing.Size(300, 52);
            this.bQuit.TabIndex = 1;
            this.bQuit.Text = "Quit";
            this.bQuit.UseVisualStyleBackColor = true;
            this.bQuit.Click += new System.EventHandler(this.bQuit_Click);
            // 
            // bBrowser
            // 
            this.bBrowser.Location = new System.Drawing.Point(18, 18);
            this.bBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bBrowser.Name = "bBrowser";
            this.bBrowser.Size = new System.Drawing.Size(176, 52);
            this.bBrowser.TabIndex = 2;
            this.bBrowser.Text = "Open Browser";
            this.bBrowser.UseVisualStyleBackColor = true;
            this.bBrowser.Click += new System.EventHandler(this.bBrowser_Click);
            // 
            // gbFrame1
            // 
            this.gbFrame1.Controls.Add(this.saveCity);
            this.gbFrame1.Controls.Add(this.label4);
            this.gbFrame1.Controls.Add(this.tbCity);
            this.gbFrame1.Controls.Add(this.lCity);
            this.gbFrame1.Controls.Add(this.lFile);
            this.gbFrame1.Controls.Add(this.cbFile);
            this.gbFrame1.Controls.Add(this.bPreviousProfile);
            this.gbFrame1.Controls.Add(this.bNextProfile);
            this.gbFrame1.Controls.Add(this.lbProfileList);
            this.gbFrame1.Location = new System.Drawing.Point(18, 174);
            this.gbFrame1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFrame1.Name = "gbFrame1";
            this.gbFrame1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbFrame1.Size = new System.Drawing.Size(675, 277);
            this.gbFrame1.TabIndex = 4;
            this.gbFrame1.TabStop = false;
            this.gbFrame1.Text = "Profile List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "0 / 0";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(100, 20);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(381, 26);
            this.tbCity.TabIndex = 9;
            this.tbCity.TextChanged += new System.EventHandler(this.tbCity_TextChanged);
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Location = new System.Drawing.Point(9, 25);
            this.lCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(39, 20);
            this.lCity.TabIndex = 8;
            this.lCity.Text = "City:";
            // 
            // lFile
            // 
            this.lFile.AutoSize = true;
            this.lFile.Location = new System.Drawing.Point(9, 240);
            this.lFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFile.Name = "lFile";
            this.lFile.Size = new System.Drawing.Size(79, 20);
            this.lFile.TabIndex = 8;
            this.lFile.Text = "From File:";
            // 
            // cbFile
            // 
            this.cbFile.FormattingEnabled = true;
            this.cbFile.Location = new System.Drawing.Point(120, 235);
            this.cbFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFile.Name = "cbFile";
            this.cbFile.Size = new System.Drawing.Size(448, 28);
            this.cbFile.TabIndex = 7;
            this.cbFile.SelectedIndexChanged += new System.EventHandler(this.cbFile_SelectedIndexChanged);
            // 
            // bPreviousProfile
            // 
            this.bPreviousProfile.Location = new System.Drawing.Point(585, 166);
            this.bPreviousProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPreviousProfile.Name = "bPreviousProfile";
            this.bPreviousProfile.Size = new System.Drawing.Size(72, 60);
            this.bPreviousProfile.TabIndex = 6;
            this.bPreviousProfile.Text = "<";
            this.bPreviousProfile.UseVisualStyleBackColor = true;
            // 
            // bNextProfile
            // 
            this.bNextProfile.Location = new System.Drawing.Point(585, 60);
            this.bNextProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bNextProfile.Name = "bNextProfile";
            this.bNextProfile.Size = new System.Drawing.Size(72, 60);
            this.bNextProfile.TabIndex = 6;
            this.bNextProfile.Text = ">";
            this.bNextProfile.UseVisualStyleBackColor = true;
            this.bNextProfile.Click += new System.EventHandler(this.bNextProfile_Click);
            // 
            // lbProfileList
            // 
            this.lbProfileList.Enabled = false;
            this.lbProfileList.FormattingEnabled = true;
            this.lbProfileList.ItemHeight = 20;
            this.lbProfileList.Location = new System.Drawing.Point(14, 60);
            this.lbProfileList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbProfileList.Name = "lbProfileList";
            this.lbProfileList.Size = new System.Drawing.Size(554, 164);
            this.lbProfileList.TabIndex = 5;
            // 
            // bGetProfiles
            // 
            this.bGetProfiles.Location = new System.Drawing.Point(202, 18);
            this.bGetProfiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bGetProfiles.Name = "bGetProfiles";
            this.bGetProfiles.Size = new System.Drawing.Size(148, 52);
            this.bGetProfiles.TabIndex = 5;
            this.bGetProfiles.Text = "Get Profiles";
            this.bGetProfiles.UseVisualStyleBackColor = true;
            this.bGetProfiles.Click += new System.EventHandler(this.bGetProfiles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tbMessage);
            this.groupBox1.Location = new System.Drawing.Point(20, 460);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(675, 323);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbAflexible);
            this.panel1.Controls.Add(this.cbDflexible);
            this.panel1.Controls.Add(this.lArrive);
            this.panel1.Controls.Add(this.lDeparture);
            this.panel1.Controls.Add(this.lPassenger);
            this.panel1.Controls.Add(this.nudPassenger);
            this.panel1.Controls.Add(this.dtpArrive);
            this.panel1.Controls.Add(this.dtpDeparture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(465, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 294);
            this.panel1.TabIndex = 9;
            // 
            // cbAflexible
            // 
            this.cbAflexible.AutoSize = true;
            this.cbAflexible.Location = new System.Drawing.Point(20, 82);
            this.cbAflexible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAflexible.Name = "cbAflexible";
            this.cbAflexible.Size = new System.Drawing.Size(135, 24);
            this.cbAflexible.TabIndex = 9;
            this.cbAflexible.Text = "Flexible Dates";
            this.cbAflexible.UseVisualStyleBackColor = true;
            // 
            // cbDflexible
            // 
            this.cbDflexible.AutoSize = true;
            this.cbDflexible.Location = new System.Drawing.Point(20, 183);
            this.cbDflexible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDflexible.Name = "cbDflexible";
            this.cbDflexible.Size = new System.Drawing.Size(135, 24);
            this.cbDflexible.TabIndex = 9;
            this.cbDflexible.Text = "Flexible Dates";
            this.cbDflexible.UseVisualStyleBackColor = true;
            // 
            // lArrive
            // 
            this.lArrive.AutoSize = true;
            this.lArrive.Location = new System.Drawing.Point(15, 17);
            this.lArrive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lArrive.Name = "lArrive";
            this.lArrive.Size = new System.Drawing.Size(49, 20);
            this.lArrive.TabIndex = 8;
            this.lArrive.Text = "Arrive";
            // 
            // lDeparture
            // 
            this.lDeparture.AutoSize = true;
            this.lDeparture.Location = new System.Drawing.Point(15, 118);
            this.lDeparture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDeparture.Name = "lDeparture";
            this.lDeparture.Size = new System.Drawing.Size(81, 20);
            this.lDeparture.TabIndex = 8;
            this.lDeparture.Text = "Departure";
            // 
            // lPassenger
            // 
            this.lPassenger.AutoSize = true;
            this.lPassenger.Location = new System.Drawing.Point(15, 222);
            this.lPassenger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPassenger.Name = "lPassenger";
            this.lPassenger.Size = new System.Drawing.Size(163, 20);
            this.lPassenger.TabIndex = 8;
            this.lPassenger.Text = "Number of Passenger";
            // 
            // nudPassenger
            // 
            this.nudPassenger.Location = new System.Drawing.Point(20, 249);
            this.nudPassenger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudPassenger.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPassenger.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPassenger.Name = "nudPassenger";
            this.nudPassenger.Size = new System.Drawing.Size(164, 26);
            this.nudPassenger.TabIndex = 7;
            this.nudPassenger.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpArrive
            // 
            this.dtpArrive.CustomFormat = "yyyy-MM-dd";
            this.dtpArrive.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrive.Location = new System.Drawing.Point(20, 42);
            this.dtpArrive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpArrive.MaxDate = new System.DateTime(2025, 12, 25, 0, 0, 0, 0);
            this.dtpArrive.MinDate = new System.DateTime(2015, 12, 25, 0, 0, 0, 0);
            this.dtpArrive.Name = "dtpArrive";
            this.dtpArrive.Size = new System.Drawing.Size(162, 26);
            this.dtpArrive.TabIndex = 6;
            this.dtpArrive.Value = new System.DateTime(2015, 12, 25, 0, 0, 0, 0);
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.CustomFormat = "yyyy-MM-dd";
            this.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparture.Location = new System.Drawing.Point(20, 143);
            this.dtpDeparture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDeparture.MaxDate = new System.DateTime(2025, 12, 25, 0, 0, 0, 0);
            this.dtpDeparture.MinDate = new System.DateTime(2015, 12, 25, 0, 0, 0, 0);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(162, 26);
            this.dtpDeparture.TabIndex = 6;
            this.dtpDeparture.Value = new System.DateTime(2015, 12, 25, 0, 0, 0, 0);
            // 
            // tbMessage
            // 
            this.tbMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbMessage.Location = new System.Drawing.Point(4, 24);
            this.tbMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessage.Size = new System.Drawing.Size(450, 294);
            this.tbMessage.TabIndex = 8;
            // 
            // bPostPaste
            // 
            this.bPostPaste.Location = new System.Drawing.Point(388, 788);
            this.bPostPaste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPostPaste.Name = "bPostPaste";
            this.bPostPaste.Size = new System.Drawing.Size(152, 55);
            this.bPostPaste.TabIndex = 10;
            this.bPostPaste.Text = "Paste";
            this.bPostPaste.UseVisualStyleBackColor = true;
            this.bPostPaste.Click += new System.EventHandler(this.bPostPaste_Click);
            // 
            // bPostSend
            // 
            this.bPostSend.Location = new System.Drawing.Point(549, 788);
            this.bPostSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPostSend.Name = "bPostSend";
            this.bPostSend.Size = new System.Drawing.Size(141, 55);
            this.bPostSend.TabIndex = 10;
            this.bPostSend.Text = "Send";
            this.bPostSend.UseVisualStyleBackColor = true;
            this.bPostSend.Click += new System.EventHandler(this.bPostSend_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 924);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(706, 30);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(305, 25);
            this.toolStripStatusLabel1.Text = "CSFinder v2.0 - Bilal Saim 25.12.2015";
            // 
            // bRequest
            // 
            this.bRequest.Location = new System.Drawing.Point(258, 788);
            this.bRequest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bRequest.Name = "bRequest";
            this.bRequest.Size = new System.Drawing.Size(122, 55);
            this.bRequest.TabIndex = 12;
            this.bRequest.Text = "Request";
            this.bRequest.UseVisualStyleBackColor = true;
            this.bRequest.Click += new System.EventHandler(this.bRequest_Click);
            // 
            // bwAutomatic
            // 
            this.bwAutomatic.WorkerReportsProgress = true;
            this.bwAutomatic.WorkerSupportsCancellation = true;
            this.bwAutomatic.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAutomatic_DoWork);
            // 
            // bAutomaticStart
            // 
            this.bAutomaticStart.Location = new System.Drawing.Point(366, 18);
            this.bAutomaticStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAutomaticStart.Name = "bAutomaticStart";
            this.bAutomaticStart.Size = new System.Drawing.Size(158, 52);
            this.bAutomaticStart.TabIndex = 13;
            this.bAutomaticStart.Text = "Automatic";
            this.bAutomaticStart.UseVisualStyleBackColor = true;
            this.bAutomaticStart.Click += new System.EventHandler(this.bAutomaticStart_Click);
            // 
            // bAutomaticStop
            // 
            this.bAutomaticStop.Location = new System.Drawing.Point(532, 18);
            this.bAutomaticStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAutomaticStop.Name = "bAutomaticStop";
            this.bAutomaticStop.Size = new System.Drawing.Size(158, 52);
            this.bAutomaticStop.TabIndex = 13;
            this.bAutomaticStop.Text = "Stop";
            this.bAutomaticStop.UseVisualStyleBackColor = true;
            this.bAutomaticStop.Click += new System.EventHandler(this.bAutomaticStop_Click);
            // 
            // tbIntroduce
            // 
            this.tbIntroduce.Location = new System.Drawing.Point(22, 812);
            this.tbIntroduce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIntroduce.Name = "tbIntroduce";
            this.tbIntroduce.Size = new System.Drawing.Size(206, 26);
            this.tbIntroduce.TabIndex = 14;
            this.tbIntroduce.Text = "Hello";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 788);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introduce";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passwordTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.emailTB);
            this.groupBox2.Location = new System.Drawing.Point(20, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(670, 85);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile Informations";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(420, 35);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(216, 26);
            this.passwordTB.TabIndex = 0;
            this.passwordTB.UseSystemPasswordChar = true;
            this.passwordTB.TextChanged += new System.EventHandler(this.emailTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email:";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(76, 35);
            this.emailTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(216, 26);
            this.emailTB.TabIndex = 0;
            this.emailTB.TextChanged += new System.EventHandler(this.emailTB_TextChanged);
            // 
            // numWait
            // 
            this.numWait.Location = new System.Drawing.Point(22, 874);
            this.numWait.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numWait.Name = "numWait";
            this.numWait.Size = new System.Drawing.Size(75, 26);
            this.numWait.TabIndex = 16;
            this.numWait.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 849);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Wait seconds for each profile";
            // 
            // bSaveInfo
            // 
            this.bSaveInfo.Location = new System.Drawing.Point(234, 871);
            this.bSaveInfo.Name = "bSaveInfo";
            this.bSaveInfo.Size = new System.Drawing.Size(110, 29);
            this.bSaveInfo.TabIndex = 11;
            this.bSaveInfo.Text = "Save Info";
            this.bSaveInfo.UseVisualStyleBackColor = true;
            this.bSaveInfo.Click += new System.EventHandler(this.bSaveInfo_Click);
            // 
            // bRefreshInfo
            // 
            this.bRefreshInfo.Location = new System.Drawing.Point(118, 871);
            this.bRefreshInfo.Name = "bRefreshInfo";
            this.bRefreshInfo.Size = new System.Drawing.Size(110, 29);
            this.bRefreshInfo.TabIndex = 11;
            this.bRefreshInfo.Text = "Refresh Info";
            this.bRefreshInfo.UseVisualStyleBackColor = true;
            this.bRefreshInfo.Click += new System.EventHandler(this.bRefreshInfo_Click);
            // 
            // saveCity
            // 
            this.saveCity.Location = new System.Drawing.Point(488, 13);
            this.saveCity.Name = "saveCity";
            this.saveCity.Size = new System.Drawing.Size(104, 39);
            this.saveCity.TabIndex = 11;
            this.saveCity.Text = "Save City";
            this.saveCity.UseVisualStyleBackColor = true;
            this.saveCity.Click += new System.EventHandler(this.saveCity_Click);
            // 
            // CSFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(706, 954);
            this.Controls.Add(this.bRefreshInfo);
            this.Controls.Add(this.bSaveInfo);
            this.Controls.Add(this.numWait);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIntroduce);
            this.Controls.Add(this.bAutomaticStop);
            this.Controls.Add(this.bAutomaticStart);
            this.Controls.Add(this.bRequest);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bPostSend);
            this.Controls.Add(this.bPostPaste);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bGetProfiles);
            this.Controls.Add(this.bBrowser);
            this.Controls.Add(this.gbFrame1);
            this.Controls.Add(this.bQuit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CSFinder";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS Helper of Find Host";
            this.Load += new System.EventHandler(this.CSFinder_Load);
            this.gbFrame1.ResumeLayout(false);
            this.gbFrame1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPassenger)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bQuit;
        private System.Windows.Forms.Button bBrowser;
        private System.Windows.Forms.GroupBox gbFrame1;
        private System.Windows.Forms.Button bPreviousProfile;
        private System.Windows.Forms.Button bNextProfile;
        private System.Windows.Forms.ListBox lbProfileList;
        private System.Windows.Forms.Button bGetProfiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudPassenger;
        private System.Windows.Forms.DateTimePicker dtpArrive;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label lArrive;
        private System.Windows.Forms.Label lDeparture;
        private System.Windows.Forms.Label lPassenger;
        private System.Windows.Forms.Button bPostPaste;
        private System.Windows.Forms.Button bPostSend;
        private System.Windows.Forms.Label lFile;
        private System.Windows.Forms.ComboBox cbFile;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button bRequest;
        private System.ComponentModel.BackgroundWorker bwAutomatic;
        private System.Windows.Forms.Button bAutomaticStart;
        private System.Windows.Forms.Button bAutomaticStop;
        private System.Windows.Forms.TextBox tbIntroduce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numWait;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbAflexible;
        private System.Windows.Forms.CheckBox cbDflexible;
        private System.Windows.Forms.Button bSaveInfo;
        private System.Windows.Forms.Button bRefreshInfo;
        private System.Windows.Forms.Button saveCity;
    }
}

