using EventCompanySYS.Classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EventCompanySYS
{
    public partial class frmAddClient : Form
    {
        frmMainMenu parent;

        public frmAddClient(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtClientName.Clear();
            txtTelNumber.Clear();
            txtEmail.Clear();
            txtBuilding.Clear();
            txtStreet.Clear();
            cmbCounty.SelectedIndex = -1;
            txtCity.Clear();
            txtEircode.Clear();
            txtClientName.Focus();
        }

        private void btm_Confirm_Click(object sender, EventArgs e)
        {
            //Validate data
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

            //Telephone Number
            if (string.IsNullOrEmpty(txtTelNumber.Text))
            {
                MessageBox.Show("Telephone number must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtTelNumber.Focus();
                return;
            }

            if (txtTelNumber.Text[0].Equals('+'))
            {
                if (txtTelNumber.Text.Length != 13 || !txtTelNumber.Text.Substring(1).All(char.IsDigit))
                {
                    MessageBox.Show("Telephone number must contain 13 characters, with 12 digits.",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    txtTelNumber.Focus();
                    return;
                }

            }
            else
            {
                MessageBox.Show("Telephone number must contain '+' at the beginning",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                txtTelNumber.Focus();
                return;
            }


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


            //Building
            if (string.IsNullOrEmpty(txtBuilding.Text))
            {
                MessageBox.Show("Building must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtBuilding.Focus();
                return;
            }


            //Street
            if (string.IsNullOrEmpty(txtStreet.Text))
            {
                MessageBox.Show("Street must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }


            //City
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                MessageBox.Show("City must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCity.Focus();
                return;
            }


            //County
            if (string.IsNullOrEmpty(cmbCounty.Text))
            {
                MessageBox.Show("County must be selected",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbCounty.Focus();
                return;
            }


            //Eircode
            if (string.IsNullOrEmpty(txtEircode.Text))
            {
                MessageBox.Show("Eircode must be entered",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }

            string eircodePattern = @"^[A-Za-z0-9]{3}\s?[A-Za-z0-9]{4}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEircode.Text, eircodePattern))
            {
                MessageBox.Show("Invalid Eircode format. E.g., 'A65 F4E2' or 'D02Y006'",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEircode.Focus();
                return;
            }


            //Save data
            Client aClient = new Client(Client.getNextClientID(), txtClientName.Text, txtContactPerson.Text, txtTelNumber.Text,
                txtEmail.Text, txtBuilding.Text, txtStreet.Text, txtCity.Text, cmbCounty.Text, txtEircode.Text, 'A');

            aClient.addClient();
            //Display conformation message
            MessageBox.Show("Client " + aClient.clientID + " added successfully", "Success",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            //Reset the UI

            txtClientName.Clear();
            txtContactPerson.Clear();
            txtTelNumber.Clear();
            txtEmail.Clear();
            txtBuilding.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            cmbCounty.SelectedIndex = -1;
            txtEircode.Clear();
            txtClientName.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
           
            DataSet ds = County.getCounties();

            for (int i = 0; i < ds.Tables["County"].Rows.Count; i++)
                cmbCounty.Items.Add(ds.Tables[0].Rows[i][0].ToString());
        }
    }
}
