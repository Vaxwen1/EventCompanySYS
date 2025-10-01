namespace EventCompanySYS
{
    partial class frmMainMenu
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
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showYearlyEventTypeAnalyseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(201, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brain Storm Event Company";
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            this.yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.yearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // showYearlyEventTypeAnalyseToolStripMenuItem
            // 
            this.showYearlyEventTypeAnalyseToolStripMenuItem.Name = "showYearlyEventTypeAnalyseToolStripMenuItem";
            this.showYearlyEventTypeAnalyseToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.showYearlyEventTypeAnalyseToolStripMenuItem.Text = "Yearly Event Type Analyse";
            this.showYearlyEventTypeAnalyseToolStripMenuItem.Click += new System.EventHandler(this.showYearlyEventTypeAnalyseToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showYearlyEventTypeAnalyseToolStripMenuItem,
            this.yearlyRevenueAnalysisToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cancelBookingToolStripMenuItem.Text = "Delete Booking";
            this.cancelBookingToolStripMenuItem.Click += new System.EventHandler(this.cancelBookingToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.changeToolStripMenuItem.Text = "Change Booking";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // bookTicketToolStripMenuItem
            // 
            this.bookTicketToolStripMenuItem.Name = "bookTicketToolStripMenuItem";
            this.bookTicketToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.bookTicketToolStripMenuItem.Text = "Book Ticket";
            this.bookTicketToolStripMenuItem.Click += new System.EventHandler(this.bookTicketToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookTicketToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.cancelBookingToolStripMenuItem,
            this.listOfBookingsToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // listOfBookingsToolStripMenuItem
            // 
            this.listOfBookingsToolStripMenuItem.Name = "listOfBookingsToolStripMenuItem";
            this.listOfBookingsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listOfBookingsToolStripMenuItem.Text = "List Of Bookings";
            this.listOfBookingsToolStripMenuItem.Click += new System.EventHandler(this.listOfBookingsToolStripMenuItem_Click);
            // 
            // updateEventToolStripMenuItem
            // 
            this.updateEventToolStripMenuItem.Name = "updateEventToolStripMenuItem";
            this.updateEventToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.updateEventToolStripMenuItem.Text = "UpdateEvent";
            this.updateEventToolStripMenuItem.Click += new System.EventHandler(this.updateEventToolStripMenuItem_Click);
            // 
            // createEventToolStripMenuItem
            // 
            this.createEventToolStripMenuItem.Name = "createEventToolStripMenuItem";
            this.createEventToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.createEventToolStripMenuItem.Text = "Create Event";
            this.createEventToolStripMenuItem.Click += new System.EventHandler(this.createEventToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEventToolStripMenuItem,
            this.updateEventToolStripMenuItem,
            this.cancelEventToolStripMenuItem,
            this.listOfEventsToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // cancelEventToolStripMenuItem
            // 
            this.cancelEventToolStripMenuItem.Name = "cancelEventToolStripMenuItem";
            this.cancelEventToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cancelEventToolStripMenuItem.Text = "Delete Event";
            this.cancelEventToolStripMenuItem.Click += new System.EventHandler(this.cancelEventToolStripMenuItem_Click);
            // 
            // listOfEventsToolStripMenuItem
            // 
            this.listOfEventsToolStripMenuItem.Name = "listOfEventsToolStripMenuItem";
            this.listOfEventsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.listOfEventsToolStripMenuItem.Text = "List Of Events";
            this.listOfEventsToolStripMenuItem.Click += new System.EventHandler(this.listOfEventsToolStripMenuItem_Click);
            // 
            // removeClientToolStripMenuItem
            // 
            this.removeClientToolStripMenuItem.Name = "removeClientToolStripMenuItem";
            this.removeClientToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.removeClientToolStripMenuItem.Text = "Remove Client";
            this.removeClientToolStripMenuItem.Click += new System.EventHandler(this.removeClientToolStripMenuItem_Click);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // registerClientToolStripMenuItem
            // 
            this.registerClientToolStripMenuItem.Name = "registerClientToolStripMenuItem";
            this.registerClientToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.registerClientToolStripMenuItem.Text = "Add Client";
            this.registerClientToolStripMenuItem.Click += new System.EventHandler(this.registerClientToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerClientToolStripMenuItem,
            this.updateClientToolStripMenuItem,
            this.removeClientToolStripMenuItem,
            this.listOfClientsToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientToolStripMenuItem.Text = "Clients";
            // 
            // listOfClientsToolStripMenuItem
            // 
            this.listOfClientsToolStripMenuItem.Name = "listOfClientsToolStripMenuItem";
            this.listOfClientsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.listOfClientsToolStripMenuItem.Text = "List Of Clients";
            this.listOfClientsToolStripMenuItem.Click += new System.EventHandler(this.listOfClientsToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(728, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainMenu";
            this.Text = "frmMainMenucs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showYearlyEventTypeAnalyseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listOfClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfBookingsToolStripMenuItem;
    }
}