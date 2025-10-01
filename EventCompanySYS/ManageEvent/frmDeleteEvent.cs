using EventCompanySYS.Classes;
using EventCompanySYS.ManageClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EventCompanySYS.ManageEvent
{
    public partial class frmDeleteEvent : Form
    {
        frmMainMenu parent;
        Event theEvent = new Event();
        Venue theVenue = new Venue();
        Performer thePerformer = new Performer();

        public frmDeleteEvent(frmMainMenu parent)
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

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want delete event permanently?",
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
                    if (theEvent.removeEvent(Int32.Parse(txtEventId.Text)))
                    {
                        MessageBox.Show("The event " + txtEventId.Text + " deleted successfully.",
                          "Confirm",
                           MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                        grbCancelEvent.Visible = false;
                        grvEvents.Visible = false;
                        btnDelete.Visible = false;
                        txtSearch.Clear();
                    }



                }
            }
            else 
            {
                theEvent.setStatus('C');
            }
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
            grbCancelEvent.Visible = true;
            grvEvents.Visible = true;
            btnDelete.Visible = true;

        }

        private void lsEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

            grbCancelEvent.Visible = true;
            btnDelete.Visible = true;
        }

        private void frmCancelEvent_Load(object sender, EventArgs e)
        {
            grvEvents.DataSource = Event.getAllEvents().Tables["allEvents"];

            if (grvEvents.Rows.Count > 0)
            {
                grvEvents.ClearSelection();
                grvEvents.Rows[0].Selected = true;
                grvEvents.CurrentCell = grvEvents.Rows[0].Cells[0];

                int id = Convert.ToInt32(grvEvents.Rows[grvEvents.CurrentCell.RowIndex].Cells[0].Value.ToString());
                theEvent.getEvent(id);

                txtEventId.Text = theEvent.getEventID().ToString();
                txtEventName.Text = theEvent.getEventName();

                cmbType.Text = EventType.getTypeMeaning(theEvent.getEventType());
                txtDescription.Text = theEvent.getDescription();

                theVenue.getVenue(theEvent.getVenueID());
                txtVenue.Text = theVenue.getName();

                thePerformer.getPerformer(theEvent.getPerformerID());
                txtPerformer.Text = thePerformer.getPerformerName();

                dtpDate.Text = theEvent.getDate();

                txtDuration.Text = theEvent.getDuration().ToString();
                txtStartTime.Text = theEvent.getStatrTime();
                txtNumbOfTickets.Text = theEvent.getNumberOFTickets().ToString();
                txtTicketPrice.Text = theEvent.getTiketPrice().ToString();
                txtStatus.Text = ((char)theEvent.getStatus()).ToString();

            }
        }

        private void grvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

            txtEventId.Text = theEvent.getEventID().ToString();
            txtEventName.Text = theEvent.getEventName();

            cmbType.Text = EventType.getTypeMeaning(theEvent.getEventType());
            txtDescription.Text = theEvent.getDescription();

            theVenue.getVenue(theEvent.getVenueID());
            txtVenue.Text = theVenue.getName();

            thePerformer.getPerformer(theEvent.getPerformerID());
            txtPerformer.Text = thePerformer.getPerformerName();

            dtpDate.Text = theEvent.getDate();

            txtDuration.Text = theEvent.getDuration().ToString();
            txtStartTime.Text = theEvent.getStatrTime();
            txtNumbOfTickets.Text = theEvent.getNumberOFTickets().ToString();
            txtTicketPrice.Text = theEvent.getTiketPrice().ToString();
            txtStatus.Text = ((char)theEvent.getStatus()).ToString();
        }
    }
}
