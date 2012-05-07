namespace Syeon
{
    partial class frmMain
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
            this.pctSimSurface = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtScriptText = new System.Windows.Forms.RichTextBox();
            this.tabFiles = new System.Windows.Forms.TabControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRunStop = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.rdoClearLog = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctSimSurface)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabFiles.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctSimSurface
            // 
            this.pctSimSurface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctSimSurface.Location = new System.Drawing.Point(304, 27);
            this.pctSimSurface.Name = "pctSimSurface";
            this.pctSimSurface.Size = new System.Drawing.Size(493, 321);
            this.pctSimSurface.TabIndex = 0;
            this.pctSimSurface.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtScriptText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(278, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "[Untitled simulation 1]";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtScriptText
            // 
            this.rtScriptText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtScriptText.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtScriptText.Location = new System.Drawing.Point(3, 3);
            this.rtScriptText.Name = "rtScriptText";
            this.rtScriptText.Size = new System.Drawing.Size(272, 428);
            this.rtScriptText.TabIndex = 0;
            this.rtScriptText.Text = "";
            // 
            // tabFiles
            // 
            this.tabFiles.Controls.Add(this.tabPage1);
            this.tabFiles.Location = new System.Drawing.Point(12, 27);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.SelectedIndex = 0;
            this.tabFiles.Size = new System.Drawing.Size(286, 460);
            this.tabFiles.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 494);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(803, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatus.Text = "Ready.";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.simulationToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(803, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSimulationToolStripMenuItem,
            this.openSimulationToolStripMenuItem,
            this.closeSimulationToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newSimulationToolStripMenuItem
            // 
            this.newSimulationToolStripMenuItem.Name = "newSimulationToolStripMenuItem";
            this.newSimulationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newSimulationToolStripMenuItem.Text = "&New simulation";
            // 
            // openSimulationToolStripMenuItem
            // 
            this.openSimulationToolStripMenuItem.Name = "openSimulationToolStripMenuItem";
            this.openSimulationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openSimulationToolStripMenuItem.Text = "&Open simulation";
            this.openSimulationToolStripMenuItem.Click += new System.EventHandler(this.openSimulationToolStripMenuItem_Click);
            // 
            // closeSimulationToolStripMenuItem
            // 
            this.closeSimulationToolStripMenuItem.Name = "closeSimulationToolStripMenuItem";
            this.closeSimulationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.closeSimulationToolStripMenuItem.Text = "&Close simulation";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runStopToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.simulationToolStripMenuItem.Text = "&Simulation";
            // 
            // runStopToolStripMenuItem
            // 
            this.runStopToolStripMenuItem.Name = "runStopToolStripMenuItem";
            this.runStopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.runStopToolStripMenuItem.Text = "Run / Stop";
            this.runStopToolStripMenuItem.Click += new System.EventHandler(this.runStopToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.manualToolStripMenuItem.Text = "&Manual";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // btnRunStop
            // 
            this.btnRunStop.Enabled = false;
            this.btnRunStop.Location = new System.Drawing.Point(304, 364);
            this.btnRunStop.Name = "btnRunStop";
            this.btnRunStop.Size = new System.Drawing.Size(68, 123);
            this.btnRunStop.TabIndex = 4;
            this.btnRunStop.Text = "Run";
            this.btnRunStop.UseVisualStyleBackColor = true;
            this.btnRunStop.Click += new System.EventHandler(this.btnRunStop_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtLog.Location = new System.Drawing.Point(378, 364);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(419, 98);
            this.txtLog.TabIndex = 5;
            // 
            // rdoClearLog
            // 
            this.rdoClearLog.AutoSize = true;
            this.rdoClearLog.Location = new System.Drawing.Point(379, 469);
            this.rdoClearLog.Name = "rdoClearLog";
            this.rdoClearLog.Size = new System.Drawing.Size(175, 17);
            this.rdoClearLog.TabIndex = 6;
            this.rdoClearLog.Text = "&Clear log on new simulation run.";
            this.rdoClearLog.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 516);
            this.Controls.Add(this.rdoClearLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnRunStop);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tabFiles);
            this.Controls.Add(this.pctSimSurface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Syeon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pctSimSurface)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSimSurface;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabFiles;
        private System.Windows.Forms.RichTextBox rtScriptText;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.Button btnRunStop;
        private System.Windows.Forms.ToolStripMenuItem newSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.CheckBox rdoClearLog;
    }
}