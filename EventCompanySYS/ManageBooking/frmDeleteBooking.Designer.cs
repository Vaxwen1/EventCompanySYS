namespace EventCompanySYS.ManageBooking
{
    partial class frmDeleteBooking
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btmDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbCancelBooking = new System.Windows.Forms.GroupBox();
            this.txtBookingDate = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookingNumb = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.grdBookings = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grbCancelBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(397, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Delete Booking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Event:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Number of tickets:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Total price:";
            // 
            // txtEventName
            // 
            this.txtEventName.Enabled = false;
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEventName.Location = new System.Drawing.Point(92, 107);
            this.txtEventName.MaxLength = 50;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(276, 26);
            this.txtEventName.TabIndex = 37;
            this.txtEventName.Text = "Lazy Yoga";
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Enabled = false;
            this.txtNumberOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumberOfTickets.Location = new System.Drawing.Point(192, 178);
            this.txtNumberOfTickets.MaxLength = 2;
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(87, 26);
            this.txtNumberOfTickets.TabIndex = 38;
            this.txtNumberOfTickets.Text = "2";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrice.Location = new System.Drawing.Point(141, 223);
            this.txtPrice.MaxLength = 6;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(70, 26);
            this.txtPrice.TabIndex = 39;
            this.txtPrice.Text = "30.00";
            // 
            // btmDelete
            // 
            this.btmDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btmDelete.Location = new System.Drawing.Point(403, 460);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(141, 34);
            this.btmDelete.TabIndex = 41;
            this.btmDelete.TabStop = false;
            this.btmDelete.Text = "Delete Booking";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.UseWaitCursor = true;
            this.btmDelete.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Booking date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(217, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "€";
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
            this.menuStrip1.Size = new System.Drawing.Size(1002, 29);
            this.menuStrip1.TabIndex = 46;
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
            // grbCancelBooking
            // 
            this.grbCancelBooking.Controls.Add(this.txtBookingDate);
            this.grbCancelBooking.Controls.Add(this.txtEmail);
            this.grbCancelBooking.Controls.Add(this.label9);
            this.grbCancelBooking.Controls.Add(this.txtBookingID);
            this.grbCancelBooking.Controls.Add(this.label8);
            this.grbCancelBooking.Controls.Add(this.label7);
            this.grbCancelBooking.Controls.Add(this.label6);
            this.grbCancelBooking.Controls.Add(this.txtPrice);
            this.grbCancelBooking.Controls.Add(this.txtNumberOfTickets);
            this.grbCancelBooking.Controls.Add(this.txtEventName);
            this.grbCancelBooking.Controls.Add(this.label5);
            this.grbCancelBooking.Controls.Add(this.label4);
            this.grbCancelBooking.Controls.Add(this.label3);
            this.grbCancelBooking.Location = new System.Drawing.Point(496, 144);
            this.grbCancelBooking.Name = "grbCancelBooking";
            this.grbCancelBooking.Size = new System.Drawing.Size(414, 297);
            this.grbCancelBooking.TabIndex = 47;
            this.grbCancelBooking.TabStop = false;
            this.grbCancelBooking.Text = "Cancel Booking";
            // 
            // txtBookingDate
            // 
            this.txtBookingDate.Enabled = false;
            this.txtBookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBookingDate.Location = new System.Drawing.Point(147, 143);
            this.txtBookingDate.MaxLength = 50;
            this.txtBookingDate.Name = "txtBookingDate";
            this.txtBookingDate.Size = new System.Drawing.Size(221, 26);
            this.txtBookingDate.TabIndex = 49;
            this.txtBookingDate.Text = "Lazy Yoga";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(92, 73);
            this.txtEmail.MaxLength = 6;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 26);
            this.txtEmail.TabIndex = 48;
            this.txtEmail.Text = "123456";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Email:";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Enabled = false;
            this.txtBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBookingID.Location = new System.Drawing.Point(171, 39);
            this.txtBookingID.MaxLength = 6;
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(197, 26);
            this.txtBookingID.TabIndex = 46;
            this.txtBookingID.Text = "123456";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "Booking number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Booking Number:";
            // 
            // txtBookingNumb
            // 
            this.txtBookingNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBookingNumb.Location = new System.Drawing.Point(370, 92);
            this.txtBookingNumb.Name = "txtBookingNumb";
            this.txtBookingNumb.Size = new System.Drawing.Size(292, 26);
            this.txtBookingNumb.TabIndex = 36;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFind.Location = new System.Drawing.Point(667, 91);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(44, 24);
            this.btnFind.TabIndex = 45;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grdBookings
            // 
            this.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookings.Location = new System.Drawing.Point(42, 144);
            this.grdBookings.Name = "grdBookings";
            this.grdBookings.Size = new System.Drawing.Size(399, 297);
            this.grdBookings.TabIndex = 66;
            this.grdBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBookings_CellClick);
            // 
            // frmDeleteBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1002, 515);
            this.Controls.Add(this.grdBookings);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.grbCancelBooking);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookingNumb);
            this.Name = "frmDeleteBooking";
            this.Text = "frmCancelBooking";
            this.Load += new System.EventHandler(this.frmDeleteBooking_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbCancelBooking.ResumeLayout(false);
            this.grbCancelBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbCancelBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookingNumb;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBookingDate;
        private System.Windows.Forms.DataGridView grdBookings;
    }
}