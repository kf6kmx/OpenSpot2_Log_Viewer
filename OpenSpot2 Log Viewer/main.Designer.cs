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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceIPAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.radioidlookup = new System.Windows.Forms.TabPage();
            this.txtRadioIDNotes = new System.Windows.Forms.TextBox();
            this.txtRadioIDLocation = new System.Windows.Forms.TextBox();
            this.txtRadioIDCallsign = new System.Windows.Forms.TextBox();
            this.txtRadioIDName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDMRLookupID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDMRLookup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOSname = new System.Windows.Forms.TextBox();
            this.txtOSnotes = new System.Windows.Forms.TextBox();
            this.txtOSlocation = new System.Windows.Forms.TextBox();
            this.txtOScallsign = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lastheard = new System.Windows.Forms.TabPage();
            this.heardhistory = new System.Windows.Forms.TabPage();
            this.radioidhistory = new System.Windows.Forms.TabPage();
            this.txtPriorcallsign = new System.Windows.Forms.TextBox();
            this.txtPriorlocation = new System.Windows.Forms.TextBox();
            this.txtPriornotes = new System.Windows.Forms.TextBox();
            this.txtPriorName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgRadioidHistory = new System.Windows.Forms.DataGridView();
            this.dgHeardHistory = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Callsign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.radioidlookup.SuspendLayout();
            this.lastheard.SuspendLayout();
            this.heardhistory.SuspendLayout();
            this.radioidhistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRadioidHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeardHistory)).BeginInit();
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
            this.tabControl1.Controls.Add(this.lastheard);
            this.tabControl1.Controls.Add(this.heardhistory);
            this.tabControl1.Controls.Add(this.radioidlookup);
            this.tabControl1.Controls.Add(this.radioidhistory);
            this.tabControl1.Location = new System.Drawing.Point(12, 517);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1230, 405);
            this.tabControl1.TabIndex = 1;
            // 
            // radioidlookup
            // 
            this.radioidlookup.BackColor = System.Drawing.Color.LightGreen;
            this.radioidlookup.Controls.Add(this.txtRadioIDNotes);
            this.radioidlookup.Controls.Add(this.txtRadioIDLocation);
            this.radioidlookup.Controls.Add(this.txtRadioIDCallsign);
            this.radioidlookup.Controls.Add(this.txtRadioIDName);
            this.radioidlookup.Controls.Add(this.label5);
            this.radioidlookup.Controls.Add(this.label4);
            this.radioidlookup.Controls.Add(this.label3);
            this.radioidlookup.Controls.Add(this.label2);
            this.radioidlookup.Controls.Add(this.txtDMRLookupID);
            this.radioidlookup.Controls.Add(this.label1);
            this.radioidlookup.Controls.Add(this.btDMRLookup);
            this.radioidlookup.Location = new System.Drawing.Point(8, 39);
            this.radioidlookup.Name = "radioidlookup";
            this.radioidlookup.Padding = new System.Windows.Forms.Padding(3);
            this.radioidlookup.Size = new System.Drawing.Size(1214, 358);
            this.radioidlookup.TabIndex = 0;
            this.radioidlookup.Text = "RadioID Lookup";
            // 
            // txtRadioIDNotes
            // 
            this.txtRadioIDNotes.Location = new System.Drawing.Point(137, 236);
            this.txtRadioIDNotes.Multiline = true;
            this.txtRadioIDNotes.Name = "txtRadioIDNotes";
            this.txtRadioIDNotes.Size = new System.Drawing.Size(438, 102);
            this.txtRadioIDNotes.TabIndex = 10;
            // 
            // txtRadioIDLocation
            // 
            this.txtRadioIDLocation.Location = new System.Drawing.Point(137, 192);
            this.txtRadioIDLocation.Name = "txtRadioIDLocation";
            this.txtRadioIDLocation.Size = new System.Drawing.Size(438, 31);
            this.txtRadioIDLocation.TabIndex = 9;
            // 
            // txtRadioIDCallsign
            // 
            this.txtRadioIDCallsign.Location = new System.Drawing.Point(137, 145);
            this.txtRadioIDCallsign.Name = "txtRadioIDCallsign";
            this.txtRadioIDCallsign.Size = new System.Drawing.Size(438, 31);
            this.txtRadioIDCallsign.TabIndex = 8;
            this.txtRadioIDCallsign.TextChanged += new System.EventHandler(this.txtRadioIDCallsign_TextChanged);
            // 
            // txtRadioIDName
            // 
            this.txtRadioIDName.Location = new System.Drawing.Point(137, 104);
            this.txtRadioIDName.Name = "txtRadioIDName";
            this.txtRadioIDName.Size = new System.Drawing.Size(438, 31);
            this.txtRadioIDName.TabIndex = 7;
            this.txtRadioIDName.TextChanged += new System.EventHandler(this.txtRadioIDName_TextChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Callsign";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtDMRLookupID
            // 
            this.txtDMRLookupID.Location = new System.Drawing.Point(137, 22);
            this.txtDMRLookupID.Name = "txtDMRLookupID";
            this.txtDMRLookupID.Size = new System.Drawing.Size(296, 31);
            this.txtDMRLookupID.TabIndex = 0;
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
            // btDMRLookup
            // 
            this.btDMRLookup.BackColor = System.Drawing.Color.PaleGreen;
            this.btDMRLookup.Location = new System.Drawing.Point(455, 18);
            this.btDMRLookup.Name = "btDMRLookup";
            this.btDMRLookup.Size = new System.Drawing.Size(140, 45);
            this.btDMRLookup.TabIndex = 1;
            this.btDMRLookup.Text = "Lookup";
            this.btDMRLookup.UseVisualStyleBackColor = false;
            this.btDMRLookup.Click += new System.EventHandler(this.btDMRLookup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 55);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 55);
            this.label7.TabIndex = 3;
            this.label7.Text = "Notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 55);
            this.label8.TabIndex = 4;
            this.label8.Text = "Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(113, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 55);
            this.label9.TabIndex = 5;
            this.label9.Text = "Callsign";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOSname
            // 
            this.txtOSname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSname.Location = new System.Drawing.Point(315, 103);
            this.txtOSname.Name = "txtOSname";
            this.txtOSname.Size = new System.Drawing.Size(696, 62);
            this.txtOSname.TabIndex = 6;
            // 
            // txtOSnotes
            // 
            this.txtOSnotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSnotes.Location = new System.Drawing.Point(315, 357);
            this.txtOSnotes.Multiline = true;
            this.txtOSnotes.Name = "txtOSnotes";
            this.txtOSnotes.Size = new System.Drawing.Size(696, 154);
            this.txtOSnotes.TabIndex = 7;
            // 
            // txtOSlocation
            // 
            this.txtOSlocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOSlocation.Location = new System.Drawing.Point(315, 270);
            this.txtOSlocation.Name = "txtOSlocation";
            this.txtOSlocation.Size = new System.Drawing.Size(696, 62);
            this.txtOSlocation.TabIndex = 8;
            // 
            // txtOScallsign
            // 
            this.txtOScallsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOScallsign.Location = new System.Drawing.Point(315, 184);
            this.txtOScallsign.Name = "txtOScallsign";
            this.txtOScallsign.Size = new System.Drawing.Size(696, 62);
            this.txtOScallsign.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(308, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(320, 42);
            this.label10.TabIndex = 10;
            this.label10.Text = "Latest/Current call";
            // 
            // lastheard
            // 
            this.lastheard.BackColor = System.Drawing.Color.Transparent;
            this.lastheard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lastheard.Controls.Add(this.txtPriorcallsign);
            this.lastheard.Controls.Add(this.txtPriorlocation);
            this.lastheard.Controls.Add(this.txtPriornotes);
            this.lastheard.Controls.Add(this.txtPriorName);
            this.lastheard.Controls.Add(this.label11);
            this.lastheard.Controls.Add(this.label14);
            this.lastheard.Controls.Add(this.label12);
            this.lastheard.Controls.Add(this.label13);
            this.lastheard.Location = new System.Drawing.Point(8, 39);
            this.lastheard.Name = "lastheard";
            this.lastheard.Padding = new System.Windows.Forms.Padding(3);
            this.lastheard.Size = new System.Drawing.Size(1214, 358);
            this.lastheard.TabIndex = 1;
            this.lastheard.Text = "Last heard";
            // 
            // heardhistory
            // 
            this.heardhistory.BackColor = System.Drawing.Color.LightGray;
            this.heardhistory.Controls.Add(this.dgHeardHistory);
            this.heardhistory.Location = new System.Drawing.Point(8, 39);
            this.heardhistory.Name = "heardhistory";
            this.heardhistory.Size = new System.Drawing.Size(1214, 358);
            this.heardhistory.TabIndex = 2;
            this.heardhistory.Text = "Heard History";
            // 
            // radioidhistory
            // 
            this.radioidhistory.BackColor = System.Drawing.Color.Cyan;
            this.radioidhistory.Controls.Add(this.dgRadioidHistory);
            this.radioidhistory.Location = new System.Drawing.Point(8, 39);
            this.radioidhistory.Name = "radioidhistory";
            this.radioidhistory.Size = new System.Drawing.Size(1214, 358);
            this.radioidhistory.TabIndex = 3;
            this.radioidhistory.Text = "RadioID history";
            // 
            // txtPriorcallsign
            // 
            this.txtPriorcallsign.Location = new System.Drawing.Point(213, 94);
            this.txtPriorcallsign.Name = "txtPriorcallsign";
            this.txtPriorcallsign.Size = new System.Drawing.Size(364, 31);
            this.txtPriorcallsign.TabIndex = 27;
            // 
            // txtPriorlocation
            // 
            this.txtPriorlocation.Location = new System.Drawing.Point(213, 143);
            this.txtPriorlocation.Name = "txtPriorlocation";
            this.txtPriorlocation.Size = new System.Drawing.Size(364, 31);
            this.txtPriorlocation.TabIndex = 26;
            // 
            // txtPriornotes
            // 
            this.txtPriornotes.Location = new System.Drawing.Point(213, 197);
            this.txtPriornotes.Multiline = true;
            this.txtPriornotes.Name = "txtPriornotes";
            this.txtPriornotes.Size = new System.Drawing.Size(364, 121);
            this.txtPriornotes.TabIndex = 25;
            // 
            // txtPriorName
            // 
            this.txtPriorName.Location = new System.Drawing.Point(213, 40);
            this.txtPriorName.Name = "txtPriorName";
            this.txtPriorName.Size = new System.Drawing.Size(364, 31);
            this.txtPriorName.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(85, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 31);
            this.label11.TabIndex = 23;
            this.label11.Text = "Callsign";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(110, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 31);
            this.label14.TabIndex = 20;
            this.label14.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 31);
            this.label12.TabIndex = 22;
            this.label12.Text = "Location";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(110, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 31);
            this.label13.TabIndex = 21;
            this.label13.Text = "Notes";
            // 
            // dgRadioidHistory
            // 
            this.dgRadioidHistory.AllowUserToAddRows = false;
            this.dgRadioidHistory.AllowUserToDeleteRows = false;
            this.dgRadioidHistory.AllowUserToOrderColumns = true;
            this.dgRadioidHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRadioidHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Callsign,
            this.location,
            this.notes});
            this.dgRadioidHistory.Location = new System.Drawing.Point(16, 13);
            this.dgRadioidHistory.Name = "dgRadioidHistory";
            this.dgRadioidHistory.ReadOnly = true;
            this.dgRadioidHistory.RowHeadersWidth = 82;
            this.dgRadioidHistory.RowTemplate.Height = 33;
            this.dgRadioidHistory.Size = new System.Drawing.Size(1183, 333);
            this.dgRadioidHistory.TabIndex = 1;
            // 
            // dgHeardHistory
            // 
            this.dgHeardHistory.AllowUserToAddRows = false;
            this.dgHeardHistory.AllowUserToDeleteRows = false;
            this.dgHeardHistory.AllowUserToOrderColumns = true;
            this.dgHeardHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHeardHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgHeardHistory.Location = new System.Drawing.Point(16, 13);
            this.dgHeardHistory.Name = "dgHeardHistory";
            this.dgHeardHistory.ReadOnly = true;
            this.dgHeardHistory.RowHeadersWidth = 82;
            this.dgHeardHistory.RowTemplate.Height = 33;
            this.dgHeardHistory.Size = new System.Drawing.Size(1183, 333);
            this.dgHeardHistory.TabIndex = 2;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // Callsign
            // 
            this.Callsign.HeaderText = "Callsign";
            this.Callsign.MinimumWidth = 10;
            this.Callsign.Name = "Callsign";
            this.Callsign.ReadOnly = true;
            this.Callsign.Width = 200;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.MinimumWidth = 10;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Width = 200;
            // 
            // notes
            // 
            this.notes.HeaderText = "Notes";
            this.notes.MinimumWidth = 10;
            this.notes.Name = "notes";
            this.notes.ReadOnly = true;
            this.notes.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Callsign";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Location";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // main
            // 
            this.AcceptButton = this.btDMRLookup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1254, 953);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOScallsign);
            this.Controls.Add(this.txtOSlocation);
            this.Controls.Add(this.txtOSnotes);
            this.Controls.Add(this.txtOSname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "OpenSpot2 Live Log";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.radioidlookup.ResumeLayout(false);
            this.radioidlookup.PerformLayout();
            this.lastheard.ResumeLayout(false);
            this.lastheard.PerformLayout();
            this.heardhistory.ResumeLayout(false);
            this.radioidhistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRadioidHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeardHistory)).EndInit();
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
        private System.Windows.Forms.TabPage radioidlookup;
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOSname;
        private System.Windows.Forms.TextBox txtOSnotes;
        private System.Windows.Forms.TextBox txtOSlocation;
        private System.Windows.Forms.TextBox txtOScallsign;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage lastheard;
        private System.Windows.Forms.TabPage heardhistory;
        private System.Windows.Forms.TabPage radioidhistory;
        private System.Windows.Forms.TextBox txtPriorcallsign;
        private System.Windows.Forms.TextBox txtPriorlocation;
        private System.Windows.Forms.TextBox txtPriornotes;
        private System.Windows.Forms.TextBox txtPriorName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgHeardHistory;
        private System.Windows.Forms.DataGridView dgRadioidHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Callsign;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

