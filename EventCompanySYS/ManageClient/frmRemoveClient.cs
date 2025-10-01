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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EventCompanySYS.ManageClient
{
    public partial class frmRemoveClient : Form
    {
        frmMainMenu parent;
        Client theClient = new Client();

        public frmRemoveClient(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            grdClients.DataSource = Client.findClient(txtSearch.Text).Tables["client"];
            grdClients.Visible = true;
        }

        private void grdClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int Id = Convert.ToInt32(grdClients.Rows[grdClients.CurrentCell.RowIndex].Cells[0].Value.ToString());
                theClient.getClient(Id);
                grpClientInformation.Visible = true;
                btnRemove.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please select a valid client.",
                  "Info",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                return;
            }

            // Move the instance variable values to the form controls
            txtClientID.Text = theClient.getClientID().ToString();
            txtClientName.Text = theClient.getOrganizationName();
            txtContactPerson.Text = theClient.getContactPerson();
            txtTelNumber.Text = theClient.getTelNumb();
            txtEmail.Text = theClient.getEmail();
            txtBuilding.Text = theClient.getBuilding();
            txtStreet.Text = theClient.getStreet();
            txtCity.Text = theClient.getCity();
            cmbCounty.Text = theClient.getCounty();
            txtEircode.Text = theClient.getEircode();
            txtStatus.Text = theClient.getStatus().ToString();
        }

       
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (theClient.getClientID() == 0)
            {
                MessageBox.Show("Please select a valid client.",
                 "Info",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                return;
            }

            DialogResult dialog = MessageBox.Show("Do you want to delete the client permanently?",
                   "Confirm",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                dialog = MessageBox.Show("Are you sure you want to delete this client?",
                   "Confirm",
                    MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    if (theClient.removeClient(Int32.Parse(txtClientID.Text)))
                    {
                        MessageBox.Show("The client with ID " + txtClientID.Text + " was deleted successfully.",
                          "Confirm",
                           MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                        grpClientInformation.Visible = false;
                        grdClients.Visible = false;
                        btnRemove.Visible = false;
                        txtSearch.Clear();
                    }
                }
            }
            else
            {
                dialog = MessageBox.Show("Are you sure you want to deactivate this client?",
                  "Confirm",
                   MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    theClient.setStatus('D');
                    theClient.updateClient();

                    MessageBox.Show("The client with ID " + txtClientID.Text + " was deactivated successfully.",
                      "Confirm",
                       MessageBoxButtons.OK,
                             MessageBoxIcon.Information);

                    grpClientInformation.Visible = false;
                    grdClients.Visible = false;
                    btnRemove.Visible = false;
                    txtSearch.Clear();
                }
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

        private void frmRemoveClient_Load(object sender, EventArgs e)
        {
            grdClients.DataSource = Client.getAllClients().Tables["client"];
            if (grdClients.Rows.Count > 0)
            {
                loadClient();
            }

        }

        private void loadClient() 
        {
            grdClients.ClearSelection();
            grdClients.Rows[0].Selected = true;
            grdClients.CurrentCell = grdClients.Rows[0].Cells[0];

            int Id = Convert.ToInt32(grdClients.Rows[grdClients.CurrentCell.RowIndex].Cells[0].Value.ToString());
            theClient.getClient(Id);

            txtClientID.Text = theClient.getClientID().ToString();
            txtClientName.Text = theClient.getOrganizationName();
            txtContactPerson.Text = theClient.getContactPerson();
            txtTelNumber.Text = theClient.getTelNumb();
            txtEmail.Text = theClient.getEmail();
            txtBuilding.Text = theClient.getBuilding();
            txtStreet.Text = theClient.getStreet();
            txtCity.Text = theClient.getCity();
            cmbCounty.Text = theClient.getCounty();
            txtEircode.Text = theClient.getEircode();
            txtStatus.Text = theClient.getStatus().ToString();
        }



    }
}
