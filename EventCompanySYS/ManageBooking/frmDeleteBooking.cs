using EventCompanySYS.ManageClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EventCompanySYS.ManageBooking
{
    public partial class frmDeleteBooking : Form
    {
        frmMainMenu parent;
        private Booking theBooking = new Booking();
        private Event theEvent = new Event();
        public frmDeleteBooking(frmMainMenu parent)
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

        private void btmCancel_Click(object sender, EventArgs e)
        {
            if (theBooking != null)
            {

                DialogResult dialog = MessageBox.Show("Do you want to delete this booking?",
                       "Confirm",
                MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    dialog = MessageBox.Show("Are you sure?",
                       "Confirm",
                        MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question);

                    if (dialog == DialogResult.Yes)
                    {

                        theEvent.getEvent(theBooking.getEventID());
                        theEvent.restockTickets(theBooking.getNumberOfTikets());

                        theBooking.removeBooking(Int32.Parse(txtBookingID.Text));

                        MessageBox.Show("The booking " + txtBookingID.Text + " was deleted successfully.",
                            "Confirm",
                            MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                        resetUI();
                        grbCancelBooking.Visible = false;
                        btmDelete.Visible = false;
                        txtBookingNumb.Text = "";
                        theBooking = null;
                    }

                }
            }
        }

        private void frmDeleteBooking_Load(object sender, EventArgs e)
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
            theBooking = new Booking();

            theBooking.getBooking(Id);
            txtBookingID.Text = theBooking.getBookingID().ToString();
            theEvent.getEvent(theBooking.getEventID());

            txtEventName.Text = theEvent.getEventName();
            txtEmail.Text = theBooking.getEmail();
            txtBookingDate.Text = theBooking.getCreatedDate().ToString();
            txtNumberOfTickets.Text = theBooking.getNumberOfTikets().ToString();
            txtPrice.Text = theBooking.getPrice().ToString();
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
            grbCancelBooking.Visible = true;
            btmDelete.Visible = true;
        }
    }
}
