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
            this.chkDisableColours = new System.Windows.Forms.CheckBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.screenColorPicker1 = new Cyotek.Windows.Forms.ScreenColorPicker();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // chkDisableColours
            // 
            this.chkDisableColours.AutoSize = true;
            this.chkDisableColours.Location = new System.Drawing.Point(12, 30);
            this.chkDisableColours.Name = "chkDisableColours";
            this.chkDisableColours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkDisableColours.Size = new System.Drawing.Size(103, 19);
            this.chkDisableColours.TabIndex = 0;
            this.chkDisableColours.Text = "Disable Colour";
            this.toolTip1.SetToolTip(this.chkDisableColours, "Disables checking \"Join\" buttons colour.\r\nEssentially having this checked will co" +
        "ntinuously click join rather than checking if it can be clicked");
            this.chkDisableColours.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(12, 55);
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
            this.screenColorPicker1.Location = new System.Drawing.Point(204, 12);
            this.screenColorPicker1.Name = "screenColorPicker1";
            this.screenColorPicker1.Size = new System.Drawing.Size(120, 120);
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
            this.nudDelay.Location = new System.Drawing.Point(120, 10);
            this.nudDelay.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudDelay.Minimum = new decimal(new int[] {
            200,
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
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Min clickrate (ms)";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 140);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDelay);
            this.Controls.Add(this.screenColorPicker1);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.chkDisableColours);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(352, 179);
            this.MinimumSize = new System.Drawing.Size(352, 179);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SIM70";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkDisableColours;
        private Button btnStatus;
        private Cyotek.Windows.Forms.ScreenColorPicker screenColorPicker1;
        private NumericUpDown nudDelay;
        private Label label1;
        private ToolTip toolTip1;
    }
}