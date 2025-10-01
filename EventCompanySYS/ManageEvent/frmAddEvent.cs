using EventCompanySYS.Classes;
using EventCompanySYS.ManageClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EventCompanySYS
{
    
    public partial class frmAddEvent : Form
    {
        frmMainMenu parent;
        Venue theVenue = new Venue();
        Client theClient = new Client();
        Performer thePerformer = new Performer();

        public frmAddEvent(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset the UI
            resetUI();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {

            //Validation 

            //Event Name
            if (string.IsNullOrEmpty(txtEventName.Text))
            {
                MessageBox.Show("Event Name must be entered.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEventName.Focus();
                return;
            }
            //eventType

            if (string.IsNullOrEmpty(cmbEventType.Text))
            {
                MessageBox.Show("Event type must be selected.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbEventType.Focus();
                return;
            }

            //Clirnt

            if (string.IsNullOrEmpty(txtClient.Text))
            {
                MessageBox.Show("Client must be selected.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtClient.Focus();
                return;
            }
            //Event Description
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Discription must be entered.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }

            //Capacity
            if (string.IsNullOrEmpty(txtCapacity.Text))
            {
                MessageBox.Show("Capacity must be entered.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCapacity.Focus();
                return;
            }


            //Start Date
            DateTime today = DateTime.Today;
            DateTime startDate = dtpDate.Value;

            if (startDate < today.AddMonths(1))
            {
                MessageBox.Show("Start Date must be at least a months after today.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpDate.Focus();
                return;
            }

            if (startDate.Year != today.Year && startDate.Year != today.Year + 1)
            {
                MessageBox.Show("Start Date must be in the current or next year.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpDate.Focus();
                return;
            }


            //Venue 
            if (string.IsNullOrEmpty(txtVenue.Text))
            {
                MessageBox.Show("Venue must be selected",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtVenue.Focus();
                return;
            }

            //Performer 
            if (string.IsNullOrEmpty(txtPerformer.Text))
            {
                MessageBox.Show("Performer must be selected",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPerformer.Focus();
                return;
            }

            //Duration
            if (string.IsNullOrEmpty(txtDuration.Text))
            {
                MessageBox.Show("Duration must be selected",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDuration.Focus();
                return;
            }
            if (!txtDuration.Text.Substring(1).All(char.IsDigit)) 
            {
                MessageBox.Show("Duration must contain only digits",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDuration.Focus();
                return;
            }
            if (Int32.Parse(txtDuration.Text) < 2 || Int32.Parse(txtDuration.Text) >= 24)
            {
                MessageBox.Show("Duration must be at lest 2 hours and less then 24 hours",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDuration.Focus();
                return;
            }


            //Start Time
            string input = txtStartTime.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Start time must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtStartTime.Focus();
                return;
            }

            if (!input.Contains(":"))
            {
                input += ":00";
            }

            // Validate input format using TimeSpan.TryParseExact
            // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.timespan.tryparseexact

            if (!TimeSpan.TryParseExact(input, "hh\\:mm", null, out TimeSpan startTime) &&
                !TimeSpan.TryParseExact(input, "HH\\:mm", null, out startTime))
            {
                MessageBox.Show("Start time must be in the format HH:mm, e.g. 13:00",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtStartTime.Focus();
                return;
            }

            // Validate hour and minute ranges
            if (startTime.Hours < 0 || startTime.Hours > 23)
            {
                MessageBox.Show("Hours must be between 0 and 23.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtStartTime.Focus();
                return;
            }

            if (startTime.Minutes < 0 || startTime.Minutes > 59)
            {
                MessageBox.Show("Minutes must be between 0 and 59.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtStartTime.Focus();
                return;
            }




            //Numb Of Tickets
            if (string.IsNullOrEmpty(txtNumbOfTickets.Text))
            {
                MessageBox.Show("Number of tickets must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNumbOfTickets.Focus();
                return;
            }
            if (!(txtNumbOfTickets.Text.Substring(1).All(char.IsDigit)))
            {
                MessageBox.Show("Number of tickets must contain only digits",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                txtNumbOfTickets.Focus();
                return;

            }
            if (Int32.Parse(txtNumbOfTickets.Text) < 0) 
            {
                MessageBox.Show("Number of tickets must be greater the 0",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                txtNumbOfTickets.Focus();
                return;
            }
            if(Int32.Parse(txtNumbOfTickets.Text) > Int32.Parse(txtCapacity.Text))
            {
                MessageBox.Show("Number of tickets must be less or equal the capacity of selected venue.",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                txtNumbOfTickets.Focus();
                return;
            }
            //Ticket Price

            if (string.IsNullOrEmpty(txtTicketPrice.Text))
            {
                MessageBox.Show("Ticke price must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTicketPrice.Focus();
                return;
            }

            if (!double.TryParse(txtTicketPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid number!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTicketPrice.Focus();
                return;
            }

            if (price <= 0 || price > 999.99)
            {
                MessageBox.Show("Ticket price must be more than 0 and less than or equal to 999.99!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTicketPrice.Focus();
                return;
            }

            if (Math.Round(price, 2) != price)
            {
                MessageBox.Show("Price should have at most two decimal places!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTicketPrice.Focus();
                return;
            }


            Event anEvent = new Event(Event.getNextEventID(), txtEventName.Text, cmbEventType.Text.Substring(0, 2), theClient.getClientID(), txtDescription.Text, theVenue.getVenueID(), dtpDate.Value.ToString("dd-MMM-yy", System.Globalization.CultureInfo.InvariantCulture), thePerformer.getPerformerID(),
                 txtStartTime.Text, Int32.Parse(txtDuration.Text), Int32.Parse(txtNumbOfTickets.Text), Int32.Parse(txtNumbOfTickets.Text), float.Parse(txtTicketPrice.Text));
            anEvent.addEvent();

            MessageBox.Show("The event " + anEvent.getEventID().ToString() +" was added successfully!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Reset the UI
            resetUI();

        }

        public void resetUI()
        {
            txtEventName.Clear();
            txtDuration.Clear();
            cmbEventType.SelectedIndex = -1;
            txtCapacity.Clear();
            txtClient.Clear();
            txtPerformer.Clear();
            txtDescription.Clear();
            txtVenue.Clear();
            dtpDate.Value = DateTime.Now;
            txtStartTime.Clear();
            txtNumbOfTickets.Clear();
            txtTicketPrice.Clear();
            txtEventName.Focus();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dgvVenues.DataSource = Venue.findAvaliableVenue(txtCapacity.Text, dtpDate.Value).Tables["availableVenuebyDateAndCapacity"];

            dgvPerformers.DataSource = Performer.getAvaliablePerformers(dtpDate.Value).Tables["avaliablePerformers"];
            txtVenue.Clear();
            txtPerformer.Clear();

        }

        private void frmAddEvent_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now.Date;
            dtpDate.MinDate = DateTime.Now.Date;

            DataSet ds = EventType.getTypes();

            for (int i = 0; i < ds.Tables["types"].Rows.Count; i++)
                cmbEventType.Items.Add(ds.Tables[0].Rows[i][0].ToString() + " - " +
                ds.Tables[0].Rows[i][1].ToString());

            dgvClients.DataSource = Client.getAllAvaliableClients().Tables["avaliableClients"];

            dgvVenues.DataSource = Venue.findAvaliableVenue(txtCapacity.Text,dtpDate.Value).Tables["availableVenuebyDateAndCapacity"];

            dgvPerformers.DataSource = Performer.getAvaliablePerformers(dtpDate.Value).Tables["avaliablePerformers"];


            dgvClients.Columns[0].Visible = false;
            dgvVenues.Columns[0].Visible = false;
            dgvPerformers.Columns[0].Visible = false;

            dgvClients.Columns[1].Width = 200;
            dgvClients.Columns[2].Width = 200;
        }

        private void dgvVenues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {
                int Id = Convert.ToInt32(dgvVenues.Rows[dgvVenues.CurrentCell.RowIndex].Cells[0].Value.ToString());
                theVenue.getVenue(Id);
                txtVenue.Text = theVenue.getName();
                txtCapacity.Text = theVenue.getCapacity().ToString();
            }
            catch
            {
                MessageBox.Show("Please select a valid venue.",
                   "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }

        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(dgvClients.Rows[dgvClients.CurrentCell.RowIndex].Cells[0].Value.ToString());
                theClient.getClient(Id);
                txtClient.Text = theClient.getOrganizationName();
            }
            catch
            {
                MessageBox.Show("Please select a valid client.",
                   "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }

        }

        private void dgvPerformers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(dgvPerformers.Rows[dgvPerformers.CurrentCell.RowIndex].Cells[0].Value.ToString());
                thePerformer.getPerformer(Id);
                txtPerformer.Text = thePerformer.getPerformerName();
            }
            catch
            {
                MessageBox.Show("Please select a valid performer.",
                   "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }

        }

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {
            txtVenue.Clear();
            dgvVenues.DataSource = Venue.findAvaliableVenue(txtCapacity.Text, dtpDate.Value).Tables["availableVenuebyDateAndCapacity"];
        }

        private void txtNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvPerformers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(dgvPerformers.Rows[dgvPerformers.CurrentCell.RowIndex].Cells[0].Value.ToString());
                thePerformer.getPerformer(Id);
                txtPerformer.Text = thePerformer.getPerformerName();
            }
            catch
            {
                MessageBox.Show("Please select a valid performer.",
                   "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }
        }
    }
}