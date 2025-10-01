using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventCompanySYS.ManageBooking
{
    public partial class frmListOfBookings : Form
    {
        frmMainMenu parent;
        public frmListOfBookings(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmListOfBookings_Load(object sender, EventArgs e)
        {
            grdBookings.DataSource = Booking.getBookings().Tables["allBookings"];
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
