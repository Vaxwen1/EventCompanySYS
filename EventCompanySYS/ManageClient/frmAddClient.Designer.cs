namespace EventCompanySYS
{
    partial class frmAddClient
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtTelNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBuilding = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btm_Confirm = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.grpClientRegistration = new System.Windows.Forms.GroupBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpClientRegistration.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(810, 29);
            this.menuStrip1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(289, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Organization name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone number";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Email.Location = new System.Drawing.Point(21, 153);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(60, 25);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(21, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Building";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtClientName.Location = new System.Drawing.Point(216, 20);
            this.txtClientName.MaxLength = 50;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(243, 30);
            this.txtClientName.TabIndex = 6;
            // 
            // txtTelNumber
            // 
            this.txtTelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTelNumber.Location = new System.Drawing.Point(216, 106);
            this.txtTelNumber.MaxLength = 13;
            this.txtTelNumber.Name = "txtTelNumber";
            this.txtTelNumber.Size = new System.Drawing.Size(243, 30);
            this.txtTelNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEmail.Location = new System.Drawing.Point(216, 150);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // txtBuilding
            // 
            this.txtBuilding.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBuilding.Location = new System.Drawing.Point(216, 194);
            this.txtBuilding.MaxLength = 30;
            this.txtBuilding.Name = "txtBuilding";
            this.txtBuilding.Size = new System.Drawing.Size(243, 30);
            this.txtBuilding.TabIndex = 9;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Reset.Location = new System.Drawing.Point(246, 540);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(141, 34);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btm_Confirm
            // 
            this.btm_Confirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btm_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btm_Confirm.Location = new System.Drawing.Point(431, 540);
            this.btm_Confirm.Name = "btm_Confirm";
            this.btm_Confirm.Size = new System.Drawing.Size(141, 34);
            this.btm_Confirm.TabIndex = 11;
            this.btm_Confirm.TabStop = false;
            this.btm_Confirm.Text = "Confirm";
            this.btm_Confirm.UseVisualStyleBackColor = false;
            this.btm_Confirm.Click += new System.EventHandler(this.btm_Confirm_Click);
            // 
            // txtStreet
            // 
            this.txtStreet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtStreet.Location = new System.Drawing.Point(216, 242);
            this.txtStreet.MaxLength = 30;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(243, 30);
            this.txtStreet.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(21, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Street";
            // 
            // txtCity
            // 
            this.txtCity.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtCity.Location = new System.Drawing.Point(216, 292);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(243, 30);
            this.txtCity.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(21, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(21, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "County";
            // 
            // cmbCounty
            // 
            this.cmbCounty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(216, 343);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(242, 33);
            this.cmbCounty.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(21, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Eircode";
            // 
            // txtEircode
            // 
            this.txtEircode.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtEircode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtEircode.Location = new System.Drawing.Point(216, 393);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(98, 30);
            this.txtEircode.TabIndex = 19;
            // 
            // grpClientRegistration
            // 
            this.grpClientRegistration.BackColor = System.Drawing.Color.Lavender;
            this.grpClientRegistration.Controls.Add(this.txtContactPerson);
            this.grpClientRegistration.Controls.Add(this.label9);
            this.grpClientRegistration.Controls.Add(this.txtEircode);
            this.grpClientRegistration.Controls.Add(this.label8);
            this.grpClientRegistration.Controls.Add(this.cmbCounty);
            this.grpClientRegistration.Controls.Add(this.label7);
            this.grpClientRegistration.Controls.Add(this.txtCity);
            this.grpClientRegistration.Controls.Add(this.label6);
            this.grpClientRegistration.Controls.Add(this.txtStreet);
            this.grpClientRegistration.Controls.Add(this.label4);
            this.grpClientRegistration.Controls.Add(this.txtBuilding);
            this.grpClientRegistration.Controls.Add(this.txtEmail);
            this.grpClientRegistration.Controls.Add(this.txtTelNumber);
            this.grpClientRegistration.Controls.Add(this.txtClientName);
            this.grpClientRegistration.Controls.Add(this.label5);
            this.grpClientRegistration.Controls.Add(this.Email);
            this.grpClientRegistration.Controls.Add(this.label3);
            this.grpClientRegistration.Controls.Add(this.label2);
            this.grpClientRegistration.Location = new System.Drawing.Point(130, 89);
            this.grpClientRegistration.Name = "grpClientRegistration";
            this.grpClientRegistration.Size = new System.Drawing.Size(513, 445);
            this.grpClientRegistration.TabIndex = 20;
            this.grpClientRegistration.TabStop = false;
            this.grpClientRegistration.Text = "Client Registration";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtContactPerson.Location = new System.Drawing.Point(216, 64);
            this.txtContactPerson.MaxLength = 50;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(243, 30);
            this.txtContactPerson.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(21, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Contact Person";
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(810, 638);
            this.Controls.Add(this.grpClientRegistration);
            this.Controls.Add(this.btm_Confirm);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddClient";
            this.Text = "Add Client[EventCompanySYS]";
            this.Load += new System.EventHandler(this.frmAddClient_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpClientRegistration.ResumeLayout(false);
            this.grpClientRegistration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtTelNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBuilding;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btm_Confirm;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.GroupBox grpClientRegistration;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label9;
    }
}

