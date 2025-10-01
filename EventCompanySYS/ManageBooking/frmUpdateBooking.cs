using EventCompanySYS.Classes;
using EventCompanySYS.ManageClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EventCompanySYS.ManageBooking
{
    public partial class frmUpdateBooking : Form
    {
        frmMainMenu parent;
        int numberOfTickets = 0;
        Booking theBooking = new Booking();
        Event theEvent = new Event();

        public frmUpdateBooking(frmMainMenu parent)
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

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingNumb.Text))
            {
                grdBookings.DataSource = Booking.getBookings().Tables["allBookings"];
            }
            else if (!txtBookingNumb.Text.Substring(0).All(char.IsDigit))
            {
                MessageBox.Show("The booking number must contain only digits",
                 "Error",
                  MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            try
            {
                grdBookings.DataSource = Booking.findBooking(txtBookingNumb.Text).Tables["booking"];
            }
            catch
            {
                MessageBox.Show("There is no booking with such number",
                "Info",
                 MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                return;
            }
        }

        private void frmChangeBooking_Load(object sender, EventArgs e)
        {
           resetUI();
        }

        private void resetUI() 
        {
            txtBookingNumb.Clear();

            grdBookings.DataSource = Booking.getBookings().Tables["allBookings"];

            if (grdBookings.Rows.Count > 0)
            {
                grdBookings.ClearSelection();
                grdBookings.Rows[0].Selected = true;
                grdBookings.CurrentCell = grdBookings.Rows[0].Cells[0];
                int id = Convert.ToInt32(grdBookings.Rows[grdBookings.CurrentCell.RowIndex].Cells[0].Value.ToString());
                setBooking(id);
            }
        }

        private void setBooking(int Id)
        {
            
            theBooking.getBooking(Id);
            setEvent(theBooking.getEventID());

            txtBookingID.Text = theBooking.getBookingID().ToString();
            txtEventName.Text = theEvent.getEventName();
            txtEmail.Text = theBooking.getEmail();
            txtBookingDate.Text = theBooking.getCreatedDate().ToString();
            txtNumberOfTickets.Text = theBooking.getNumberOfTikets().ToString();
            txtPrice.Text = theBooking.getPrice().ToString();
        }

        private void setEvent(int id)
        {
            theEvent.getEvent(id);
            lblEventName.Text = theEvent.getEventName();
            lblEventType.Text = theEvent.getEventType();
            lblDescription.Text = theEvent.getDescription();
            Venue theVenue = new Venue();
            theVenue.getVenue(theEvent.getVenueID());
            lblVenue.Text = theVenue.getName();
            Performer thePerformer = new Performer();
            thePerformer.getPerformer(theEvent.getPerformerID());

            lblPerformer.Text = thePerformer.getPerformerName();
            lblDate.Text = theEvent.getDate().ToString();
            lblTime.Text = theEvent.getStatrTime().ToString();
            lblDuration.Text = theEvent.getDuration().ToString();
            lblAvaliableTickets.Text = theEvent.getAvaliableTickets().ToString();
            lblPricePerTicket.Text = "€" + theEvent.getTiketPrice().ToString();
        }



        private void txtNumberOfTickets_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnChange_Click(object sender, EventArgs e)
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

            if (!int.TryParse(txtNumberOfTickets.Text, out int ticketCount))
            {
                MessageBox.Show("The number of tickets should be an integer",
               "Error",
                MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                txtNumberOfTickets.Text = numberOfTickets.ToString();
                return;
            }
            if (Int32.Parse(txtNumberOfTickets.Text) < 0 || Int32.Parse(txtNumberOfTickets.Text) > 10)
            {
                MessageBox.Show("The number of tickets cannot be less than 0 or more than 10",
               "Error",
                MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                txtNumberOfTickets.Text = numberOfTickets.ToString();
                return;
            }
            if (Int32.Parse(txtNumberOfTickets.Text) < numberOfTickets)
            {
                MessageBox.Show("The number of tickets cannot be less than the current number of tickets",
               "Error",
                MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                txtNumberOfTickets.Text = numberOfTickets.ToString();
                return;
            }


            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                theEvent.getEvent(theBooking.getEventID());
                theEvent.restockTickets(theBooking.getNumberOfTikets() - Int32.Parse(txtNumberOfTickets.Text));

                theBooking.setPrice(Int32.Parse(txtNumberOfTickets.Text) * theEvent.getTiketPrice());

                theBooking.setEmail(txtEmail.Text);
                theBooking.setNumberOfTickets(Int32.Parse(txtNumberOfTickets.Text));
                theBooking.setEventID(theEvent.getEventID());

                try
                {
                    theBooking.updateBooking();
                }
                catch
                {
                    MessageBox.Show("The booking cannot be changed", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBookingNumb.Clear();
                    return;
                }

                MessageBox.Show("The booking " + theBooking.getBookingID() + " was successfully changed", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetUI();
            }
        }

        private void grdBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(grdBookings.Rows[grdBookings.CurrentCell.RowIndex].Cells[0].Value.ToString());
                setBooking(id);
                theEvent.getEvent(theBooking.getEventID());

            }
            catch
            {
                MessageBox.Show("Please select a valid booking.",
                   "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                return;
            }

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (grdBookings.Rows.Count > 0)
            {
                int id = Convert.ToInt32(grdBookings.Rows[grdBookings.CurrentCell.RowIndex].Cells[0].Value.ToString());
                setBooking(id);
            }
        }
    }
}
