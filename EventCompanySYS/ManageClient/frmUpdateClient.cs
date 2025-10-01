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
using System.Xml.Linq;

namespace EventCompanySYS
{
    
    public partial class frmUpdateClient : Form
    {

        frmMainMenu parent;
        Client theClient = new Client();
        public frmUpdateClient(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            // Validate data

            //Client Name

            if (string.IsNullOrEmpty(txtClientName.Text))
            {
                MessageBox.Show("Client Name must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtClientName.Focus();
                return;
            }

            for (int i = 0; i < txtClientName.Text.Length; i++)
            {
                if (!char.IsLetter(txtClientName.Text[i]) && txtClientName.Text[i] != ' ')
                {
                    MessageBox.Show("Client Name must consist ONLY of letters and spaces.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtClientName.Focus();
                    return;
                }
            }

            //Contact person
            if (string.IsNullOrEmpty(txtContactPerson.Text))
            {
                MessageBox.Show("Contact person must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtContactPerson.Focus();
                return;
            }

            for (int i = 0; i < txtContactPerson.Text.Length; i++)
            {
                if (!char.IsLetter(txtContactPerson.Text[i]) && txtContactPerson.Text[i] != ' ')
                {
                    MessageBox.Show("Contact person must consist ONLY of letters and spaces.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtContactPerson.Focus();
                    return;
                }
            }

            // Telephone Number
            if (string.IsNullOrEmpty(txtTelNumber.Text))
            {
                MessageBox.Show("Telephone number must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelNumber.Focus();
                return;
            }

            if (txtTelNumber.Text[0].Equals('+'))
            {
                if (txtTelNumber.Text.Length != 13 || !txtTelNumber.Text.Substring(1).All(char.IsDigit))
                {
                    MessageBox.Show("Telephone number must contain 13 characters, including 12 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTelNumber.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Telephone number must begin with '+'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelNumber.Focus();
                return;
            }

            // Email
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

            // Building
            if (string.IsNullOrEmpty(txtBuilding.Text))
            {
                MessageBox.Show("Building must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBuilding.Focus();
                return;
            }

            // Street
            if (string.IsNullOrEmpty(txtStreet.Text))
            {
                MessageBox.Show("Street must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }

            // City
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("City must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCity.Focus();
                return;
            }

            // County
            if (string.IsNullOrEmpty(cmbCounty.Text))
            {
                MessageBox.Show("County must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCounty.Focus();
                return;
            }

            // Eircode
            if (string.IsNullOrEmpty(txtEircode.Text))
            {
                MessageBox.Show("Eircode must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }

            // Status
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                MessageBox.Show("Status must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStatus.Focus();
                return;
            }

            if (cmbStatus.Text[0] != 'A' && cmbStatus.Text[0] != 'D')
            {
                MessageBox.Show("Status must be A - Active or D - Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStatus.Focus();
                return;
            }

            // Save data
            theClient.setOrganizationName(txtClientName.Text);
            theClient.setContactPerson(txtContactPerson.Text);
            theClient.setTelNumb(txtTelNumber.Text);
            theClient.setEmail(txtEmail.Text);
            theClient.setBuilding(txtBuilding.Text);
            theClient.setStreet(txtStreet.Text);
            theClient.setCity(txtCity.Text);
            theClient.setCounty(cmbCounty.Text);
            theClient.setEircode(txtEircode.Text);
            theClient.setStatus(cmbStatus.Text[0]);

            theClient.updateClient();

            // Display confirmation message
            MessageBox.Show("The client was successfully updated in the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset the UI
            grpClientInformation.Visible = false;
            txtSearch.Clear();
            grdClients.DataSource = Client.getAllClients().Tables["client"];
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtClientID.Text = theClient.getClientID().ToString();
            txtClientName.Text = theClient.getOrganizationName();
            txtContactPerson.Text = theClient.getContactPerson().ToString();
            txtTelNumber.Text = theClient.getTelNumb();
            txtEmail.Text = theClient.getEmail();
            txtBuilding.Text = theClient.getBuilding();
            txtStreet.Text = theClient.getStreet();
            txtCity.Text = theClient.getCity();
            cmbCounty.Text = theClient.getCounty();
            txtEircode.Text = theClient.getEircode();
            cmbStatus.Text = theClient.getStatus().ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            grdClients.DataSource = Client.findClient(txtSearch.Text).Tables["client"];

            if (grdClients.Rows.Count == 1)
            {
                MessageBox.Show("No Data Found");
                txtSearch.Focus();
                return;
            }

            grdClients.Visible = true;

        }

        private void grdClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                int Id = Convert.ToInt32(grdClients.Rows[grdClients.CurrentCell.RowIndex].Cells[0].Value.ToString());
                theClient.getClient(Id);
            }
            catch
            {
                MessageBox.Show("The selected Client invalid!",
                   "Info",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                return;
            }

            loadClient();
        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
            DataSet ds = County.getCounties();

            for (int i = 0; i < ds.Tables["County"].Rows.Count; i++)
                cmbCounty.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            grdClients.DataSource = Client.getAllClients().Tables["client"];

            if (grdClients.Rows.Count > 0)
            {
                int Id = Convert.ToInt32(grdClients.Rows[0].Cells[0].Value.ToString());
                theClient.getClient(Id);
                loadClient();
            }
        }

        private void loadClient()
        {
            txtClientID.Text = theClient.getClientID().ToString();
            txtClientName.Text = theClient.getOrganizationName();
            txtContactPerson.Text = theClient.getContactPerson().ToString();
            txtTelNumber.Text = theClient.getTelNumb();
            txtEmail.Text = theClient.getEmail();
            txtBuilding.Text = theClient.getBuilding();
            txtStreet.Text = theClient.getStreet();
            txtCity.Text = theClient.getCity();
            cmbCounty.Text = theClient.getCounty();
            txtEircode.Text = theClient.getEircode();
            if (theClient.getStatus() == 'A')
            {
                cmbStatus.SelectedIndex = 0;
            }
            else
            {
                cmbStatus.SelectedIndex = 1;
            }


            DataSet ds = County.getCounties();

            int typeIndex = 0;
            cmbCounty.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbCounty.Items.Add(ds.Tables[0].Rows[i][0]);
                if (ds.Tables[0].Rows[i][0].Equals(theClient.getCounty())) typeIndex = i;
            }
            cmbCounty.SelectedIndex = typeIndex;

            //make the data availale for updating
            grpClientInformation.Visible = true;
            btnConfirm.Visible = true;
            btnReset.Visible = true;
        }

    }
}
