namespace EventCompanySYS.ManageClient
{
    partial class frmRemoveClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpClientInformation = new System.Windows.Forms.GroupBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grdClients = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpClientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFind.Location = new System.Drawing.Point(898, 79);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(44, 24);
            this.btnFind.TabIndex = 25;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(440, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(520, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(371, 26);
            this.txtSearch.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(577, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Remove Client";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRemove.Location = new System.Drawing.Point(586, 658);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 34);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1225, 29);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtEircode
            // 
            this.txtEircode.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtEircode.Enabled = false;
            this.txtEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEircode.Location = new System.Drawing.Point(216, 418);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(98, 30);
            this.txtEircode.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(21, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 53;
            this.label8.Text = "Eircode";
            // 
            // cmbCounty
            // 
            this.cmbCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCounty.Enabled = false;
            this.cmbCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Items.AddRange(new object[] {
            "Galway",
            "Leitrim",
            "Mayo",
            "Roscommon",
            "Sligo",
            "Carlow",
            "Dublin",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Longford",
            "Louth",
            "Meath",
            "Offaly",
            "Westmeath",
            "Wexford",
            "Wicklow",
            "Clare",
            "Cork",
            "Kerry",
            "Limerick",
            "Tipperary",
            "Waterford",
            "Cavan",
            "Donegal",
            "Monaghan",
            "Antrim",
            "Armagh",
            "Down",
            "Fermanagh",
            "Londonderry",
            "Tyrone"});
            this.cmbCounty.Location = new System.Drawing.Point(216, 368);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(242, 33);
            this.cmbCounty.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(21, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "County";
            // 
            // txtCity
            // 
            this.txtCity.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtCity.Enabled = false;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCity.Location = new System.Drawing.Point(216, 317);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(243, 30);
            this.txtCity.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(21, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtStreet.Enabled = false;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtStreet.Location = new System.Drawing.Point(216, 267);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(243, 30);
            this.txtStreet.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(21, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "Street";
            // 
            // txtBuilding
            // 
            this.txtBuilding.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtBuilding.Enabled = false;
            this.txtBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBuilding.Location = new System.Drawing.Point(216, 219);
            this.txtBuilding.MaxLength = 30;
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(243, 30);
            this.txtBuilding.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(21, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "Building";
            // 
            // txtClientID
            // 
            this.txtClientID.Enabled = false;
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtClientID.Location = new System.Drawing.Point(217, 22);
            this.txtClientID.MaxLength = 20;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(243, 29);
            this.txtClientID.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(22, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 43;
            this.label6.Text = "Client Id";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEmail.Location = new System.Drawing.Point(217, 177);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 29);
            this.txtEmail.TabIndex = 42;
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.Enabled = false;
            this.txtTelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTelNumber.Location = new System.Drawing.Point(217, 133);
            this.txtTelNumber.MaxLength = 13;
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.Size = new System.Drawing.Size(243, 29);
            this.txtTelNumber.TabIndex = 41;
            // 
            // txtClientName
            // 
            this.txtClientName.Enabled = false;
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtClientName.Location = new System.Drawing.Point(217, 61);
            this.txtClientName.MaxLength = 50;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(243, 29);
            this.txtClientName.TabIndex = 40;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Email.Location = new System.Drawing.Point(22, 180);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(57, 24);
            this.Email.TabIndex = 39;
            this.Email.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(22, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Telephone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(22, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Organization name";
            // 
            // grpClientInformation
            // 
            this.grpClientInformation.Controls.Add(this.txtContactPerson);
            this.grpClientInformation.Controls.Add(this.label12);
            this.grpClientInformation.Controls.Add(this.txtStatus);
            this.grpClientInformation.Controls.Add(this.label11);
            this.grpClientInformation.Controls.Add(this.txtEircode);
            this.grpClientInformation.Controls.Add(this.label8);
            this.grpClientInformation.Controls.Add(this.cmbCounty);
            this.grpClientInformation.Controls.Add(this.label7);
            this.grpClientInformation.Controls.Add(this.txtCity);
            this.grpClientInformation.Controls.Add(this.label5);
            this.grpClientInformation.Controls.Add(this.txtStreet);
            this.grpClientInformation.Controls.Add(this.label9);
            this.grpClientInformation.Controls.Add(this.txtBuilding);
            this.grpClientInformation.Controls.Add(this.label10);
            this.grpClientInformation.Controls.Add(this.txtClientID);
            this.grpClientInformation.Controls.Add(this.label6);
            this.grpClientInformation.Controls.Add(this.txtEmail);
            this.grpClientInformation.Controls.Add(this.txtTelNumber);
            this.grpClientInformation.Controls.Add(this.txtClientName);
            this.grpClientInformation.Controls.Add(this.Email);
            this.grpClientInformation.Controls.Add(this.label3);
            this.grpClientInformation.Controls.Add(this.label4);
            this.grpClientInformation.Location = new System.Drawing.Point(662, 121);
            this.grpClientInformation.Name = "grpClientInformation";
            this.grpClientInformation.Size = new System.Drawing.Size(502, 519);
            this.grpClientInformation.TabIndex = 55;
            this.grpClientInformation.TabStop = false;
            this.grpClientInformation.Text = "Client information";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Enabled = false;
            this.txtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtContactPerson.Location = new System.Drawing.Point(217, 96);
            this.txtContactPerson.MaxLength = 50;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(243, 29);
            this.txtContactPerson.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(22, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 24);
            this.label12.TabIndex = 57;
            this.label12.Text = "Contact Person";
            // 
            // txtStatus
            // 
            this.txtStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtStatus.Location = new System.Drawing.Point(216, 470);
            this.txtStatus.MaxLength = 1;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(57, 30);
            this.txtStatus.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(21, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 55;
            this.label11.Text = "Status";
            // 
            // grdClients
            // 
            this.grdClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClients.Location = new System.Drawing.Point(81, 121);
            this.grdClients.Name = "grdClients";
            this.grdClients.RowHeadersWidth = 51;
            this.grdClients.Size = new System.Drawing.Size(555, 519);
            this.grdClients.TabIndex = 56;
            this.grdClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClients_CellClick);
            // 
            // frmRemoveClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1225, 710);
            this.Controls.Add(this.grdClients);
            this.Controls.Add(this.grpClientInformation);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmRemoveClient";
            this.Text = "frmRemoveClient";
            this.Load += new System.EventHandler(this.frmRemoveClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpClientInformation.ResumeLayout(false);
            this.grpClientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelNumber;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpClientInformation;
        private System.Windows.Forms.DataGridView grdClients;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label12;
    }
}