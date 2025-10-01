using EventCompanySYS.ManageAdmin;
using EventCompanySYS.ManageBooking;
using EventCompanySYS.ManageClient;
using EventCompanySYS.ManageEvent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventCompanySYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void registerClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddClient addNewClient = new frmAddClient(this);
            addNewClient.Show();
        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateClient updateClient = new frmUpdateClient(this);
            updateClient.Show();
        }

        private void removeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveClient removeClient = new frmRemoveClient(this);
            removeClient.Show();
        }

        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddEvent addNextEvent = new frmAddEvent(this);
            addNextEvent.Show();
        }

        private void updateEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateEvent updateEvent = new frmUpdateEvent(this);
            updateEvent.Show();
        }

        private void cancelEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteEvent cancelEvent = new frmDeleteEvent(this);
            cancelEvent.Show();
        }

        private void bookTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBookTicket bookTicket = new frmBookTicket(this);
            bookTicket.Show();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateBooking changeBooking = new frmUpdateBooking(this);
            changeBooking.Show();

        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDeleteBooking cancelBooking = new frmDeleteBooking(this);
            cancelBooking.Show();
        }

        private void showYearlyEventTypeAnalyseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowYearlyEventTypeAnalyse eventTypeAnalyse = new frmShowYearlyEventTypeAnalyse(this);
            eventTypeAnalyse.Show();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmShowYearlyRevenueAnalyse revenueAnalyse = new frmShowYearlyRevenueAnalyse(this);
            revenueAnalyse.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listOfClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListClient listClients = new frmListClient(this);
            listClients.Show();
        }

        private void listOfEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListOfEvents listEvents = new frmListOfEvents(this);
            listEvents.Show();
        }

        private void listOfBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListOfBookings listBookings = new frmListOfBookings(this);
            listBookings.Show();
        }
    }
}
