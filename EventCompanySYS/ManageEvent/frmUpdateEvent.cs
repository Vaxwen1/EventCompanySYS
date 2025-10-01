using EventCompanySYS.Classes;
using EventCompanySYS.ManageClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EventCompanySYS
{
    public partial class frmUpdateEvent : Form
    {
        frmMainMenu parent;
        Client theClient = new Client();
        Event theEvent = new Event();
        Performer thePerformer = new Performer();
        Venue theVenue = new Venue();
        EventType theEventType = new EventType();

        public frmUpdateEvent(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                theEvent.getEvent(Int32.Parse(grvEvents.Rows[1].Cells[0].Value.ToString()));

                txtEventId.Text = theEvent.getEventID().ToString();
                txtEventName.Text = theEvent.getEventName();

                cmbEventType.Text = EventType.getTypeMeaning(theEvent.getEventType());
                txtDescription.Text = theEvent.getDescription();


                txtVenue.Text = theVenue.getName();

                
                txtPerformer.Text = thePerformer.getPerformerName();

                dtpDate.Text = theEvent.getDate();

                txtDuration.Text = theEvent.getDuration().ToString();
                txtStartTime.Text = theEvent.getStatrTime();
                txtNumbOfTickets.Text = theEvent.getNumberOFTickets().ToString();
                txtPrice.Text = theEvent.getTiketPrice().ToString();
                cmbStatus.Text = theEvent.getStatus().ToString();

            }
            catch
            {
                MessageBox.Show("The Event is not selected.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEventName.Focus();
                return;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            grvEvents.DataSource = Event.findEvent(txtSearch.Text).Tables["event"];

            if (grvEvents.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
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
                MessageBox.Show("Event type  must be selected.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbEventType.Focus();
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


            //Start Date
            DateTime today = DateTime.Today;
            DateTime startDate = dtpDate.Value;

            if (startDate.Year != today.Year && startDate.Year != today.Year + 1)
            {
                MessageBox.Show("Start Date must be in the current or next year.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpDate.Focus();
                return;
            }
            //Capacity
            if (string.IsNullOrEmpty(txtVenue.Text))
            {
                MessageBox.Show("Capacity must be selected",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCapacity.Focus();
                return;
            }
            if (Int32.Parse(txtCapacity.Text) < (theEvent.getNumberOFTickets()-theEvent.getAvaliableTickets()))
            {
                MessageBox.Show("Capacity cannot be less then number of sold tickets!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCapacity.Focus();
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

            if (string.IsNullOrEmpty(txtPerformer.Text))
            {
                MessageBox.Show("Performer must be selected",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtVenue.Focus();
                return;
            }
            //Duration
            if (string.IsNullOrEmpty(txtDuration.Text))
            {
                MessageBox.Show("Duration must be selected",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtVenue.Focus();
                return;
            }
            if (!txtDuration.Text.Substring(1).All(char.IsDigit))
            {
                MessageBox.Show("Duration must contain only digits",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtVenue.Focus();
                return;
            }
            if (Int32.Parse(txtDuration.Text) < 2 || Int32.Parse(txtDuration.Text) >= 24)
            {
                MessageBox.Show("Duration must be at lest 2 hours and less then 24 hours",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtVenue.Focus();
                return;
            }


            //Start Time
            if (string.IsNullOrEmpty(txtStartTime.Text))
            {
                MessageBox.Show("Start time must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtStartTime.Focus();
                return;
            }
            if (txtStartTime.Text[2] != ':')
            {
                MessageBox.Show("Start time must contain ':' in the middle. Example: 13:00",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                txtStartTime.Focus();
                return;

            }
            if (!(txtStartTime.Text.Substring(0, 2).All(char.IsDigit) && txtStartTime.Text.Substring(3, 2).All(char.IsDigit)))
            {
                MessageBox.Show("Hours and minutes in start time must contain only digits",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                txtStartTime.Focus();
                return;

            }
            if (Int32.Parse(txtStartTime.Text.Substring(0, 2)) < 0 && (Int32.Parse(txtStartTime.Text.Substring(0, 2)) >= 24))
            {
                MessageBox.Show("Hours in start time must be greater than 0 and less then 24",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                txtStartTime.Focus();
                return;

            }
            if (Int32.Parse(txtStartTime.Text.Substring(3, 2)) < 0 && (Int32.Parse(txtStartTime.Text.Substring(3, 2)) >= 60))
            {
                MessageBox.Show("Minutes in start time must be greater than 0 and less then 60",
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
                txtStartTime.Focus();
                return;

            }
            if (Int32.Parse(txtNumbOfTickets.Text) < 0)
            {
                MessageBox.Show("Number of tickets must be greater the 0",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                txtStartTime.Focus();
                return;
            }

            //Ticket Price
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Ticke price must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            if (!(txtPrice.Text.Substring(1).All(char.IsDigit)))
            {
                MessageBox.Show("Ticket price must contain only digits",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                txtStartTime.Focus();
                return;

            }
            if (Double.Parse(txtPrice.Text) < 0)
            {
                MessageBox.Show("Ticke price must be greater then 0",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            //Status
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Status must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbStatus.Focus();
                return;
            }
            if (cmbStatus.Text[0] != 'A' && cmbStatus.Text[0] != 'C' && cmbStatus.Text[0] != 'P')
            {
                MessageBox.Show("Status must be A-Active, C-Cancelled or P-Padding",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbStatus.Focus();
                return;
            }

            //Save Data

            theEvent.setEventName(txtEventName.Text);
            theEvent.setEventType(EventType.getTypeIDByName(cmbEventType.Text));
            theEvent.setDescription(txtDescription.Text);

            theEvent.setVenueID(Venue.getVenueIDByName(txtVenue.Text.ToString()));

            theEvent.setPerformerID(Performer.getPerformerIDByName(txtPerformer.Text.ToString()));


            DateTime selectedDate = DateTime.Parse(dtpDate.Text); 
            string formattedDate = selectedDate.ToString("dd-MMM-yyyy");
            theEvent.setDate(formattedDate);

            theEvent.setStartTime(txtStartTime.Text);

            theEvent.setNumberOfTickets(Int32.Parse(txtNumbOfTickets.Text));
            theEvent.setTicketPrice(double.Parse(txtPrice.Text));
            theEvent.setStatus(cmbStatus.Text[0]);


            
            theEvent.updateEvent();


            MessageBox.Show("The new event was added successfully!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grvEvents.DataSource = Event.getAllEvents().Tables["allEvents"];
            if (grvEvents.Rows.Count > 0)
            {
                int id = Convert.ToInt32(grvEvents.Rows[0].Cells[0].Value.ToString());
                theEvent.getEvent(id);
                loadEvent();

            }
        }

        private void grvEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grbEventInformation.Visible = true;
            try
            {
                int id = Convert.ToInt32(grvEvents.Rows[grvEvents.CurrentCell.RowIndex].Cells[0].Value.ToString());
                theEvent.getEvent(id);
            }
            catch
            {
                MessageBox.Show("The selected Event invalid!",
                   "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                
                return;

            }
            loadEvent();
            dgvVenues.DataSource = Venue.findAvaliableVenue(txtCapacity.Text, dtpDate.Value).Tables["availableVenuebyDateAndCapacity"];

            dgvPerformers.DataSource = Performer.getAvaliablePerformers(dtpDate.Value).Tables["avaliablePerformers"];
        }
        private void loadEvent()
        {

            
            txtEventId.Text = theEvent.getEventID().ToString();
            txtEventName.Text = theEvent.getEventName();

            theClient.getClient(theEvent.getClientID());
            txtClient.Text = theClient.getOrganizationName();
            cmbEventType.Text = EventType.getTypeMeaning(theEvent.getEventType());
            txtDescription.Text = theEvent.getDescription();

            txtCapacity.Text = theEvent.getNumberOFTickets().ToString();

            lblNumberOfSoldTickets.Text = (theEvent.getNumberOFTickets() - theEvent.getAvaliableTickets()).ToString();
            theVenue.getVenue(theEvent.getVenueID());
            txtVenue.Text = theVenue.getName();

            thePerformer.getPerformer(theEvent.getPerformerID());
            txtPerformer.Text = thePerformer.getPerformerName();

            dtpDate.Text = theEvent.getDate();

            txtDuration.Text = theEvent.getDuration().ToString();
            txtStartTime.Text = theEvent.getStatrTime();
            txtNumbOfTickets.Text = theEvent.getNumberOFTickets().ToString();
            txtPrice.Text = theEvent.getTiketPrice().ToString();
            if ((char)theEvent.getStatus() == 'A')
            {
                cmbStatus.SelectedIndex = 0;
            }
            else if ((char)theEvent.getStatus() == 'C')
            {
                cmbStatus.SelectedIndex = 1;
            }
            else
            {
                cmbStatus.SelectedIndex = 2;
            }
            
        }

        private void frmUpdateEvent_Load(object sender, EventArgs e)
        {
            grvEvents.DataSource = Event.getAllEvents().Tables["allEvents"];

            if (grvEvents.Rows.Count > 0)
            {
                int id = Convert.ToInt32(grvEvents.Rows[grvEvents.CurrentCell.RowIndex].Cells[0].Value.ToString());
                theEvent.getEvent(id);
                loadEvent();

            }

            DataSet ds = EventType.getTypes();

            for (int i = 0; i < ds.Tables["types"].Rows.Count; i++)
                cmbEventType.Items.Add(ds.Tables[0].Rows[i][1].ToString());

            dgvClients.DataSource = Client.getAllAvaliableClients().Tables["avaliableClients"];

            dgvVenues.DataSource = Venue.findAvaliableVenue(txtCapacity.Text, dtpDate.Value).Tables["availableVenuebyDateAndCapacity"];

            dgvPerformers.DataSource = Performer.getAvaliablePerformers(dtpDate.Value).Tables["avaliablePerformers"];

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

        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {
            txtVenue.Clear();
            dgvVenues.DataSource = Venue.findAvaliableVenue(txtCapacity.Text, dtpDate.Value).Tables["availableVenuebyDateAndCapacity"];
        }
    }
}
