namespace EventCompanySYS.ManageAdmin
{
    partial class frmShowYearlyEventTypeAnalyse
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnShow = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpEventTypeAnalys = new System.Windows.Forms.GroupBox();
            this.chartEventTypeRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTypeAnalys = new System.Windows.Forms.DataGridView();
            this.rtxtTypeAnalysis = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.grpEventTypeAnalys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEventTypeRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeAnalys)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnShow.Location = new System.Drawing.Point(63, 269);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(124, 34);
            this.btnShow.TabIndex = 32;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(69, 185);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(98, 33);
            this.cmbYear.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(65, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Choose year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(438, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Show Event Type Analys";
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
            this.menuStrip1.Size = new System.Drawing.Size(1205, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // grpEventTypeAnalys
            // 
            this.grpEventTypeAnalys.Controls.Add(this.chartEventTypeRevenue);
            this.grpEventTypeAnalys.Controls.Add(this.dgvTypeAnalys);
            this.grpEventTypeAnalys.Controls.Add(this.rtxtTypeAnalysis);
            this.grpEventTypeAnalys.Location = new System.Drawing.Point(227, 101);
            this.grpEventTypeAnalys.Name = "grpEventTypeAnalys";
            this.grpEventTypeAnalys.Size = new System.Drawing.Size(929, 377);
            this.grpEventTypeAnalys.TabIndex = 36;
            this.grpEventTypeAnalys.TabStop = false;
            this.grpEventTypeAnalys.Text = "Event Type Analys";
            this.grpEventTypeAnalys.Visible = false;
            // 
            // chartEventTypeRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEventTypeRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEventTypeRevenue.Legends.Add(legend1);
            this.chartEventTypeRevenue.Location = new System.Drawing.Point(523, 49);
            this.chartEventTypeRevenue.Name = "chartEventTypeRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEventTypeRevenue.Series.Add(series1);
            this.chartEventTypeRevenue.Size = new System.Drawing.Size(365, 291);
            this.chartEventTypeRevenue.TabIndex = 2;
            this.chartEventTypeRevenue.Text = "chart1";
            // 
            // dgvTypeAnalys
            // 
            this.dgvTypeAnalys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTypeAnalys.Location = new System.Drawing.Point(24, 172);
            this.dgvTypeAnalys.Name = "dgvTypeAnalys";
            this.dgvTypeAnalys.Size = new System.Drawing.Size(418, 150);
            this.dgvTypeAnalys.TabIndex = 1;
            // 
            // rtxtTypeAnalysis
            // 
            this.rtxtTypeAnalysis.Location = new System.Drawing.Point(24, 25);
            this.rtxtTypeAnalysis.Name = "rtxtTypeAnalysis";
            this.rtxtTypeAnalysis.Size = new System.Drawing.Size(418, 126);
            this.rtxtTypeAnalysis.TabIndex = 0;
            this.rtxtTypeAnalysis.Text = "";
            // 
            // frmShowYearlyEventTypeAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1205, 500);
            this.Controls.Add(this.grpEventTypeAnalys);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmShowYearlyEventTypeAnalyse";
            this.Text = "frmYearlyEventTypeAnalyse";
            this.Load += new System.EventHandler(this.frmShowYearlyEventTypeAnalyse_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpEventTypeAnalys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEventTypeRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTypeAnalys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpEventTypeAnalys;
        private System.Windows.Forms.RichTextBox rtxtTypeAnalysis;
        private System.Windows.Forms.DataGridView dgvTypeAnalys;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEventTypeRevenue;
    }
}