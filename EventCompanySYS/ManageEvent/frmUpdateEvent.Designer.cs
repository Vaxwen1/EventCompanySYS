namespace EventCompanySYS
{
    partial class frmUpdateEvent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbEventInformation = new System.Windows.Forms.GroupBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPerformer = new System.Windows.Forms.TextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumbOfTickets = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grvEvents = new System.Windows.Forms.DataGridView();
            this.grpClients = new System.Windows.Forms.GroupBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.grpVenues = new System.Windows.Forms.GroupBox();
            this.dgvVenues = new System.Windows.Forms.DataGridView();
            this.grpPerformers = new System.Windows.Forms.GroupBox();
            this.dgvPerformers = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.lblNumberOfSoldTickets = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grbEventInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEvents)).BeginInit();
            this.grpClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.grpVenues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenues)).BeginInit();
            this.grpPerformers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1347, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "mnuUpdateClient";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Find.Location = new System.Drawing.Point(859, 92);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(44, 24);
            this.btn_Find.TabIndex = 26;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(464, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(540, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(313, 26);
            this.txtSearch.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(634, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Update Event";
            // 
            // grbEventInformation
            // 
            this.grbEventInformation.Controls.Add(this.lblNumberOfSoldTickets);
            this.grbEventInformation.Controls.Add(this.label18);
            this.grbEventInformation.Controls.Add(this.txtClient);
            this.grbEventInformation.Controls.Add(this.label17);
            this.grbEventInformation.Controls.Add(this.txtPerformer);
            this.grbEventInformation.Controls.Add(this.txtVenue);
            this.grbEventInformation.Controls.Add(this.txtCapacity);
            this.grbEventInformation.Controls.Add(this.label16);
            this.grbEventInformation.Controls.Add(this.cmbStatus);
            this.grbEventInformation.Controls.Add(this.label8);
            this.grbEventInformation.Controls.Add(this.txtDescription);
            this.grbEventInformation.Controls.Add(this.label9);
            this.grbEventInformation.Controls.Add(this.txtPrice);
            this.grbEventInformation.Controls.Add(this.label6);
            this.grbEventInformation.Controls.Add(this.txtDuration);
            this.grbEventInformation.Controls.Add(this.txtEventId);
            this.grbEventInformation.Controls.Add(this.label14);
            this.grbEventInformation.Controls.Add(this.label13);
            this.grbEventInformation.Controls.Add(this.label15);
            this.grbEventInformation.Controls.Add(this.txtStartTime);
            this.grbEventInformation.Controls.Add(this.label12);
            this.grbEventInformation.Controls.Add(this.dtpDate);
            this.grbEventInformation.Controls.Add(this.cmbEventType);
            this.grbEventInformation.Controls.Add(this.label11);
            this.grbEventInformation.Controls.Add(this.txtNumbOfTickets);
            this.grbEventInformation.Controls.Add(this.label10);
            this.grbEventInformation.Controls.Add(this.label7);
            this.grbEventInformation.Controls.Add(this.label5);
            this.grbEventInformation.Controls.Add(this.label4);
            this.grbEventInformation.Controls.Add(this.txtEventName);
            this.grbEventInformation.Controls.Add(this.label3);
            this.grbEventInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbEventInformation.Location = new System.Drawing.Point(422, 144);
            this.grbEventInformation.Name = "grbEventInformation";
            this.grbEventInformation.Size = new System.Drawing.Size(456, 493);
            this.grbEventInformation.TabIndex = 27;
            this.grbEventInformation.TabStop = false;
            this.grbEventInformation.Text = "UpdateEvent";
            // 
            // txtClient
            // 
            this.txtClient.Enabled = false;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtClient.Location = new System.Drawing.Point(170, 111);
            this.txtClient.MaxLength = 50;
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(221, 23);
            this.txtClient.TabIndex = 77;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(28, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 17);
            this.label17.TabIndex = 76;
            this.label17.Text = "Client";
            // 
            // txtPerformer
            // 
            this.txtPerformer.Enabled = false;
            this.txtPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPerformer.Location = new System.Drawing.Point(170, 285);
            this.txtPerformer.MaxLength = 50;
            this.txtPerformer.Name = "txtPerformer";
            this.txtPerformer.Size = new System.Drawing.Size(221, 23);
            this.txtPerformer.TabIndex = 75;
            // 
            // txtVenue
            // 
            this.txtVenue.Enabled = false;
            this.txtVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVenue.Location = new System.Drawing.Point(170, 249);
            this.txtVenue.MaxLength = 50;
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(221, 23);
            this.txtVenue.TabIndex = 74;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCapacity.Location = new System.Drawing.Point(170, 211);
            this.txtCapacity.MaxLength = 4;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(74, 23);
            this.txtCapacity.TabIndex = 73;
            this.txtCapacity.TextChanged += new System.EventHandler(this.txtCapacity_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(28, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 17);
            this.label16.TabIndex = 72;
            this.label16.Text = "Capacity";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "A-Active",
            "C-Cancelled",
            "P-Padding"});
            this.cmbStatus.Location = new System.Drawing.Point(168, 465);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(136, 24);
            this.cmbStatus.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(29, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "Status";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.Location = new System.Drawing.Point(170, 146);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(235, 55);
            this.txtDescription.TabIndex = 69;
            this.txtDescription.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(28, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 66;
            this.label9.Text = "Performer";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.Location = new System.Drawing.Point(168, 436);
            this.txtPrice.MaxLength = 4;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(75, 23);
            this.txtPrice.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(248, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "€";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDuration.Location = new System.Drawing.Point(170, 348);
            this.txtDuration.MaxLength = 2;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(74, 23);
            this.txtDuration.TabIndex = 61;
            // 
            // txtEventId
            // 
            this.txtEventId.Enabled = false;
            this.txtEventId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEventId.Location = new System.Drawing.Point(170, 23);
            this.txtEventId.MaxLength = 50;
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(221, 23);
            this.txtEventId.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(28, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Duration";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(28, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Event ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(28, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 58;
            this.label15.Text = "Venue";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStartTime.Location = new System.Drawing.Point(170, 375);
            this.txtStartTime.MaxLength = 5;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(74, 23);
            this.txtStartTime.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(28, 381);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Start Time";
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDate.Location = new System.Drawing.Point(170, 317);
            this.dtpDate.MinDate = new System.DateTime(2020, 1, 9, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(221, 23);
            this.dtpDate.TabIndex = 30;
            this.dtpDate.Value = new System.DateTime(2025, 4, 19, 0, 0, 0, 0);
            // 
            // cmbEventType
            // 
            this.cmbEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(170, 81);
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(134, 24);
            this.cmbEventType.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(28, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ticket Price";
            // 
            // txtNumbOfTickets
            // 
            this.txtNumbOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumbOfTickets.Location = new System.Drawing.Point(170, 404);
            this.txtNumbOfTickets.MaxLength = 4;
            this.txtNumbOfTickets.Name = "txtNumbOfTickets";
            this.txtNumbOfTickets.Size = new System.Drawing.Size(74, 23);
            this.txtNumbOfTickets.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(28, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Number of Tickets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(28, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(28, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(28, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Event Type";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEventName.Location = new System.Drawing.Point(170, 52);
            this.txtEventName.MaxLength = 50;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(221, 23);
            this.txtEventName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(28, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Event Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(740, 665);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 34);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.Location = new System.Drawing.Point(525, 665);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 34);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grvEvents
            // 
            this.grvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEvents.Location = new System.Drawing.Point(46, 144);
            this.grvEvents.Name = "grvEvents";
            this.grvEvents.RowHeadersWidth = 51;
            this.grvEvents.Size = new System.Drawing.Size(360, 493);
            this.grvEvents.TabIndex = 38;
            this.grvEvents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEvents_CellClick);
            this.grvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEvents_CellClick);
            this.grvEvents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEvents_CellClick);
            // 
            // grpClients
            // 
            this.grpClients.Controls.Add(this.dgvClients);
            this.grpClients.Location = new System.Drawing.Point(883, 144);
            this.grpClients.Margin = new System.Windows.Forms.Padding(2);
            this.grpClients.Name = "grpClients";
            this.grpClients.Padding = new System.Windows.Forms.Padding(2);
            this.grpClients.Size = new System.Drawing.Size(441, 160);
            this.grpClients.TabIndex = 43;
            this.grpClients.TabStop = false;
            this.grpClients.Text = "Avaliable Clients";
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.GridColor = System.Drawing.Color.Thistle;
            this.dgvClients.Location = new System.Drawing.Point(20, 27);
            this.dgvClients.Name = "dgvClients";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.Size = new System.Drawing.Size(402, 116);
            this.dgvClients.TabIndex = 39;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            this.dgvClients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // grpVenues
            // 
            this.grpVenues.Controls.Add(this.dgvVenues);
            this.grpVenues.Location = new System.Drawing.Point(883, 308);
            this.grpVenues.Margin = new System.Windows.Forms.Padding(2);
            this.grpVenues.Name = "grpVenues";
            this.grpVenues.Padding = new System.Windows.Forms.Padding(2);
            this.grpVenues.Size = new System.Drawing.Size(441, 160);
            this.grpVenues.TabIndex = 44;
            this.grpVenues.TabStop = false;
            this.grpVenues.Text = "Avaliable Venues";
            // 
            // dgvVenues
            // 
            this.dgvVenues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenues.Location = new System.Drawing.Point(20, 18);
            this.dgvVenues.Name = "dgvVenues";
            this.dgvVenues.RowHeadersWidth = 51;
            this.dgvVenues.Size = new System.Drawing.Size(402, 116);
            this.dgvVenues.TabIndex = 38;
            this.dgvVenues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenues_CellContentClick);
            this.dgvVenues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenues_CellContentClick);
            this.dgvVenues.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenues_CellContentClick);
            // 
            // grpPerformers
            // 
            this.grpPerformers.Controls.Add(this.dgvPerformers);
            this.grpPerformers.Location = new System.Drawing.Point(883, 477);
            this.grpPerformers.Margin = new System.Windows.Forms.Padding(2);
            this.grpPerformers.Name = "grpPerformers";
            this.grpPerformers.Padding = new System.Windows.Forms.Padding(2);
            this.grpPerformers.Size = new System.Drawing.Size(441, 160);
            this.grpPerformers.TabIndex = 45;
            this.grpPerformers.TabStop = false;
            this.grpPerformers.Text = "Avaliable Performers";
            // 
            // dgvPerformers
            // 
            this.dgvPerformers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerformers.Location = new System.Drawing.Point(20, 18);
            this.dgvPerformers.Name = "dgvPerformers";
            this.dgvPerformers.RowHeadersWidth = 51;
            this.dgvPerformers.Size = new System.Drawing.Size(402, 116);
            this.dgvPerformers.TabIndex = 38;
            this.dgvPerformers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformers_CellContentClick);
            this.dgvPerformers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformers_CellContentClick);
            this.dgvPerformers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformers_CellContentClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(250, 214);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 17);
            this.label18.TabIndex = 78;
            this.label18.Text = "Tickets Sold:";
            // 
            // lblNumberOfSoldTickets
            // 
            this.lblNumberOfSoldTickets.AutoSize = true;
            this.lblNumberOfSoldTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumberOfSoldTickets.Location = new System.Drawing.Point(342, 214);
            this.lblNumberOfSoldTickets.Name = "lblNumberOfSoldTickets";
            this.lblNumberOfSoldTickets.Size = new System.Drawing.Size(89, 17);
            this.lblNumberOfSoldTickets.TabIndex = 79;
            this.lblNumberOfSoldTickets.Text = "Tickets Sold:";
            // 
            // frmUpdateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1347, 711);
            this.Controls.Add(this.grpPerformers);
            this.Controls.Add(this.grpVenues);
            this.Controls.Add(this.grpClients);
            this.Controls.Add(this.grvEvents);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grbEventInformation);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmUpdateEvent";
            this.Text = "frmUpdateEvent";
            this.Load += new System.EventHandler(this.frmUpdateEvent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbEventInformation.ResumeLayout(false);
            this.grbEventInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEvents)).EndInit();
            this.grpClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.grpVenues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenues)).EndInit();
            this.grpPerformers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbEventInformation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumbOfTickets;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEventType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grvEvents;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox grpClients;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.GroupBox grpVenues;
        private System.Windows.Forms.DataGridView dgvVenues;
        private System.Windows.Forms.GroupBox grpPerformers;
        private System.Windows.Forms.DataGridView dgvPerformers;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPerformer;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblNumberOfSoldTickets;
    }
}