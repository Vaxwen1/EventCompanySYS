namespace EventCompanySYS
{
    partial class frmUpdateClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.grpClientInformation = new System.Windows.Forms.GroupBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grdClients = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.grpClientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(416, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Client";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearch.Location = new System.Drawing.Point(340, 90);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(308, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(995, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "mnuUpdateClient";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(54, 25);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(259, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(484, 687);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(141, 34);
            this.btnConfirm.TabIndex = 21;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.Location = new System.Drawing.Point(325, 687);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(141, 34);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEmail.Location = new System.Drawing.Point(221, 193);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 29);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.Text = "mymtu@ittralee.ie";
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTelNumber.Location = new System.Drawing.Point(221, 149);
            this.txtTelNumber.MaxLength = 13;
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.Size = new System.Drawing.Size(243, 29);
            this.txtTelNumber.TabIndex = 17;
            this.txtTelNumber.Text = "+123456789102";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtClientName.Location = new System.Drawing.Point(221, 63);
            this.txtClientName.MaxLength = 50;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(243, 29);
            this.txtClientName.TabIndex = 16;
            this.txtClientName.Text = "MTU(Noth Campus)";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Email.Location = new System.Drawing.Point(26, 196);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(57, 24);
            this.Email.TabIndex = 14;
            this.Email.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telephone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(26, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Organization name";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFind.Location = new System.Drawing.Point(654, 92);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(44, 24);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.Enabled = false;
            this.txtClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtClientID.Location = new System.Drawing.Point(221, 24);
            this.txtClientID.MaxLength = 300;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(243, 29);
            this.txtClientID.TabIndex = 24;
            this.txtClientID.Text = "123";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(26, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Client Id";
            // 
            // txtEircode
            // 
            this.txtEircode.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEircode.Location = new System.Drawing.Point(220, 434);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(98, 30);
            this.txtEircode.TabIndex = 34;
            this.txtEircode.Text = "V92HD4V";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(25, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Eircode";
            // 
            // cmbCounty
            // 
            this.cmbCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(222, 384);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(242, 33);
            this.cmbCounty.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(25, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "County";
            // 
            // txtCity
            // 
            this.txtCity.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCity.Location = new System.Drawing.Point(220, 333);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(243, 30);
            this.txtCity.TabIndex = 30;
            this.txtCity.Text = "Tralee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(25, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "City";
            // 
            // txtStreet
            // 
            this.txtStreet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtStreet.Location = new System.Drawing.Point(220, 283);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(243, 30);
            this.txtStreet.TabIndex = 28;
            this.txtStreet.Text = "Munster Technology Universaty";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(25, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Street";
            // 
            // txtBuilding
            // 
            this.txtBuilding.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBuilding.Location = new System.Drawing.Point(220, 235);
            this.txtBuilding.MaxLength = 30;
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(243, 30);
            this.txtBuilding.TabIndex = 26;
            this.txtBuilding.Text = "North Campus";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(25, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Building";
            // 
            // grpClientInformation
            // 
            this.grpClientInformation.Controls.Add(this.txtContactPerson);
            this.grpClientInformation.Controls.Add(this.label12);
            this.grpClientInformation.Controls.Add(this.cmbStatus);
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
            this.grpClientInformation.Location = new System.Drawing.Point(484, 134);
            this.grpClientInformation.Name = "grpClientInformation";
            this.grpClientInformation.Size = new System.Drawing.Size(478, 526);
            this.grpClientInformation.TabIndex = 36;
            this.grpClientInformation.TabStop = false;
            this.grpClientInformation.Text = "Client information";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtContactPerson.Location = new System.Drawing.Point(221, 106);
            this.txtContactPerson.MaxLength = 50;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(243, 29);
            this.txtContactPerson.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(26, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 24);
            this.label12.TabIndex = 38;
            this.label12.Text = "Contact Person";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "A-Active",
            "D-Deleted"});
            this.cmbStatus.Location = new System.Drawing.Point(220, 474);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(218, 33);
            this.cmbStatus.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(28, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Status";
            // 
            // grdClients
            // 
            this.grdClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClients.Location = new System.Drawing.Point(31, 139);
            this.grdClients.Name = "grdClients";
            this.grdClients.RowHeadersWidth = 51;
            this.grdClients.Size = new System.Drawing.Size(435, 521);
            this.grdClients.TabIndex = 37;
            this.grdClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClients_CellClick);
            // 
            // frmUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(995, 738);
            this.Controls.Add(this.grdClients);
            this.Controls.Add(this.grpClientInformation);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUpdateClient";
            this.Text = "EventCompanySYS[Update Client]";
            this.Load += new System.EventHandler(this.frmUpdateClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpClientInformation.ResumeLayout(false);
            this.grpClientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelNumber;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.GroupBox grpClientInformation;
        private System.Windows.Forms.DataGridView grdClients;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label12;
    }
}