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
            this.screenColorPicker1 = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.scpServerSelect = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.nudSelectServerEvery = new System.Windows.Forms.NumericUpDown();
            this.chkSelectServer = new System.Windows.Forms.CheckBox();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnDonate = new System.Windows.Forms.Button();
            this.chkAdvanced = new System.Windows.Forms.CheckBox();
            this.lblServerSelectMode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectServerEvery)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(9, 46);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(186, 77);
            this.btnStatus.TabIndex = 10;
            this.btnStatus.Text = "Start (F2)";
            this.toolTip1.SetToolTip(this.btnStatus, "Starts the sim. F2 can also toggle the sim on and off");
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // screenColorPicker1
            // 
            this.screenColorPicker1.Color = System.Drawing.Color.Empty;
            this.screenColorPicker1.Location = new System.Drawing.Point(201, 22);
            this.screenColorPicker1.Name = "screenColorPicker1";
            this.screenColorPicker1.Size = new System.Drawing.Size(117, 126);
            this.screenColorPicker1.Text = "Drag me to the \"Join\" button!";
            this.toolTip1.SetToolTip(this.screenColorPicker1, resources.GetString("screenColorPicker1.ToolTip"));
            this.screenColorPicker1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.screenColorPicker1_MouseUp);
            // 
            // nudDelay
            // 
            this.nudDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDelay.Location = new System.Drawing.Point(117, 17);
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
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Min clickrate (ms)";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // scpServerSelect
            // 
            this.scpServerSelect.Color = System.Drawing.Color.Empty;
            this.scpServerSelect.Location = new System.Drawing.Point(186, 22);
            this.scpServerSelect.Name = "scpServerSelect";
            this.scpServerSelect.Size = new System.Drawing.Size(129, 129);
            this.scpServerSelect.Text = "Drag me to the server list";
            this.toolTip1.SetToolTip(this.scpServerSelect, "Click and drag to the server in the server list (see the video tutorial if you\'re" +
        " unsure)\r\nEnsure the Ark screen is visible.\r\n\r\nOnce your cursor is in the right " +
        "place, simply release your click.");
            this.scpServerSelect.Visible = false;
            this.scpServerSelect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scpServerSelect_MouseUp);
            // 
            // nudSelectServerEvery
            // 
            this.nudSelectServerEvery.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSelectServerEvery.Location = new System.Drawing.Point(108, 42);
            this.nudSelectServerEvery.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSelectServerEvery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSelectServerEvery.Name = "nudSelectServerEvery";
            this.nudSelectServerEvery.Size = new System.Drawing.Size(59, 23);
            this.nudSelectServerEvery.TabIndex = 17;
            this.toolTip1.SetToolTip(this.nudSelectServerEvery, "How many clicks must have passed before we attempt to use the server select mode?" +
        "");
            this.nudSelectServerEvery.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudSelectServerEvery.Visible = false;
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
            // chkAdvanced
            // 
            this.chkAdvanced.AutoSize = true;
            this.chkAdvanced.Location = new System.Drawing.Point(9, 129);
            this.chkAdvanced.Name = "chkAdvanced";
            this.chkAdvanced.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAdvanced.Size = new System.Drawing.Size(113, 19);
            this.chkAdvanced.TabIndex = 14;
            this.chkAdvanced.Text = "Advanced Mode";
            this.chkAdvanced.UseVisualStyleBackColor = true;
            this.chkAdvanced.CheckedChanged += new System.EventHandler(this.chkAdvanced_CheckedChanged);
            // 
            // lblServerSelectMode
            // 
            this.lblServerSelectMode.AutoSize = true;
            this.lblServerSelectMode.Location = new System.Drawing.Point(6, 44);
            this.lblServerSelectMode.Name = "lblServerSelectMode";
            this.lblServerSelectMode.Size = new System.Drawing.Size(75, 15);
            this.lblServerSelectMode.TabIndex = 18;
            this.lblServerSelectMode.Text = "every (clicks)";
            this.lblServerSelectMode.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSelectServer);
            this.groupBox1.Controls.Add(this.scpServerSelect);
            this.groupBox1.Controls.Add(this.lblServerSelectMode);
            this.groupBox1.Controls.Add(this.nudSelectServerEvery);
            this.groupBox1.Location = new System.Drawing.Point(9, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 165);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Select Mode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStatus);
            this.groupBox2.Controls.Add(this.nudDelay);
            this.groupBox2.Controls.Add(this.screenColorPicker1);
            this.groupBox2.Controls.Add(this.chkAdvanced);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 162);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 382);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 249);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SIM70";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSelectServerEvery)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnStatus;
        private Cyotek.Windows.Forms.ScreenColorPicker screenColorPicker1;
        private NumericUpDown nudDelay;
        private Label label1;
        private ToolTip toolTip1;
        private CheckBox chkAdvanced;
        private Cyotek.Windows.Forms.ScreenColorPicker scpServerSelect;
        private CheckBox chkSelectServer;
        private NumericUpDown nudSelectServerEvery;
        private Label lblServerSelectMode;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnGithub;
        private Button btnDonate;
    }
}