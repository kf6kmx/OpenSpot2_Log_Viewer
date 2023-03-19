namespace OpenSpot2_Log_Viewer
{
    partial class main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceIPAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btDMRLookup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDMRLookupID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRadioIDName = new System.Windows.Forms.TextBox();
            this.txtRadioIDCallsign = new System.Windows.Forms.TextBox();
            this.txtRadioIDLocation = new System.Windows.Forms.TextBox();
            this.txtRadioIDNotes = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceIPAddressToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(96, 36);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // deviceIPAddressToolStripMenuItem
            // 
            this.deviceIPAddressToolStripMenuItem.Name = "deviceIPAddressToolStripMenuItem";
            this.deviceIPAddressToolStripMenuItem.Size = new System.Drawing.Size(361, 44);
            this.deviceIPAddressToolStripMenuItem.Text = "OpenSpot2 Settings";
            this.deviceIPAddressToolStripMenuItem.Click += new System.EventHandler(this.deviceIPAddressToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(84, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(212, 44);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(570, 517);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 405);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRadioIDNotes);
            this.tabPage1.Controls.Add(this.txtRadioIDLocation);
            this.tabPage1.Controls.Add(this.txtRadioIDCallsign);
            this.tabPage1.Controls.Add(this.txtRadioIDName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtDMRLookupID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btDMRLookup);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RadioID Lookup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btDMRLookup
            // 
            this.btDMRLookup.BackColor = System.Drawing.Color.PaleGreen;
            this.btDMRLookup.Location = new System.Drawing.Point(455, 18);
            this.btDMRLookup.Name = "btDMRLookup";
            this.btDMRLookup.Size = new System.Drawing.Size(140, 45);
            this.btDMRLookup.TabIndex = 0;
            this.btDMRLookup.Text = "Lookup";
            this.btDMRLookup.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DMR ID";
            // 
            // txtDMRLookupID
            // 
            this.txtDMRLookupID.Location = new System.Drawing.Point(137, 22);
            this.txtDMRLookupID.Name = "txtDMRLookupID";
            this.txtDMRLookupID.Size = new System.Drawing.Size(296, 31);
            this.txtDMRLookupID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Callsign";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Notes";
            // 
            // txtRadioIDName
            // 
            this.txtRadioIDName.Location = new System.Drawing.Point(137, 104);
            this.txtRadioIDName.Name = "txtRadioIDName";
            this.txtRadioIDName.Size = new System.Drawing.Size(438, 31);
            this.txtRadioIDName.TabIndex = 7;
            this.txtRadioIDName.TextChanged += new System.EventHandler(this.txtRadioIDName_TextChanged);
            // 
            // txtRadioIDCallsign
            // 
            this.txtRadioIDCallsign.Location = new System.Drawing.Point(137, 145);
            this.txtRadioIDCallsign.Name = "txtRadioIDCallsign";
            this.txtRadioIDCallsign.Size = new System.Drawing.Size(438, 31);
            this.txtRadioIDCallsign.TabIndex = 8;
            this.txtRadioIDCallsign.TextChanged += new System.EventHandler(this.txtRadioIDCallsign_TextChanged);
            // 
            // txtRadioIDLocation
            // 
            this.txtRadioIDLocation.Location = new System.Drawing.Point(137, 192);
            this.txtRadioIDLocation.Name = "txtRadioIDLocation";
            this.txtRadioIDLocation.Size = new System.Drawing.Size(438, 31);
            this.txtRadioIDLocation.TabIndex = 9;
            // 
            // txtRadioIDNotes
            // 
            this.txtRadioIDNotes.Location = new System.Drawing.Point(137, 236);
            this.txtRadioIDNotes.Multiline = true;
            this.txtRadioIDNotes.Name = "txtRadioIDNotes";
            this.txtRadioIDNotes.Size = new System.Drawing.Size(438, 102);
            this.txtRadioIDNotes.TabIndex = 10;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1254, 953);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "OpenSpot2 Live Log";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceIPAddressToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtDMRLookupID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDMRLookup;
        private System.Windows.Forms.TextBox txtRadioIDNotes;
        private System.Windows.Forms.TextBox txtRadioIDLocation;
        private System.Windows.Forms.TextBox txtRadioIDCallsign;
        private System.Windows.Forms.TextBox txtRadioIDName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

