namespace EventCompanySYS
{
    partial class frmBookTicket
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
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lsEvents = new System.Windows.Forms.ListBox();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.grpEventInform = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.lblAvailableTickets = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFilterDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblPerformer = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpEventInform.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(308, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Booking";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFind.Location = new System.Drawing.Point(533, 87);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(44, 24);
            this.btnFind.TabIndex = 30;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(155, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(231, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(296, 26);
            this.txtSearch.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(18, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Number of Tickets";
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumberOfTickets.Location = new System.Drawing.Point(201, 73);
            this.txtNumberOfTickets.MaxLength = 2;
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(87, 26);
            this.txtNumberOfTickets.TabIndex = 32;
            this.txtNumberOfTickets.TextChanged += new System.EventHandler(this.txtNumberOfTickets_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(345, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Total Price:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(81, 28);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 26);
            this.txtEmail.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Email";
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBook.Location = new System.Drawing.Point(420, 638);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(141, 34);
            this.btnBook.TabIndex = 38;
            this.btnBook.TabStop = false;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btmBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Location = new System.Drawing.Point(235, 638);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 34);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(447, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "€";
            // 
            // lsEvents
            // 
            this.lsEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lsEvents.FormattingEnabled = true;
            this.lsEvents.ItemHeight = 24;
            this.lsEvents.Location = new System.Drawing.Point(90, 189);
            this.lsEvents.Name = "lsEvents";
            this.lsEvents.Size = new System.Drawing.Size(284, 316);
            this.lsEvents.TabIndex = 40;
            this.lsEvents.SelectedIndexChanged += new System.EventHandler(this.lsEvents_SelectedIndexChanged);
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.lblPrice);
            this.grpBook.Controls.Add(this.label5);
            this.grpBook.Controls.Add(this.txtEmail);
            this.grpBook.Controls.Add(this.label4);
            this.grpBook.Controls.Add(this.label3);
            this.grpBook.Controls.Add(this.txtNumberOfTickets);
            this.grpBook.Controls.Add(this.label2);
            this.grpBook.Location = new System.Drawing.Point(90, 517);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(623, 115);
            this.grpBook.TabIndex = 41;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Booking";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPrice.Location = new System.Drawing.Point(472, 74);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 24);
            this.lblPrice.TabIndex = 40;
            this.lblPrice.Text = "0.00";
            // 
            // grpEventInform
            // 
            this.grpEventInform.Controls.Add(this.lblPerformer);
            this.grpEventInform.Controls.Add(this.label17);
            this.grpEventInform.Controls.Add(this.label21);
            this.grpEventInform.Controls.Add(this.lblTicketPrice);
            this.grpEventInform.Controls.Add(this.lblAvailableTickets);
            this.grpEventInform.Controls.Add(this.lblStartTime);
            this.grpEventInform.Controls.Add(this.lblDuration);
            this.grpEventInform.Controls.Add(this.lblDate);
            this.grpEventInform.Controls.Add(this.lblVenue);
            this.grpEventInform.Controls.Add(this.lblDescription);
            this.grpEventInform.Controls.Add(this.lblType);
            this.grpEventInform.Controls.Add(this.lblName);
            this.grpEventInform.Controls.Add(this.label15);
            this.grpEventInform.Controls.Add(this.label14);
            this.grpEventInform.Controls.Add(this.label13);
            this.grpEventInform.Controls.Add(this.label12);
            this.grpEventInform.Controls.Add(this.label11);
            this.grpEventInform.Controls.Add(this.label10);
            this.grpEventInform.Controls.Add(this.label9);
            this.grpEventInform.Controls.Add(this.label8);
            this.grpEventInform.Controls.Add(this.label7);
            this.grpEventInform.Location = new System.Drawing.Point(407, 189);
            this.grpEventInform.Margin = new System.Windows.Forms.Padding(2);
            this.grpEventInform.Name = "grpEventInform";
            this.grpEventInform.Padding = new System.Windows.Forms.Padding(2);
            this.grpEventInform.Size = new System.Drawing.Size(351, 323);
            this.grpEventInform.TabIndex = 42;
            this.grpEventInform.TabStop = false;
            this.grpEventInform.Text = "Event Information";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(141, 291);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(16, 17);
            this.label21.TabIndex = 63;
            this.label21.Text = "€";
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTicketPrice.Location = new System.Drawing.Point(153, 291);
            this.lblTicketPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(44, 17);
            this.lblTicketPrice.TabIndex = 17;
            this.lblTicketPrice.Text = "15.00";
            // 
            // lblAvailableTickets
            // 
            this.lblAvailableTickets.AutoSize = true;
            this.lblAvailableTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAvailableTickets.Location = new System.Drawing.Point(134, 267);
            this.lblAvailableTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableTickets.Name = "lblAvailableTickets";
            this.lblAvailableTickets.Size = new System.Drawing.Size(24, 17);
            this.lblAvailableTickets.TabIndex = 16;
            this.lblAvailableTickets.Text = "20";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStartTime.Location = new System.Drawing.Point(134, 241);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(44, 17);
            this.lblStartTime.TabIndex = 15;
            this.lblStartTime.Text = "12:30";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDuration.Location = new System.Drawing.Point(134, 216);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(16, 17);
            this.lblDuration.TabIndex = 14;
            this.lblDuration.Text = "3";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(134, 192);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 17);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "19/04/2025";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVenue.Location = new System.Drawing.Point(134, 140);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(151, 17);
            this.lblVenue.TabIndex = 12;
            this.lblVenue.Text = "Killarney National Park";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescription.Location = new System.Drawing.Point(133, 76);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(214, 64);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Have fun spending time\r\non yoga with little pugs";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.Location = new System.Drawing.Point(133, 53);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(91, 17);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Charity event";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.Location = new System.Drawing.Point(133, 31);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Lazy Yoga";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(25, 291);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Ticket price";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(25, 267);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Avaliable tickets";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(25, 241);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Start time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(25, 216);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Duration";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(25, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(25, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Venue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(24, 76);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(24, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(24, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name";
            // 
            // dtpFilterDate
            // 
            this.dtpFilterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFilterDate.Location = new System.Drawing.Point(235, 132);
            this.dtpFilterDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFilterDate.MinDate = new System.DateTime(2024, 12, 8, 0, 0, 0, 0);
            this.dtpFilterDate.Name = "dtpFilterDate";
            this.dtpFilterDate.Size = new System.Drawing.Size(253, 23);
            this.dtpFilterDate.TabIndex = 43;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFilter.Location = new System.Drawing.Point(492, 129);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(62, 26);
            this.btnFilter.TabIndex = 44;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblPerformer
            // 
            this.lblPerformer.AutoSize = true;
            this.lblPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPerformer.Location = new System.Drawing.Point(134, 166);
            this.lblPerformer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(151, 17);
            this.lblPerformer.TabIndex = 65;
            this.lblPerformer.Text = "Killarney National Park";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(25, 166);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 17);
            this.label17.TabIndex = 64;
            this.label17.Text = "Performer";
            // 
            // frmBookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtpFilterDate);
            this.Controls.Add(this.grpEventInform);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.lsEvents);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmBookTicket";
            this.Text = "frmBookTicket";
            this.Load += new System.EventHandler(this.frmBookTicket_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpEventInform.ResumeLayout(false);
            this.grpEventInform.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lsEvents;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.GroupBox grpEventInform;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTicketPrice;
        private System.Windows.Forms.Label lblAvailableTickets;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblPerformer;
        private System.Windows.Forms.Label label17;
    }
}