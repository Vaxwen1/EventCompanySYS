using System.Windows.Forms;

namespace EventCompanySYS
{
    partial class frmAddEvent
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.grbCreateEvent = new System.Windows.Forms.GroupBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPerformer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNumbOfTickets = new System.Windows.Forms.TextBox();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.lblNumberOfTicket = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.cmbEventType = new System.Windows.Forms.ComboBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVenues = new System.Windows.Forms.DataGridView();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpClients = new System.Windows.Forms.GroupBox();
            this.grpVenues = new System.Windows.Forms.GroupBox();
            this.grpPerformers = new System.Windows.Forms.GroupBox();
            this.dgvPerformers = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grbCreateEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.grpClients.SuspendLayout();
            this.grpVenues.SuspendLayout();
            this.grpPerformers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1089, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(462, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Event";
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Create.Location = new System.Drawing.Point(580, 791);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(199, 34);
            this.btn_Create.TabIndex = 23;
            this.btn_Create.TabStop = false;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // grbCreateEvent
            // 
            this.grbCreateEvent.Controls.Add(this.txtCapacity);
            this.grbCreateEvent.Controls.Add(this.label5);
            this.grbCreateEvent.Controls.Add(this.txtPerformer);
            this.grbCreateEvent.Controls.Add(this.label9);
            this.grbCreateEvent.Controls.Add(this.txtClient);
            this.grbCreateEvent.Controls.Add(this.label8);
            this.grbCreateEvent.Controls.Add(this.txtDescription);
            this.grbCreateEvent.Controls.Add(this.txtVenue);
            this.grbCreateEvent.Controls.Add(this.txtTicketPrice);
            this.grbCreateEvent.Controls.Add(this.lblEuro);
            this.grbCreateEvent.Controls.Add(this.txtDuration);
            this.grbCreateEvent.Controls.Add(this.dtpDate);
            this.grbCreateEvent.Controls.Add(this.txtNumbOfTickets);
            this.grbCreateEvent.Controls.Add(this.lblTicketPrice);
            this.grbCreateEvent.Controls.Add(this.lblNumberOfTicket);
            this.grbCreateEvent.Controls.Add(this.lblDuration);
            this.grbCreateEvent.Controls.Add(this.txtStartTime);
            this.grbCreateEvent.Controls.Add(this.lblStartTime);
            this.grbCreateEvent.Controls.Add(this.cmbEventType);
            this.grbCreateEvent.Controls.Add(this.txtEventName);
            this.grbCreateEvent.Controls.Add(this.label6);
            this.grbCreateEvent.Controls.Add(this.lblVenue);
            this.grbCreateEvent.Controls.Add(this.label4);
            this.grbCreateEvent.Controls.Add(this.label3);
            this.grbCreateEvent.Controls.Add(this.label2);
            this.grbCreateEvent.Location = new System.Drawing.Point(57, 89);
            this.grbCreateEvent.Name = "grbCreateEvent";
            this.grbCreateEvent.Size = new System.Drawing.Size(516, 685);
            this.grbCreateEvent.TabIndex = 37;
            this.grbCreateEvent.TabStop = false;
            this.grbCreateEvent.Text = "Create Event";
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCapacity.Location = new System.Drawing.Point(253, 319);
            this.txtCapacity.MaxLength = 500;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(162, 29);
            this.txtCapacity.TabIndex = 74;
            this.txtCapacity.TextChanged += new System.EventHandler(this.txtCapacity_TextChanged);
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbers_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(79, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 73;
            this.label5.Text = "Capacity";
            // 
            // txtPerformer
            // 
            this.txtPerformer.BackColor = System.Drawing.SystemColors.Control;
            this.txtPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPerformer.Location = new System.Drawing.Point(253, 457);
            this.txtPerformer.MaxLength = 500;
            this.txtPerformer.Name = "txtPerformer";
            this.txtPerformer.ReadOnly = true;
            this.txtPerformer.Size = new System.Drawing.Size(235, 29);
            this.txtPerformer.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(79, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 71;
            this.label9.Text = "Performer";
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.SystemColors.Control;
            this.txtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtClient.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtClient.Location = new System.Drawing.Point(253, 123);
            this.txtClient.MaxLength = 500;
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(235, 29);
            this.txtClient.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(79, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 69;
            this.label8.Text = "Client";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.Location = new System.Drawing.Point(253, 181);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(235, 119);
            this.txtDescription.TabIndex = 68;
            this.txtDescription.Text = "";
            // 
            // txtVenue
            // 
            this.txtVenue.BackColor = System.Drawing.SystemColors.Control;
            this.txtVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtVenue.Location = new System.Drawing.Point(253, 409);
            this.txtVenue.MaxLength = 500;
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.ReadOnly = true;
            this.txtVenue.Size = new System.Drawing.Size(235, 29);
            this.txtVenue.TabIndex = 67;
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTicketPrice.Location = new System.Drawing.Point(253, 630);
            this.txtTicketPrice.MaxLength = 6;
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(70, 29);
            this.txtTicketPrice.TabIndex = 64;
            this.txtTicketPrice.Text = "0.0";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEuro.Location = new System.Drawing.Point(328, 630);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(20, 24);
            this.lblEuro.TabIndex = 63;
            this.lblEuro.Text = "€";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDuration.Location = new System.Drawing.Point(253, 500);
            this.txtDuration.MaxLength = 2;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(78, 29);
            this.txtDuration.TabIndex = 57;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDate.Location = new System.Drawing.Point(253, 366);
            this.dtpDate.MinDate = new System.DateTime(2025, 8, 14, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(235, 23);
            this.dtpDate.TabIndex = 54;
            this.dtpDate.Value = new System.DateTime(2025, 8, 14, 0, 0, 0, 0);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // txtNumbOfTickets
            // 
            this.txtNumbOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNumbOfTickets.Location = new System.Drawing.Point(253, 589);
            this.txtNumbOfTickets.MaxLength = 4;
            this.txtNumbOfTickets.Name = "txtNumbOfTickets";
            this.txtNumbOfTickets.Size = new System.Drawing.Size(78, 29);
            this.txtNumbOfTickets.TabIndex = 52;
            this.txtNumbOfTickets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumbers_KeyPress);
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTicketPrice.Location = new System.Drawing.Point(79, 633);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(108, 24);
            this.lblTicketPrice.TabIndex = 50;
            this.lblTicketPrice.Text = "Ticket Price";
            // 
            // lblNumberOfTicket
            // 
            this.lblNumberOfTicket.AutoSize = true;
            this.lblNumberOfTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNumberOfTicket.Location = new System.Drawing.Point(79, 591);
            this.lblNumberOfTicket.Name = "lblNumberOfTicket";
            this.lblNumberOfTicket.Size = new System.Drawing.Size(167, 24);
            this.lblNumberOfTicket.TabIndex = 49;
            this.lblNumberOfTicket.Text = "Number Of Tickets";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDuration.Location = new System.Drawing.Point(79, 502);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(165, 24);
            this.lblDuration.TabIndex = 45;
            this.lblDuration.Text = "Duration (in hours)";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtStartTime.Location = new System.Drawing.Point(253, 548);
            this.txtStartTime.MaxLength = 5;
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(78, 29);
            this.txtStartTime.TabIndex = 47;
            this.txtStartTime.Text = "13:00";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStartTime.Location = new System.Drawing.Point(79, 551);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(94, 24);
            this.lblStartTime.TabIndex = 46;
            this.lblStartTime.Text = "Start Time";
            // 
            // cmbEventType
            // 
            this.cmbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbEventType.FormattingEnabled = true;
            this.cmbEventType.Location = new System.Drawing.Point(253, 70);
            this.cmbEventType.MaxLength = 15;
            this.cmbEventType.Name = "cmbEventType";
            this.cmbEventType.Size = new System.Drawing.Size(235, 32);
            this.cmbEventType.TabIndex = 44;
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEventName.Location = new System.Drawing.Point(253, 27);
            this.txtEventName.MaxLength = 50;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(235, 29);
            this.txtEventName.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(79, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Date";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblVenue.Location = new System.Drawing.Point(79, 412);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(67, 24);
            this.lblVenue.TabIndex = 40;
            this.lblVenue.Text = "Venue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(79, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(79, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Event type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(79, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Event name";
            // 
            // dgvVenues
            // 
            this.dgvVenues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenues.Location = new System.Drawing.Point(20, 18);
            this.dgvVenues.Name = "dgvVenues";
            this.dgvVenues.RowHeadersWidth = 51;
            this.dgvVenues.Size = new System.Drawing.Size(435, 186);
            this.dgvVenues.TabIndex = 38;
            this.dgvVenues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenues_CellContentClick);
            this.dgvVenues.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenues_CellContentClick);
            this.dgvVenues.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenues_CellContentClick);
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.GridColor = System.Drawing.Color.Thistle;
            this.dgvClients.Location = new System.Drawing.Point(20, 27);
            this.dgvClients.Name = "dgvClients";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.Size = new System.Drawing.Size(435, 181);
            this.dgvClients.TabIndex = 39;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            this.dgvClients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            // 
            // grpClients
            // 
            this.grpClients.Controls.Add(this.dgvClients);
            this.grpClients.Location = new System.Drawing.Point(580, 89);
            this.grpClients.Margin = new System.Windows.Forms.Padding(2);
            this.grpClients.Name = "grpClients";
            this.grpClients.Padding = new System.Windows.Forms.Padding(2);
            this.grpClients.Size = new System.Drawing.Size(472, 225);
            this.grpClients.TabIndex = 42;
            this.grpClients.TabStop = false;
            this.grpClients.Text = "Avaliable Clients";
            // 
            // grpVenues
            // 
            this.grpVenues.Controls.Add(this.dgvVenues);
            this.grpVenues.Location = new System.Drawing.Point(580, 319);
            this.grpVenues.Margin = new System.Windows.Forms.Padding(2);
            this.grpVenues.Name = "grpVenues";
            this.grpVenues.Padding = new System.Windows.Forms.Padding(2);
            this.grpVenues.Size = new System.Drawing.Size(472, 225);
            this.grpVenues.TabIndex = 43;
            this.grpVenues.TabStop = false;
            this.grpVenues.Text = "Avaliable Venues";
            // 
            // grpPerformers
            // 
            this.grpPerformers.Controls.Add(this.dgvPerformers);
            this.grpPerformers.Location = new System.Drawing.Point(580, 549);
            this.grpPerformers.Margin = new System.Windows.Forms.Padding(2);
            this.grpPerformers.Name = "grpPerformers";
            this.grpPerformers.Padding = new System.Windows.Forms.Padding(2);
            this.grpPerformers.Size = new System.Drawing.Size(472, 225);
            this.grpPerformers.TabIndex = 44;
            this.grpPerformers.TabStop = false;
            this.grpPerformers.Text = "Avaliable Performers";
            // 
            // dgvPerformers
            // 
            this.dgvPerformers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerformers.Location = new System.Drawing.Point(20, 18);
            this.dgvPerformers.Name = "dgvPerformers";
            this.dgvPerformers.RowHeadersWidth = 51;
            this.dgvPerformers.Size = new System.Drawing.Size(435, 195);
            this.dgvPerformers.TabIndex = 38;
            this.dgvPerformers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformers_CellContentClick);
            this.dgvPerformers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformers_CellContentClick);
            this.dgvPerformers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPerformers_CellContentClick);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.Location = new System.Drawing.Point(375, 791);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(199, 34);
            this.btnReset.TabIndex = 45;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1089, 839);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpPerformers);
            this.Controls.Add(this.grpVenues);
            this.Controls.Add(this.grpClients);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grbCreateEvent);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddEvent";
            this.Text = "frm_CreateEvent";
            this.Load += new System.EventHandler(this.frmAddEvent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbCreateEvent.ResumeLayout(false);
            this.grbCreateEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.grpClients.ResumeLayout(false);
            this.grpVenues.ResumeLayout(false);
            this.grpPerformers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerformers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Create;
        private GroupBox grbCreateEvent;
        private DateTimePicker dtpDate;
        private TextBox txtNumbOfTickets;
        private Label lblTicketPrice;
        private Label lblNumberOfTicket;
        private TextBox txtStartTime;
        private Label lblStartTime;
        private Label lblDuration;
        private ComboBox cmbEventType;
        private TextBox txtEventName;
        private Label label6;
        private Label lblVenue;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDuration;
        private Label lblEuro;
        private TextBox txtTicketPrice;
        private TextBox txtVenue;
        private RichTextBox txtDescription;
        private DataGridView dgvVenues;
        private DataGridView dgvClients;
        private TextBox txtClient;
        private Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpClients;
        private GroupBox grpVenues;
        private TextBox txtPerformer;
        private Label label9;
        private GroupBox grpPerformers;
        private DataGridView dgvPerformers;
        private TextBox txtCapacity;
        private Label label5;
        private Button btnReset;
    }
}