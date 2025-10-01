using EventCompanySYS.Classes;
using EventCompanySYS.ManageClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EventCompanySYS
{
    public partial class frmBookTicket : Form
    {
        frmMainMenu parent;

        private Event theEvent = new Event();

        public frmBookTicket(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lsEvents.Items.Clear();

            DataSet ds = Event.FindAvaliableNextEvents(txtSearch.Text);

            if (ds.Tables["avaliableEventsByDateAndName"].Rows.Count == 0)
            {
                hideBookingInfo();

                MessageBox.Show("There are no events with this name",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
               
                return;
            }
            lsEvents.Visible = true;


            for (int i = 0; i < ds.Tables["avaliableEventsByDateAndName"].Rows.Count; i++)
                lsEvents.Items.Add(ds.Tables[0].Rows[i][1].ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            txtSearch.Clear();
            txtEmail.Clear();
            txtNumberOfTickets.Clear();
            lblPrice.Text = "0.00";
        }

        private void btmBook_Click(object sender, EventArgs e)
        {
            //Email
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            string email = txtEmail.Text.Trim();

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email is not in a valid format.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //NumberOfTickets
            if (string.IsNullOrEmpty(txtNumberOfTickets.Text))
            {
                MessageBox.Show("Number of tickets must be entered!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNumberOfTickets.Focus();
                return;
            }
            if (!txtNumberOfTickets.Text.Substring(1).All(char.IsDigit))
            {
                MessageBox.Show("Number of tickets must be all digits",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                txtNumberOfTickets.Focus();
                return;
            }

            DialogResult dialog = MessageBox.Show("Total price:€ " + lblPrice.Text + "\nDo you want to continue?",
                 "Confirm",
          MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Booking theBooking = new Booking(theEvent.getEventID(), txtEmail.Text, Int32.Parse(txtNumberOfTickets.Text), double.Parse(lblPrice.Text));

                Event.AdjustedTickets(Int32.Parse(lblAvailableTickets.Text), Int32.Parse(txtNumberOfTickets.Text), lblName.Text);
                theBooking.addBooking();

                MessageBox.Show("Thank you for your trust!\nInformation about your booking has been sent to your email!",
                  "Confirm",
                   MessageBoxButtons.OK,
                         MessageBoxIcon.Information);

                //restart form
                txtSearch.Clear();
                txtEmail.Clear();
                txtNumberOfTickets.Clear();

                lsEvents.Items.Clear();
                DataSet ds = Event.FindAvaliableNextEvents(txtSearch.Text);

                for (int i = 0; i < ds.Tables["avaliableEventsByDateAndName"].Rows.Count; i++)
                    lsEvents.Items.Add(ds.Tables[0].Rows[i][1].ToString());
                if (lsEvents.Items.Count != 0)
                    lsEvents.SelectedIndex = 0;


            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void lsEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpBook.Visible = true;
            grpEventInform.Visible = true;
            reset();
            loadEvent(lsEvents.SelectedIndex);

            btnBook.Visible = true;
            btnReset.Visible = true;
        }

        private void loadEvent(int selectedIndex)
        {

            if (lsEvents.SelectedIndex == -1)
            {
                return;
            }

            DataSet ds = Event.findEvent(lsEvents.Items[selectedIndex].ToString());


            for (int i = 0; i < ds.Tables["event"].Rows.Count; i++)
            {

                theEvent.getEvent(Int32.Parse(ds.Tables[0].Rows[i][0].ToString()));
                lblName.Text = ds.Tables[0].Rows[i][1].ToString();
                lblType.Text = EventType.getTypeMeaning(ds.Tables[0].Rows[i][2].ToString());
                lblDescription.Text = ds.Tables[0].Rows[i][4].ToString();

                Venue theVenue = new Venue();
                theVenue.getVenue(Int32.Parse(ds.Tables[0].Rows[i][5].ToString()));
                lblVenue.Text = theVenue.getName();

                Performer thePerformer = new Performer();
                thePerformer.getPerformer(Int32.Parse(ds.Tables[0].Rows[i][7].ToString()));
                lblPerformer.Text = thePerformer.getPerformerName();

                lblDate.Text = ((DateTime)ds.Tables[0].Rows[i][6]).ToString("dd-MMM-yy");
                lblDuration.Text = ds.Tables[0].Rows[i][9].ToString();
                lblStartTime.Text = ds.Tables[0].Rows[i][8].ToString();
                lblAvailableTickets.Text = ds.Tables[0].Rows[i][11].ToString();
                lblTicketPrice.Text = ds.Tables[0].Rows[i][12].ToString();
            }
        }

        private void txtNumberOfTickets_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumberOfTickets.Text))
            {
                if (!txtNumberOfTickets.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Number of tickets must be a valid number",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtNumberOfTickets.Clear();
                    lblPrice.Text = "0.00";
                    txtNumberOfTickets.Focus();
                    return;
                }

                int numberOfTickets = Int32.Parse(txtNumberOfTickets.Text);

                // Validate ticket count
                if (numberOfTickets > (Int32.Parse(lblAvailableTickets.Text)))
                {
                    MessageBox.Show("The number of tickets must be less than " + lblAvailableTickets.Text,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtNumberOfTickets.Clear();
                    lblPrice.Text = "0.00";
                    txtNumberOfTickets.Focus();
                    return;
                }

                if (numberOfTickets > 10)
                {
                    MessageBox.Show("Maximum number of tickets is 10",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtNumberOfTickets.Clear();
                    lblPrice.Text = "0.00";
                    txtNumberOfTickets.Focus();
                    return;
                }

                lblPrice.Text = (numberOfTickets * double.Parse(lblTicketPrice.Text)).ToString("F2");
            }
            else
            {
                lblPrice.Text = "0.00";
            }
        }

        private void clearAllLabels()
        {
            lblName.Text = "";
            lblType.Text = "";
            lblDescription.Text = "";
            lblVenue.Text = "";
            lblPerformer.Text = "";
            lblDate.Text = "";
            lblDuration.Text = "";
            lblStartTime.Text = "";
            lblAvailableTickets.Text = "";
            lblTicketPrice.Text = "";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

            clearAllLabels();

            DataSet ds = Event.findEventByDate(txtSearch.Text, dtpFilterDate.Value.ToString("dd-MMM-yy", System.Globalization.CultureInfo.InvariantCulture));

            lsEvents.Items.Clear();

            if (ds.Tables["EventsByDate"].Rows.Count == 0)
            {
                hideBookingInfo();

                MessageBox.Show("There are no available events on this date",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }


            lsEvents.Visible = true;
            
            for (int i = 0; i < ds.Tables["EventsByDate"].Rows.Count; i++)
                lsEvents.Items.Add(ds.Tables[0].Rows[i][1].ToString());

            loadEvent(0);


        }

        private void frmBookTicket_Load(object sender, EventArgs e)
        {
            dtpFilterDate.Value = DateTime.Now.Date;
            dtpFilterDate.MinDate = DateTime.Now.Date;

            DataSet ds = Event.FindAvaliableNextEvents(txtSearch.Text);

            for (int i = 0; i < ds.Tables["avaliableEventsByDateAndName"].Rows.Count; i++)
                lsEvents.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            if (lsEvents.Items.Count != 0)
                lsEvents.SelectedIndex = 0;
            else 
            {
                MessageBox.Show("There is no avaliable events for booking.",
                       "Info",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                lsEvents.Visible = false;
                grpEventInform.Visible = false;
                grpBook.Visible = false;
                btnBook.Visible = false;
                btnReset.Visible = false;

                return;
            }
        }

        private void hideBookingInfo() 
        {
            lsEvents.Visible = false;
            grpEventInform.Visible = false;
            grpBook.Visible = false;
            btnBook.Visible = false;
            btnReset.Visible = false;
        }

       
    }
}
