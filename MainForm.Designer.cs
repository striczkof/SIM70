namespace Sim70
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStatus = new System.Windows.Forms.Button();
            this.pickerJoin = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkAutoDelay = new System.Windows.Forms.CheckBox();
            this.chkAutoStopSim = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.chkSelectServer = new System.Windows.Forms.CheckBox();
            this.scpServerSelect = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.lblClickRate = new System.Windows.Forms.Label();
            this.cmbHotkey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalSimmingDuration = new System.Windows.Forms.Label();
            this.lblFirstStartedSimming = new System.Windows.Forms.Label();
            this.lblJoinClicks = new System.Windows.Forms.Label();
            this.notificationTab = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnIftttTest = new System.Windows.Forms.Button();
            this.chkIFTTT = new System.Windows.Forms.CheckBox();
            this.txtIftttEventName = new System.Windows.Forms.TextBox();
            this.txtIftttKey = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIftttKey = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDesktopNotificationTest = new System.Windows.Forms.Button();
            this.chkDesktopNotifications = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnbTelegramTest = new System.Windows.Forms.Button();
            this.chkTelegramEnabled = new System.Windows.Forms.CheckBox();
            this.txtChatId = new System.Windows.Forms.TextBox();
            this.txtBotToken = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiscordTest = new System.Windows.Forms.Button();
            this.chkDiscord = new System.Windows.Forms.CheckBox();
            this.txtMentionId = new System.Windows.Forms.TextBox();
            this.txtDiscordWebhook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiscord1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.notificationTab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(7, 6);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(222, 123);
            this.btnStatus.TabIndex = 10;
            this.btnStatus.Text = "Start (F2)";
            this.toolTip1.SetToolTip(this.btnStatus, "Starts the sim. F2 can also toggle the sim on and off");
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // pickerJoin
            // 
            this.pickerJoin.Color = System.Drawing.Color.Empty;
            this.pickerJoin.Location = new System.Drawing.Point(235, 6);
            this.pickerJoin.Name = "pickerJoin";
            this.pickerJoin.Size = new System.Drawing.Size(175, 177);
            this.pickerJoin.Text = "Drag me to the \"Join\" button!";
            this.toolTip1.SetToolTip(this.pickerJoin, resources.GetString("pickerJoin.ToolTip"));
            this.pickerJoin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.screenColorPicker1_MouseUp);
            // 
            // nudDelay
            // 
            this.nudDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDelay.Location = new System.Drawing.Point(170, 160);
            this.nudDelay.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(59, 23);
            this.nudDelay.TabIndex = 12;
            this.toolTip1.SetToolTip(this.nudDelay, resources.GetString("nudDelay.ToolTip"));
            this.nudDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDelay.ValueChanged += new System.EventHandler(this.nudDelay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Min clickrate (ms)";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // chkAutoDelay
            // 
            this.chkAutoDelay.AutoSize = true;
            this.chkAutoDelay.Checked = true;
            this.chkAutoDelay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoDelay.Location = new System.Drawing.Point(94, 135);
            this.chkAutoDelay.Name = "chkAutoDelay";
            this.chkAutoDelay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAutoDelay.Size = new System.Drawing.Size(135, 19);
            this.chkAutoDelay.TabIndex = 15;
            this.chkAutoDelay.Text = "Auto Clickrate Mode";
            this.toolTip1.SetToolTip(this.chkAutoDelay, "Enable auto delay detection - This will run a short test on the current ark serve" +
        "r to work out what click delay will work well ");
            this.chkAutoDelay.UseVisualStyleBackColor = true;
            this.chkAutoDelay.CheckedChanged += new System.EventHandler(this.chkAutoDelay_CheckedChanged);
            // 
            // chkAutoStopSim
            // 
            this.chkAutoStopSim.AutoSize = true;
            this.chkAutoStopSim.Checked = true;
            this.chkAutoStopSim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoStopSim.Location = new System.Drawing.Point(8, 22);
            this.chkAutoStopSim.Name = "chkAutoStopSim";
            this.chkAutoStopSim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAutoStopSim.Size = new System.Drawing.Size(102, 19);
            this.chkAutoStopSim.TabIndex = 16;
            this.chkAutoStopSim.Text = "Auto Stop Sim";
            this.toolTip1.SetToolTip(this.chkAutoStopSim, "Automatically stops Sim70 when we\'re in the server - required for Notifications t" +
        "o work");
            this.chkAutoStopSim.UseVisualStyleBackColor = true;
            this.chkAutoStopSim.CheckedChanged += new System.EventHandler(this.chkAutoStopSim_CheckedChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(338, 305);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 28;
            this.btnCopy.Text = "Copy";
            this.toolTip1.SetToolTip(this.btnCopy, "Copies the log to the clipboard");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // chkSelectServer
            // 
            this.chkSelectServer.AutoSize = true;
            this.chkSelectServer.Location = new System.Drawing.Point(6, 0);
            this.chkSelectServer.Name = "chkSelectServer";
            this.chkSelectServer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSelectServer.Size = new System.Drawing.Size(126, 19);
            this.chkSelectServer.TabIndex = 16;
            this.chkSelectServer.Text = "Server Select Mode";
            this.toolTip1.SetToolTip(this.chkSelectServer, resources.GetString("chkSelectServer.ToolTip"));
            this.chkSelectServer.UseVisualStyleBackColor = true;
            this.chkSelectServer.CheckedChanged += new System.EventHandler(this.chkSelectServer_CheckStateChanged);
            // 
            // scpServerSelect
            // 
            this.scpServerSelect.Color = System.Drawing.Color.Empty;
            this.scpServerSelect.Location = new System.Drawing.Point(6, 25);
            this.scpServerSelect.Name = "scpServerSelect";
            this.scpServerSelect.Size = new System.Drawing.Size(154, 141);
            this.scpServerSelect.Text = "Drag me to the server list";
            this.toolTip1.SetToolTip(this.scpServerSelect, "Click and drag to the server in the server list (see the video tutorial if you\'re" +
        " unsure)\r\nEnsure the Ark screen is visible.\r\n\r\nOnce your cursor is in the right " +
        "place, simply release your click.");
            this.scpServerSelect.Visible = false;
            this.scpServerSelect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scpServerSelect_MouseUp);
            // 
            // lblClickRate
            // 
            this.lblClickRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClickRate.AutoSize = true;
            this.lblClickRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClickRate.Location = new System.Drawing.Point(175, 79);
            this.lblClickRate.Name = "lblClickRate";
            this.lblClickRate.Size = new System.Drawing.Size(92, 21);
            this.lblClickRate.TabIndex = 28;
            this.lblClickRate.Text = "Not Started.";
            this.lblClickRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lblClickRate, "Average time between clicks");
            // 
            // cmbHotkey
            // 
            this.cmbHotkey.FormattingEnabled = true;
            this.cmbHotkey.Location = new System.Drawing.Point(352, 196);
            this.cmbHotkey.Name = "cmbHotkey";
            this.cmbHotkey.Size = new System.Drawing.Size(58, 23);
            this.cmbHotkey.TabIndex = 23;
            this.cmbHotkey.SelectedIndexChanged += new System.EventHandler(this.cmbHotkey_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Start/Stop Hotkey";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.notificationTab);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(-4, 11);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(424, 360);
            this.tabControl.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.chkAutoDelay);
            this.tabPage1.Controls.Add(this.btnStatus);
            this.tabPage1.Controls.Add(this.pickerJoin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbHotkey);
            this.tabPage1.Controls.Add(this.nudDelay);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(416, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(341, 7);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 32;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblTotalSimmingDuration);
            this.groupBox2.Controls.Add(this.lblClickRate);
            this.groupBox2.Controls.Add(this.lblFirstStartedSimming);
            this.groupBox2.Controls.Add(this.lblJoinClicks);
            this.groupBox2.Location = new System.Drawing.Point(0, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 112);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Seconds Per Click:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Clicks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "First Start:";
            // 
            // lblTotalSimmingDuration
            // 
            this.lblTotalSimmingDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSimmingDuration.AutoSize = true;
            this.lblTotalSimmingDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSimmingDuration.Location = new System.Drawing.Point(175, 37);
            this.lblTotalSimmingDuration.Name = "lblTotalSimmingDuration";
            this.lblTotalSimmingDuration.Size = new System.Drawing.Size(92, 21);
            this.lblTotalSimmingDuration.TabIndex = 26;
            this.lblTotalSimmingDuration.Text = "Not Started.";
            this.lblTotalSimmingDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstStartedSimming
            // 
            this.lblFirstStartedSimming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstStartedSimming.AutoSize = true;
            this.lblFirstStartedSimming.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstStartedSimming.Location = new System.Drawing.Point(175, 16);
            this.lblFirstStartedSimming.Name = "lblFirstStartedSimming";
            this.lblFirstStartedSimming.Size = new System.Drawing.Size(92, 21);
            this.lblFirstStartedSimming.TabIndex = 25;
            this.lblFirstStartedSimming.Text = "Not Started.";
            this.lblFirstStartedSimming.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblJoinClicks
            // 
            this.lblJoinClicks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJoinClicks.AutoSize = true;
            this.lblJoinClicks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoinClicks.Location = new System.Drawing.Point(175, 58);
            this.lblJoinClicks.Name = "lblJoinClicks";
            this.lblJoinClicks.Size = new System.Drawing.Size(19, 21);
            this.lblJoinClicks.TabIndex = 27;
            this.lblJoinClicks.Text = "0";
            this.lblJoinClicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notificationTab
            // 
            this.notificationTab.Controls.Add(this.groupBox7);
            this.notificationTab.Controls.Add(this.groupBox6);
            this.notificationTab.Controls.Add(this.groupBox5);
            this.notificationTab.Controls.Add(this.groupBox3);
            this.notificationTab.Location = new System.Drawing.Point(4, 24);
            this.notificationTab.Name = "notificationTab";
            this.notificationTab.Size = new System.Drawing.Size(416, 332);
            this.notificationTab.TabIndex = 4;
            this.notificationTab.Text = "Notifications";
            this.notificationTab.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnIftttTest);
            this.groupBox7.Controls.Add(this.chkIFTTT);
            this.groupBox7.Controls.Add(this.txtIftttEventName);
            this.groupBox7.Controls.Add(this.txtIftttKey);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.lblIftttKey);
            this.groupBox7.Location = new System.Drawing.Point(5, 200);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(408, 74);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "IFTTT";
            // 
            // btnIftttTest
            // 
            this.btnIftttTest.Location = new System.Drawing.Point(327, 43);
            this.btnIftttTest.Name = "btnIftttTest";
            this.btnIftttTest.Size = new System.Drawing.Size(75, 23);
            this.btnIftttTest.TabIndex = 17;
            this.btnIftttTest.Text = "Test";
            this.btnIftttTest.UseVisualStyleBackColor = true;
            this.btnIftttTest.Click += new System.EventHandler(this.btnIftttTest_Click);
            // 
            // chkIFTTT
            // 
            this.chkIFTTT.AutoSize = true;
            this.chkIFTTT.Location = new System.Drawing.Point(142, 0);
            this.chkIFTTT.Name = "chkIFTTT";
            this.chkIFTTT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIFTTT.Size = new System.Drawing.Size(68, 19);
            this.chkIFTTT.TabIndex = 15;
            this.chkIFTTT.Text = "Enabled";
            this.chkIFTTT.UseVisualStyleBackColor = true;
            this.chkIFTTT.CheckedChanged += new System.EventHandler(this.chkIFTTT_CheckedChanged);
            // 
            // txtIftttEventName
            // 
            this.txtIftttEventName.Location = new System.Drawing.Point(97, 44);
            this.txtIftttEventName.Name = "txtIftttEventName";
            this.txtIftttEventName.Size = new System.Drawing.Size(224, 23);
            this.txtIftttEventName.TabIndex = 3;
            this.txtIftttEventName.TextChanged += new System.EventHandler(this.txtIftttEventName_TextChanged);
            // 
            // txtIftttKey
            // 
            this.txtIftttKey.Location = new System.Drawing.Point(97, 16);
            this.txtIftttKey.Name = "txtIftttKey";
            this.txtIftttKey.Size = new System.Drawing.Size(305, 23);
            this.txtIftttKey.TabIndex = 2;
            this.txtIftttKey.TextChanged += new System.EventHandler(this.txtIftttKey_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Event";
            // 
            // lblIftttKey
            // 
            this.lblIftttKey.AutoSize = true;
            this.lblIftttKey.Location = new System.Drawing.Point(65, 19);
            this.lblIftttKey.Name = "lblIftttKey";
            this.lblIftttKey.Size = new System.Drawing.Size(26, 15);
            this.lblIftttKey.TabIndex = 0;
            this.lblIftttKey.Text = "Key";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDesktopNotificationTest);
            this.groupBox6.Controls.Add(this.chkDesktopNotifications);
            this.groupBox6.Location = new System.Drawing.Point(8, 273);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(405, 61);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Desktop Notifications";
            // 
            // btnDesktopNotificationTest
            // 
            this.btnDesktopNotificationTest.Location = new System.Drawing.Point(324, 22);
            this.btnDesktopNotificationTest.Name = "btnDesktopNotificationTest";
            this.btnDesktopNotificationTest.Size = new System.Drawing.Size(75, 23);
            this.btnDesktopNotificationTest.TabIndex = 18;
            this.btnDesktopNotificationTest.Text = "Test";
            this.btnDesktopNotificationTest.UseVisualStyleBackColor = true;
            this.btnDesktopNotificationTest.Click += new System.EventHandler(this.btnDesktopNotificationTest_Click);
            // 
            // chkDesktopNotifications
            // 
            this.chkDesktopNotifications.AutoSize = true;
            this.chkDesktopNotifications.Location = new System.Drawing.Point(139, 0);
            this.chkDesktopNotifications.Name = "chkDesktopNotifications";
            this.chkDesktopNotifications.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDesktopNotifications.Size = new System.Drawing.Size(68, 19);
            this.chkDesktopNotifications.TabIndex = 15;
            this.chkDesktopNotifications.Text = "Enabled";
            this.chkDesktopNotifications.UseVisualStyleBackColor = true;
            this.chkDesktopNotifications.CheckedChanged += new System.EventHandler(this.chkDesktopNotifications_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnbTelegramTest);
            this.groupBox5.Controls.Add(this.chkTelegramEnabled);
            this.groupBox5.Controls.Add(this.txtChatId);
            this.groupBox5.Controls.Add(this.txtBotToken);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(5, 106);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(408, 74);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Telegram Alerts";
            // 
            // btnbTelegramTest
            // 
            this.btnbTelegramTest.Location = new System.Drawing.Point(327, 43);
            this.btnbTelegramTest.Name = "btnbTelegramTest";
            this.btnbTelegramTest.Size = new System.Drawing.Size(75, 23);
            this.btnbTelegramTest.TabIndex = 17;
            this.btnbTelegramTest.Text = "Test";
            this.btnbTelegramTest.UseVisualStyleBackColor = true;
            this.btnbTelegramTest.Click += new System.EventHandler(this.btnbTelegramTest_Click);
            // 
            // chkTelegramEnabled
            // 
            this.chkTelegramEnabled.AutoSize = true;
            this.chkTelegramEnabled.Location = new System.Drawing.Point(142, 0);
            this.chkTelegramEnabled.Name = "chkTelegramEnabled";
            this.chkTelegramEnabled.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkTelegramEnabled.Size = new System.Drawing.Size(68, 19);
            this.chkTelegramEnabled.TabIndex = 15;
            this.chkTelegramEnabled.Text = "Enabled";
            this.chkTelegramEnabled.UseVisualStyleBackColor = true;
            this.chkTelegramEnabled.CheckedChanged += new System.EventHandler(this.chkTelegramEnabled_CheckedChanged);
            // 
            // txtChatId
            // 
            this.txtChatId.Location = new System.Drawing.Point(97, 44);
            this.txtChatId.Name = "txtChatId";
            this.txtChatId.Size = new System.Drawing.Size(224, 23);
            this.txtChatId.TabIndex = 3;
            this.txtChatId.TextChanged += new System.EventHandler(this.txtChatId_TextChanged);
            // 
            // txtBotToken
            // 
            this.txtBotToken.Location = new System.Drawing.Point(97, 16);
            this.txtBotToken.Name = "txtBotToken";
            this.txtBotToken.Size = new System.Drawing.Size(305, 23);
            this.txtBotToken.TabIndex = 2;
            this.txtBotToken.TextChanged += new System.EventHandler(this.txtBotToken_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Chat ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bot Token";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiscordTest);
            this.groupBox3.Controls.Add(this.chkDiscord);
            this.groupBox3.Controls.Add(this.txtMentionId);
            this.groupBox3.Controls.Add(this.txtDiscordWebhook);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblDiscord1);
            this.groupBox3.Location = new System.Drawing.Point(5, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 77);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discord Alerts";
            // 
            // btnDiscordTest
            // 
            this.btnDiscordTest.Location = new System.Drawing.Point(327, 43);
            this.btnDiscordTest.Name = "btnDiscordTest";
            this.btnDiscordTest.Size = new System.Drawing.Size(75, 23);
            this.btnDiscordTest.TabIndex = 16;
            this.btnDiscordTest.Text = "Test";
            this.btnDiscordTest.UseVisualStyleBackColor = true;
            this.btnDiscordTest.Click += new System.EventHandler(this.btnDiscordTest_Click);
            // 
            // chkDiscord
            // 
            this.chkDiscord.AutoSize = true;
            this.chkDiscord.Location = new System.Drawing.Point(142, 0);
            this.chkDiscord.Name = "chkDiscord";
            this.chkDiscord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDiscord.Size = new System.Drawing.Size(68, 19);
            this.chkDiscord.TabIndex = 15;
            this.chkDiscord.Text = "Enabled";
            this.chkDiscord.UseVisualStyleBackColor = true;
            this.chkDiscord.CheckedChanged += new System.EventHandler(this.chkDiscord_CheckedChanged);
            // 
            // txtMentionId
            // 
            this.txtMentionId.Location = new System.Drawing.Point(97, 44);
            this.txtMentionId.Name = "txtMentionId";
            this.txtMentionId.Size = new System.Drawing.Size(224, 23);
            this.txtMentionId.TabIndex = 3;
            this.txtMentionId.TextChanged += new System.EventHandler(this.txtMentionId_TextChanged);
            // 
            // txtDiscordWebhook
            // 
            this.txtDiscordWebhook.Location = new System.Drawing.Point(97, 16);
            this.txtDiscordWebhook.Name = "txtDiscordWebhook";
            this.txtDiscordWebhook.Size = new System.Drawing.Size(305, 23);
            this.txtDiscordWebhook.TabIndex = 2;
            this.txtDiscordWebhook.TextChanged += new System.EventHandler(this.txtDiscordWebhook_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mention ID";
            // 
            // lblDiscord1
            // 
            this.lblDiscord1.AutoSize = true;
            this.lblDiscord1.Location = new System.Drawing.Point(9, 19);
            this.lblDiscord1.Name = "lblDiscord1";
            this.lblDiscord1.Size = new System.Drawing.Size(82, 15);
            this.lblDiscord1.TabIndex = 0;
            this.lblDiscord1.Text = "Webhook URL";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(416, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkAutoStopSim);
            this.groupBox4.Location = new System.Drawing.Point(178, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 195);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSelectServer);
            this.groupBox1.Controls.Add(this.scpServerSelect);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 195);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCopy);
            this.tabPage3.Controls.Add(this.rtbLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(416, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Location = new System.Drawing.Point(5, 3);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(408, 330);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(284, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Stopped";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 371);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(446, 430);
            this.MinimumSize = new System.Drawing.Size(446, 410);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SIM70";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.notificationTab.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnStatus;
        private Cyotek.Windows.Forms.ScreenColorPicker pickerJoin;
        private NumericUpDown nudDelay;
        private Label label1;
        private ToolTip toolTip1;
        private CheckBox chkAutoDelay;
        private ComboBox cmbHotkey;
        private Label label2;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private CheckBox chkAutoStopSim;
        private TabPage tabPage3;
        private RichTextBox rtbLog;
        private Label lblStatus;
        private Button btnCopy;
        private TabPage notificationTab;
        private GroupBox groupBox3;
        private CheckBox chkDiscord;
        private TextBox txtMentionId;
        private TextBox txtDiscordWebhook;
        private Label label3;
        private Label lblDiscord1;
        private GroupBox groupBox1;
        private CheckBox chkSelectServer;
        private Cyotek.Windows.Forms.ScreenColorPicker scpServerSelect;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblTotalSimmingDuration;
        private Label lblClickRate;
        private Label lblFirstStartedSimming;
        private Label lblJoinClicks;
        private GroupBox groupBox5;
        private CheckBox chkTelegramEnabled;
        private TextBox txtChatId;
        private TextBox txtBotToken;
        private Label label8;
        private Label label9;
        private Button btnAbout;
        private GroupBox groupBox6;
        private CheckBox chkDesktopNotifications;
        private Button btnDesktopNotificationTest;
        private Button btnbTelegramTest;
        private Button btnDiscordTest;
        private GroupBox groupBox7;
        private Button btnIftttTest;
        private CheckBox chkIFTTT;
        private TextBox txtIftttEventName;
        private TextBox txtIftttKey;
        private Label label10;
        private Label lblIftttKey;
    }
}