using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventCompanySYS.ManageClient
{
    public partial class frmListClient : Form
    {
        frmMainMenu parent;
        public frmListClient(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmListClients_Load(object sender, EventArgs e)
        {
            grdClients.DataSource = Client.getAllClients().Tables["client"];       
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
