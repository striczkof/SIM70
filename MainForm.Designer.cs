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
            this.btnDonate = new System.Windows.Forms.Button();
            this.chkAutoDelay = new System.Windows.Forms.CheckBox();
            this.chkAutoStopSim = new System.Windows.Forms.CheckBox();
            this.chkSelectServer = new System.Windows.Forms.CheckBox();
            this.scpServerSelect = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.cmbHotkey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDiscord = new System.Windows.Forms.CheckBox();
            this.txtMentionId = new System.Windows.Forms.TextBox();
            this.txtDiscordWebhook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDiscord1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblJoinClicks = new System.Windows.Forms.Label();
            this.lblTotalSimmingDuration = new System.Windows.Forms.Label();
            this.lblFirstStartedSimming = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(3, 6);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(232, 141);
            this.btnStatus.TabIndex = 10;
            this.btnStatus.Text = "Start (F2)";
            this.toolTip1.SetToolTip(this.btnStatus, "Starts the sim. F2 can also toggle the sim on and off");
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // pickerJoin
            // 
            this.pickerJoin.Color = System.Drawing.Color.Empty;
            this.pickerJoin.Location = new System.Drawing.Point(241, 46);
            this.pickerJoin.Name = "pickerJoin";
            this.pickerJoin.Size = new System.Drawing.Size(167, 155);
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
            this.nudDelay.Location = new System.Drawing.Point(176, 178);
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
            this.label1.Location = new System.Drawing.Point(73, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Min clickrate (ms)";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btnDonate
            // 
            this.btnDonate.Location = new System.Drawing.Point(341, 8);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(75, 23);
            this.btnDonate.TabIndex = 22;
            this.btnDonate.Text = "Donate";
            this.toolTip1.SetToolTip(this.btnDonate, "Takes you to the github for the project");
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // chkAutoDelay
            // 
            this.chkAutoDelay.AutoSize = true;
            this.chkAutoDelay.Checked = true;
            this.chkAutoDelay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoDelay.Location = new System.Drawing.Point(100, 153);
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
            this.toolTip1.SetToolTip(this.chkAutoStopSim, "Automatically stops Sim70 when we\'re in the server");
            this.chkAutoStopSim.UseVisualStyleBackColor = true;
            this.chkAutoStopSim.CheckedChanged += new System.EventHandler(this.chkAutoStopSim_CheckedChanged);
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
            // cmbHotkey
            // 
            this.cmbHotkey.FormattingEnabled = true;
            this.cmbHotkey.Location = new System.Drawing.Point(350, 17);
            this.cmbHotkey.Name = "cmbHotkey";
            this.cmbHotkey.Size = new System.Drawing.Size(58, 23);
            this.cmbHotkey.TabIndex = 23;
            this.cmbHotkey.SelectedIndexChanged += new System.EventHandler(this.cmbHotkey_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Start/Stop Hotkey";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(424, 236);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(416, 208);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(416, 208);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkAutoStopSim);
            this.groupBox4.Location = new System.Drawing.Point(178, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 115);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDiscord);
            this.groupBox3.Controls.Add(this.txtMentionId);
            this.groupBox3.Controls.Add(this.txtDiscordWebhook);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblDiscord1);
            this.groupBox3.Location = new System.Drawing.Point(178, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 74);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discord Alerts";
            // 
            // chkDiscord
            // 
            this.chkDiscord.AutoSize = true;
            this.chkDiscord.Location = new System.Drawing.Point(153, 0);
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
            this.txtMentionId.Enabled = false;
            this.txtMentionId.Location = new System.Drawing.Point(97, 44);
            this.txtMentionId.Name = "txtMentionId";
            this.txtMentionId.Size = new System.Drawing.Size(123, 23);
            this.txtMentionId.TabIndex = 3;
            this.txtMentionId.TextChanged += new System.EventHandler(this.txtMentionId_TextChanged);
            // 
            // txtDiscordWebhook
            // 
            this.txtDiscordWebhook.Enabled = false;
            this.txtDiscordWebhook.Location = new System.Drawing.Point(97, 16);
            this.txtDiscordWebhook.Name = "txtDiscordWebhook";
            this.txtDiscordWebhook.Size = new System.Drawing.Size(123, 23);
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
            this.lblDiscord1.Location = new System.Drawing.Point(15, 19);
            this.lblDiscord1.Name = "lblDiscord1";
            this.lblDiscord1.Size = new System.Drawing.Size(82, 15);
            this.lblDiscord1.TabIndex = 0;
            this.lblDiscord1.Text = "Webhook URL";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbLog);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(416, 208);
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
            this.rtbLog.Size = new System.Drawing.Size(408, 202);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblJoinClicks);
            this.tabPage4.Controls.Add(this.lblTotalSimmingDuration);
            this.tabPage4.Controls.Add(this.lblFirstStartedSimming);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(416, 208);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stats";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblJoinClicks
            // 
            this.lblJoinClicks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJoinClicks.AutoSize = true;
            this.lblJoinClicks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoinClicks.Location = new System.Drawing.Point(97, 114);
            this.lblJoinClicks.Name = "lblJoinClicks";
            this.lblJoinClicks.Size = new System.Drawing.Size(85, 21);
            this.lblJoinClicks.TabIndex = 2;
            this.lblJoinClicks.Text = "Join Clicks:";
            this.lblJoinClicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalSimmingDuration
            // 
            this.lblTotalSimmingDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSimmingDuration.AutoSize = true;
            this.lblTotalSimmingDuration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSimmingDuration.Location = new System.Drawing.Point(5, 92);
            this.lblTotalSimmingDuration.Name = "lblTotalSimmingDuration";
            this.lblTotalSimmingDuration.Size = new System.Drawing.Size(177, 21);
            this.lblTotalSimmingDuration.TabIndex = 1;
            this.lblTotalSimmingDuration.Text = "Total Simming Duration:";
            this.lblTotalSimmingDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstStartedSimming
            // 
            this.lblFirstStartedSimming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstStartedSimming.AutoSize = true;
            this.lblFirstStartedSimming.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstStartedSimming.Location = new System.Drawing.Point(19, 70);
            this.lblFirstStartedSimming.Name = "lblFirstStartedSimming";
            this.lblFirstStartedSimming.Size = new System.Drawing.Size(163, 21);
            this.lblFirstStartedSimming.TabIndex = 0;
            this.lblFirstStartedSimming.Text = "First Started Simming:";
            this.lblFirstStartedSimming.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.ClientSize = new System.Drawing.Size(430, 245);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(446, 284);
            this.MinimumSize = new System.Drawing.Size(446, 284);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SIM70";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnStatus;
        private Cyotek.Windows.Forms.ScreenColorPicker pickerJoin;
        private NumericUpDown nudDelay;
        private Label label1;
        private ToolTip toolTip1;
        private Button btnDonate;
        private CheckBox chkAutoDelay;
        private ComboBox cmbHotkey;
        private Label label2;
        private CheckBox checkBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private CheckBox chkAutoStopSim;
        private GroupBox groupBox1;
        private CheckBox chkSelectServer;
        private Cyotek.Windows.Forms.ScreenColorPicker scpServerSelect;
        private GroupBox groupBox3;
        private CheckBox chkDiscord;
        private TextBox txtMentionId;
        private TextBox txtDiscordWebhook;
        private Label label3;
        private Label lblDiscord1;
        private TabPage tabPage3;
        private RichTextBox rtbLog;
        private Label lblStatus;
        private TabPage tabPage4;
        private Label lblJoinClicks;
        private Label lblTotalSimmingDuration;
        private Label lblFirstStartedSimming;
    }
}