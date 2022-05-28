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
            this.scpServerSelect = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.chkSelectServer = new System.Windows.Forms.CheckBox();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnDonate = new System.Windows.Forms.Button();
            this.chkColourCheckMode = new System.Windows.Forms.CheckBox();
            this.chkAutoDelay = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbHotkey = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblComingSoon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(9, 22);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(266, 114);
            this.btnStatus.TabIndex = 10;
            this.btnStatus.Text = "Start (F2)";
            this.toolTip1.SetToolTip(this.btnStatus, "Starts the sim. F2 can also toggle the sim on and off");
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // pickerJoin
            // 
            this.pickerJoin.Color = System.Drawing.Color.Empty;
            this.pickerJoin.Location = new System.Drawing.Point(278, 22);
            this.pickerJoin.Name = "pickerJoin";
            this.pickerJoin.Size = new System.Drawing.Size(115, 114);
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
            this.nudDelay.Location = new System.Drawing.Point(334, 170);
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
            500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Min clickrate (ms)";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // scpServerSelect
            // 
            this.scpServerSelect.Color = System.Drawing.Color.Empty;
            this.scpServerSelect.Location = new System.Drawing.Point(312, 22);
            this.scpServerSelect.Name = "scpServerSelect";
            this.scpServerSelect.Size = new System.Drawing.Size(81, 79);
            this.scpServerSelect.Text = "Drag me to the server list";
            this.toolTip1.SetToolTip(this.scpServerSelect, "Click and drag to the server in the server list (see the video tutorial if you\'re" +
        " unsure)\r\nEnsure the Ark screen is visible.\r\n\r\nOnce your cursor is in the right " +
        "place, simply release your click.");
            this.scpServerSelect.Visible = false;
            this.scpServerSelect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scpServerSelect_MouseUp);
            // 
            // chkSelectServer
            // 
            this.chkSelectServer.AutoSize = true;
            this.chkSelectServer.Location = new System.Drawing.Point(6, 22);
            this.chkSelectServer.Name = "chkSelectServer";
            this.chkSelectServer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkSelectServer.Size = new System.Drawing.Size(91, 19);
            this.chkSelectServer.TabIndex = 16;
            this.chkSelectServer.Text = "Select server";
            this.toolTip1.SetToolTip(this.chkSelectServer, resources.GetString("chkSelectServer.ToolTip"));
            this.chkSelectServer.UseVisualStyleBackColor = true;
            this.chkSelectServer.CheckStateChanged += new System.EventHandler(this.chkSelectServer_CheckStateChanged);
            // 
            // btnGithub
            // 
            this.btnGithub.Location = new System.Drawing.Point(9, 12);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(75, 23);
            this.btnGithub.TabIndex = 21;
            this.btnGithub.Text = "Github";
            this.toolTip1.SetToolTip(this.btnGithub, "Takes you to the github for the project");
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.Location = new System.Drawing.Point(90, 12);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(75, 23);
            this.btnDonate.TabIndex = 22;
            this.btnDonate.Text = "Donate";
            this.toolTip1.SetToolTip(this.btnDonate, "Takes you to the github for the project");
            this.btnDonate.UseVisualStyleBackColor = true;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // chkColourCheckMode
            // 
            this.chkColourCheckMode.AutoSize = true;
            this.chkColourCheckMode.Checked = true;
            this.chkColourCheckMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColourCheckMode.Location = new System.Drawing.Point(24, 146);
            this.chkColourCheckMode.Name = "chkColourCheckMode";
            this.chkColourCheckMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkColourCheckMode.Size = new System.Drawing.Size(132, 19);
            this.chkColourCheckMode.TabIndex = 14;
            this.chkColourCheckMode.Text = "Colour Check Mode";
            this.toolTip1.SetToolTip(this.chkColourCheckMode, "Enabling colour checking allows SIM70 to use additional features");
            this.chkColourCheckMode.UseVisualStyleBackColor = true;
            this.chkColourCheckMode.CheckedChanged += new System.EventHandler(this.chkColourCheckMode_CheckedChanged);
            // 
            // chkAutoDelay
            // 
            this.chkAutoDelay.AutoSize = true;
            this.chkAutoDelay.Checked = true;
            this.chkAutoDelay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoDelay.Location = new System.Drawing.Point(21, 171);
            this.chkAutoDelay.Name = "chkAutoDelay";
            this.chkAutoDelay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAutoDelay.Size = new System.Drawing.Size(135, 19);
            this.chkAutoDelay.TabIndex = 15;
            this.chkAutoDelay.Text = "Auto Clickrate Mode";
            this.toolTip1.SetToolTip(this.chkAutoDelay, "Enable auto delay detection - This will run a short test on the current ark serve" +
        "r to work out what click delay will work well ");
            this.chkAutoDelay.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSelectServer);
            this.groupBox1.Controls.Add(this.scpServerSelect);
            this.groupBox1.Location = new System.Drawing.Point(12, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 115);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Select Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAutoDelay);
            this.groupBox2.Controls.Add(this.btnStatus);
            this.groupBox2.Controls.Add(this.pickerJoin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkColourCheckMode);
            this.groupBox2.Controls.Add(this.nudDelay);
            this.groupBox2.Location = new System.Drawing.Point(12, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 201);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // cmbHotkey
            // 
            this.cmbHotkey.FormattingEnabled = true;
            this.cmbHotkey.Location = new System.Drawing.Point(290, 13);
            this.cmbHotkey.Name = "cmbHotkey";
            this.cmbHotkey.Size = new System.Drawing.Size(121, 23);
            this.cmbHotkey.TabIndex = 23;
            this.cmbHotkey.SelectedIndexChanged += new System.EventHandler(this.cmbHotkey_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Start/Stop Hotkey";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblComingSoon);
            this.groupBox3.Location = new System.Drawing.Point(12, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 55);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discord Alerts";
            // 
            // lblComingSoon
            // 
            this.lblComingSoon.AutoSize = true;
            this.lblComingSoon.Location = new System.Drawing.Point(9, 19);
            this.lblComingSoon.Name = "lblComingSoon";
            this.lblComingSoon.Size = new System.Drawing.Size(103, 15);
            this.lblComingSoon.TabIndex = 0;
            this.lblComingSoon.Text = "Coming Soon(tm)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 431);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHotkey);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 470);
            this.MinimumSize = new System.Drawing.Size(435, 470);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SIM70";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnStatus;
        private Cyotek.Windows.Forms.ScreenColorPicker pickerJoin;
        private NumericUpDown nudDelay;
        private Label label1;
        private ToolTip toolTip1;
        private CheckBox chkColourCheckMode;
        private Cyotek.Windows.Forms.ScreenColorPicker scpServerSelect;
        private CheckBox chkSelectServer;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnGithub;
        private Button btnDonate;
        private CheckBox chkAutoDelay;
        private ComboBox cmbHotkey;
        private Label label2;
        private GroupBox groupBox3;
        private Label lblComingSoon;
    }
}