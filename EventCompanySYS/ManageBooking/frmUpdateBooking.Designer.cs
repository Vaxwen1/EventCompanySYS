namespace EventCompanySYS.ManageBooking
{
    partial class frmUpdateBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtBookingNumb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCurrentBooking = new System.Windows.Forms.GroupBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtBookingDate = new System.Windows.Forms.TextBox();
            this.grpEventInformation = new System.Windows.Forms.GroupBox();
            this.lblPerformer = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblPricePerTicket = new System.Windows.Forms.Label();
            this.lblAvaliableTickets = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grdBookings = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpCurrentBooking.SuspendLayout();
            this.grpEventInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(627, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Change Booking";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFind.Location = new System.Drawing.Point(992, 94);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(44, 24);
            this.btnFind.TabIndex = 48;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtBookingNumb
            // 
            this.txtBookingNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBookingNumb.Location = new System.Drawing.Point(602, 94);
            this.txtBookingNumb.MaxLength = 6;
            this.txtBookingNumb.Name = "txtBookingNumb";
            this.txtBookingNumb.Size = new System.Drawing.Size(384, 29);
            this.txtBookingNumb.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(441, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Booking Number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(224, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "€";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(14, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 55;
            this.label6.Text = "Booking date:";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPrice.Location = new System.Drawing.Point(135, 229);
            this.txtPrice.MaxLength = 6;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(83, 29);
            this.txtPrice.TabIndex = 54;
            this.txtPrice.Text = "10.00";
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtNumberOfTickets.Location = new System.Drawing.Point(184, 183);
            this.txtNumberOfTickets.MaxLength = 2;
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(87, 29);
            this.txtNumberOfTickets.TabIndex = 53;
            this.txtNumberOfTickets.Text = "2";
            // 
            // txtEventName
            // 
            this.txtEventName.Enabled = false;
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEventName.Location = new System.Drawing.Point(109, 66);
            this.txtEventName.MaxLength = 2;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(289, 29);
            this.txtEventName.TabIndex = 52;
            this.txtEventName.Text = "Lazy Yoga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(14, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Total price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(14, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Number of tickets:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Event:";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnChange.Location = new System.Drawing.Point(692, 656);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(141, 34);
            this.btnChange.TabIndex = 58;
            this.btnChange.TabStop = false;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1452, 29);
            this.menuStrip1.TabIndex = 59;
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
            // grpCurrentBooking
            // 
            this.grpCurrentBooking.Controls.Add(this.txtBookingID);
            this.grpCurrentBooking.Controls.Add(this.label12);
            this.grpCurrentBooking.Controls.Add(this.txtEmail);
            this.grpCurrentBooking.Controls.Add(this.lbl4);
            this.grpCurrentBooking.Controls.Add(this.txtBookingDate);
            this.grpCurrentBooking.Controls.Add(this.label7);
            this.grpCurrentBooking.Controls.Add(this.label6);
            this.grpCurrentBooking.Controls.Add(this.txtPrice);
            this.grpCurrentBooking.Controls.Add(this.txtNumberOfTickets);
            this.grpCurrentBooking.Controls.Add(this.txtEventName);
            this.grpCurrentBooking.Controls.Add(this.label5);
            this.grpCurrentBooking.Controls.Add(this.label4);
            this.grpCurrentBooking.Controls.Add(this.label3);
            this.grpCurrentBooking.Location = new System.Drawing.Point(508, 362);
            this.grpCurrentBooking.Name = "grpCurrentBooking";
            this.grpCurrentBooking.Size = new System.Drawing.Size(832, 274);
            this.grpCurrentBooking.TabIndex = 62;
            this.grpCurrentBooking.TabStop = false;
            this.grpCurrentBooking.Text = "Current Event";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Enabled = false;
            this.txtBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBookingID.Location = new System.Drawing.Point(109, 28);
            this.txtBookingID.MaxLength = 2;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(289, 29);
            this.txtBookingID.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(13, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 24);
            this.label12.TabIndex = 61;
            this.label12.Text = "BookinID:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEmail.Location = new System.Drawing.Point(109, 105);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 29);
            this.txtEmail.TabIndex = 60;
            this.txtEmail.Text = "igorokg@gmail.com";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl4.Location = new System.Drawing.Point(14, 105);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(62, 24);
            this.lbl4.TabIndex = 59;
            this.lbl4.Text = "Email:";
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Enabled = false;
            this.txtBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBookingDate.Location = new System.Drawing.Point(145, 148);
            this.txtBookingDate.MaxLength = 2;
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.Size = new System.Drawing.Size(230, 29);
            this.txtBookingDate.TabIndex = 58;
            this.txtBookingDate.Text = "12-Apr-23";
            // 
            // grpEventInformation
            // 
            this.grpEventInformation.Controls.Add(this.lblPerformer);
            this.grpEventInformation.Controls.Add(this.label13);
            this.grpEventInformation.Controls.Add(this.lbl2);
            this.grpEventInformation.Controls.Add(this.lblDuration);
            this.grpEventInformation.Controls.Add(this.lblDate);
            this.grpEventInformation.Controls.Add(this.label24);
            this.grpEventInformation.Controls.Add(this.lblVenue);
            this.grpEventInformation.Controls.Add(this.label22);
            this.grpEventInformation.Controls.Add(this.lblPricePerTicket);
            this.grpEventInformation.Controls.Add(this.lblAvaliableTickets);
            this.grpEventInformation.Controls.Add(this.lblTime);
            this.grpEventInformation.Controls.Add(this.label18);
            this.grpEventInformation.Controls.Add(this.label19);
            this.grpEventInformation.Controls.Add(this.label20);
            this.grpEventInformation.Controls.Add(this.lblDescription);
            this.grpEventInformation.Controls.Add(this.lblEventType);
            this.grpEventInformation.Controls.Add(this.lblEventName);
            this.grpEventInformation.Controls.Add(this.label11);
            this.grpEventInformation.Controls.Add(this.label10);
            this.grpEventInformation.Controls.Add(this.label9);
            this.grpEventInformation.Location = new System.Drawing.Point(508, 151);
            this.grpEventInformation.Margin = new System.Windows.Forms.Padding(2);
            this.grpEventInformation.Name = "grpEventInformation";
            this.grpEventInformation.Padding = new System.Windows.Forms.Padding(2);
            this.grpEventInformation.Size = new System.Drawing.Size(832, 206);
            this.grpEventInformation.TabIndex = 64;
            this.grpEventInformation.TabStop = false;
            this.grpEventInformation.Text = "Event Information";
            // 
            // lblPerformer
            // 
            this.lblPerformer.AutoSize = true;
            this.lblPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPerformer.Location = new System.Drawing.Point(655, 32);
            this.lblPerformer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerformer.Name = "lblPerformer";
            this.lblPerformer.Size = new System.Drawing.Size(146, 18);
            this.lblPerformer.TabIndex = 68;
            this.lblPerformer.Text = "Green Walk Killarney";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.Location = new System.Drawing.Point(549, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 18);
            this.label13.TabIndex = 67;
            this.label13.Text = "Performer:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl2.Location = new System.Drawing.Point(549, 115);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(64, 18);
            this.lbl2.TabIndex = 66;
            this.lbl2.Text = "Duration";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDuration.Location = new System.Drawing.Point(675, 115);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(44, 18);
            this.lblDuration.TabIndex = 65;
            this.lblDuration.Text = "12:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDate.Location = new System.Drawing.Point(675, 58);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 18);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "02/04/2024";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label24.Location = new System.Drawing.Point(549, 88);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 18);
            this.label24.TabIndex = 14;
            this.label24.Text = "Start time";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblVenue.Location = new System.Drawing.Point(124, 160);
            this.lblVenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(156, 18);
            this.lblVenue.TabIndex = 13;
            this.lblVenue.Text = "Killarney National Park";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label22.Location = new System.Drawing.Point(18, 160);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 18);
            this.label22.TabIndex = 12;
            this.label22.Text = "Venue";
            // 
            // lblPricePerTicket
            // 
            this.lblPricePerTicket.AutoSize = true;
            this.lblPricePerTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPricePerTicket.Location = new System.Drawing.Point(672, 169);
            this.lblPricePerTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPricePerTicket.Name = "lblPricePerTicket";
            this.lblPricePerTicket.Size = new System.Drawing.Size(16, 18);
            this.lblPricePerTicket.TabIndex = 11;
            this.lblPricePerTicket.Text = "5";
            // 
            // lblAvaliableTickets
            // 
            this.lblAvaliableTickets.AutoSize = true;
            this.lblAvaliableTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAvaliableTickets.Location = new System.Drawing.Point(672, 142);
            this.lblAvaliableTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvaliableTickets.Name = "lblAvaliableTickets";
            this.lblAvaliableTickets.Size = new System.Drawing.Size(24, 18);
            this.lblAvaliableTickets.TabIndex = 10;
            this.lblAvaliableTickets.Text = "10";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTime.Location = new System.Drawing.Point(675, 88);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 18);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "12:00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label18.Location = new System.Drawing.Point(549, 169);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 18);
            this.label18.TabIndex = 8;
            this.label18.Text = "Price for ticket";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label19.Location = new System.Drawing.Point(549, 142);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 18);
            this.label19.TabIndex = 7;
            this.label19.Text = "Avaliable Tikets";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label20.Location = new System.Drawing.Point(549, 58);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 18);
            this.label20.TabIndex = 6;
            this.label20.Text = "Date";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDescription.Location = new System.Drawing.Point(124, 88);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(353, 54);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Stroll through the pretty landscapes of the national park,make new friends, and y" +
    "our funds will go to the charity\r\nclean city that cares about our nature ";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEventType.Location = new System.Drawing.Point(124, 58);
            this.lblEventType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(93, 18);
            this.lblEventType.TabIndex = 4;
            this.lblEventType.Text = "Charity event";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEventName.Location = new System.Drawing.Point(124, 32);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(146, 18);
            this.lblEventName.TabIndex = 3;
            this.lblEventName.Text = "Green Walk Killarney";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(18, 88);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(18, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(18, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Event name:";
            // 
            // grdBookings
            // 
            this.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookings.Location = new System.Drawing.Point(34, 142);
            this.grdBookings.Name = "grdBookings";
            this.grdBookings.Size = new System.Drawing.Size(456, 494);
            this.grdBookings.TabIndex = 65;
            this.grdBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBookings_CellClick);
            this.grdBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBookings_CellClick);
            this.grdBookings.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBookings_CellClick);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReset.Location = new System.Drawing.Point(506, 656);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 34);
            this.btnReset.TabIndex = 66;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1452, 702);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grdBookings);
            this.Controls.Add(this.grpEventInformation);
            this.Controls.Add(this.grpCurrentBooking);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtBookingNumb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateBooking";
            this.Text = "frmChangeBooking";
            this.Load += new System.EventHandler(this.frmChangeBooking_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCurrentBooking.ResumeLayout(false);
            this.grpCurrentBooking.PerformLayout();
            this.grpEventInformation.ResumeLayout(false);
            this.grpEventInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtBookingNumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpCurrentBooking;
        private System.Windows.Forms.GroupBox grpEventInformation;
        private System.Windows.Forms.Label lblPricePerTicket;
        private System.Windows.Forms.Label lblAvaliableTickets;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBookingDate;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView grdBookings;
        private System.Windows.Forms.Label lblPerformer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnReset;
    }
}