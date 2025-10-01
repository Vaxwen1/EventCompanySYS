namespace EventCompanySYS.ManageEvent
{
    partial class frmDeleteEvent
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
            this.btn_Find = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grbCancelEvent = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtPerformer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtEventId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumbOfTickets = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grvEvents = new System.Windows.Forms.DataGridView();
            this.grbCancelEvent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(365, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Delete Event";
            // 
            // btn_Find
            // 
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Find.Location = new System.Drawing.Point(650, 98);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(44, 24);
            this.btn_Find.TabIndex = 30;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(152, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(233, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(391, 26);
            this.txtSearch.TabIndex = 28;
            // 
            // grbCancelEvent
            // 
            this.grbCancelEvent.Controls.Add(this.txtDescription);
            this.grbCancelEvent.Controls.Add(this.txtVenue);
            this.grbCancelEvent.Controls.Add(this.txtPerformer);
            this.grbCancelEvent.Controls.Add(this.label16);
            this.grbCancelEvent.Controls.Add(this.txtStatus);
            this.grbCancelEvent.Controls.Add(this.label9);
            this.grbCancelEvent.Controls.Add(this.label8);
            this.grbCancelEvent.Controls.Add(this.label6);
            this.grbCancelEvent.Controls.Add(this.txtDuration);
            this.grbCancelEvent.Controls.Add(this.txtEventId);
            this.grbCancelEvent.Controls.Add(this.label14);
            this.grbCancelEvent.Controls.Add(this.label13);
            this.grbCancelEvent.Controls.Add(this.label15);
            this.grbCancelEvent.Controls.Add(this.txtStartTime);
            this.grbCancelEvent.Controls.Add(this.label12);
            this.grbCancelEvent.Controls.Add(this.dtpDate);
            this.grbCancelEvent.Controls.Add(this.cmbType);
            this.grbCancelEvent.Controls.Add(this.txtTicketPrice);
            this.grbCancelEvent.Controls.Add(this.label11);
            this.grbCancelEvent.Controls.Add(this.txtNumbOfTickets);
            this.grbCancelEvent.Controls.Add(this.label10);
            this.grbCancelEvent.Controls.Add(this.label7);
            this.grbCancelEvent.Controls.Add(this.label5);
            this.grbCancelEvent.Controls.Add(this.label4);
            this.grbCancelEvent.Controls.Add(this.txtEventName);
            this.grbCancelEvent.Controls.Add(this.label3);
            this.grbCancelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbCancelEvent.Location = new System.Drawing.Point(434, 150);
            this.grbCancelEvent.Name = "grbCancelEvent";
            this.grbCancelEvent.Size = new System.Drawing.Size(442, 482);
            this.grbCancelEvent.TabIndex = 34;
            this.grbCancelEvent.TabStop = false;
            this.grbCancelEvent.Text = "Cancel Event";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Location = new System.Drawing.Point(198, 136);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(221, 82);
            this.txtDescription.TabIndex = 69;
            this.txtDescription.Text = "";
            // 
            // txtVenue
            // 
            this.txtVenue.Enabled = false;
            this.txtVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVenue.Location = new System.Drawing.Point(198, 223);
            this.txtVenue.MaxLength = 50;
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(221, 23);
            this.txtVenue.TabIndex = 68;
            // 
            // txtPerformer
            // 
            this.txtPerformer.Enabled = false;
            this.txtPerformer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPerformer.Location = new System.Drawing.Point(198, 287);
            this.txtPerformer.MaxLength = 50;
            this.txtPerformer.Name = "txtPerformer";
            this.txtPerformer.Size = new System.Drawing.Size(221, 23);
            this.txtPerformer.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(57, 289);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 17);
            this.label16.TabIndex = 66;
            this.label16.Text = "Performer";
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStatus.Location = new System.Drawing.Point(198, 441);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(52, 23);
            this.txtStatus.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(56, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(255, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 63;
            this.label8.Text = "Hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(257, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "€";
            // 
            // txtDuration
            // 
            this.txtDuration.Enabled = false;
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDuration.Location = new System.Drawing.Point(198, 324);
            this.txtDuration.MaxLength = 2;
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(52, 23);
            this.txtDuration.TabIndex = 61;
            // 
            // txtEventId
            // 
            this.txtEventId.Enabled = false;
            this.txtEventId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEventId.Location = new System.Drawing.Point(198, 45);
            this.txtEventId.MaxLength = 50;
            this.txtEventId.Name = "txtEventId";
            this.txtEventId.Size = new System.Drawing.Size(221, 23);
            this.txtEventId.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(56, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Duration";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(56, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Event ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(56, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 58;
            this.label15.Text = "Venue";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Enabled = false;
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStartTime.Location = new System.Drawing.Point(198, 351);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(52, 23);
            this.txtStartTime.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(56, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Start Time";
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.Enabled = false;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDate.Location = new System.Drawing.Point(198, 254);
            this.dtpDate.MinDate = new System.DateTime(1995, 7, 13, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(221, 23);
            this.dtpDate.TabIndex = 30;
            this.dtpDate.Value = new System.DateTime(2025, 4, 19, 0, 0, 0, 0);
            // 
            // cmbType
            // 
            this.cmbType.Enabled = false;
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(198, 103);
            this.cmbType.MaxLength = 2;
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(146, 24);
            this.cmbType.TabIndex = 18;
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Enabled = false;
            this.txtTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTicketPrice.Location = new System.Drawing.Point(198, 410);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(52, 23);
            this.txtTicketPrice.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(56, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ticket Price";
            // 
            // txtNumbOfTickets
            // 
            this.txtNumbOfTickets.Enabled = false;
            this.txtNumbOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumbOfTickets.Location = new System.Drawing.Point(198, 380);
            this.txtNumbOfTickets.MaxLength = 4;
            this.txtNumbOfTickets.Name = "txtNumbOfTickets";
            this.txtNumbOfTickets.Size = new System.Drawing.Size(52, 23);
            this.txtNumbOfTickets.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(56, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Number of Tickets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(56, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(56, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Event Type";
            // 
            // txtEventName
            // 
            this.txtEventName.Enabled = false;
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEventName.Location = new System.Drawing.Point(198, 74);
            this.txtEventName.MaxLength = 50;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(221, 23);
            this.txtEventName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(56, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Event Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(370, 654);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 34);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btn_Remove_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(886, 29);
            this.menuStrip1.TabIndex = 38;
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
            // grvEvents
            // 
            this.grvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEvents.Location = new System.Drawing.Point(29, 150);
            this.grvEvents.Name = "grvEvents";
            this.grvEvents.RowHeadersWidth = 51;
            this.grvEvents.Size = new System.Drawing.Size(381, 482);
            this.grvEvents.TabIndex = 39;
            this.grvEvents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEvents_CellContentClick);
            this.grvEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEvents_CellContentClick);
            this.grvEvents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvEvents_CellContentClick);
            // 
            // frmDeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(886, 699);
            this.Controls.Add(this.grvEvents);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grbCancelEvent);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmDeleteEvent";
            this.Text = "frmRemoveEvent";
            this.Load += new System.EventHandler(this.frmCancelEvent_Load);
            this.grbCancelEvent.ResumeLayout(false);
            this.grbCancelEvent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grbCancelEvent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtEventId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumbOfTickets;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtPerformer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView grvEvents;
    }
}