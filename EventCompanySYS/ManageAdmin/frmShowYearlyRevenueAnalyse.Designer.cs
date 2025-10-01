namespace EventCompanySYS.ManageAdmin
{
    partial class frmShowYearlyRevenueAnalyse
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpYearlyRevenueAnalys = new System.Windows.Forms.GroupBox();
            this.chartEarningAnalys = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvEarningAnalys = new System.Windows.Forms.DataGridView();
            this.rtxtEarningAnalysis = new System.Windows.Forms.RichTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpYearlyRevenueAnalys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEarningAnalys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEarningAnalys)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1205, 24);
            this.menuStrip1.TabIndex = 43;
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpYearlyRevenueAnalys
            // 
            this.grpYearlyRevenueAnalys.Controls.Add(this.chartEarningAnalys);
            this.grpYearlyRevenueAnalys.Controls.Add(this.dgvEarningAnalys);
            this.grpYearlyRevenueAnalys.Controls.Add(this.rtxtEarningAnalysis);
            this.grpYearlyRevenueAnalys.Location = new System.Drawing.Point(223, 100);
            this.grpYearlyRevenueAnalys.Name = "grpYearlyRevenueAnalys";
            this.grpYearlyRevenueAnalys.Size = new System.Drawing.Size(929, 377);
            this.grpYearlyRevenueAnalys.TabIndex = 48;
            this.grpYearlyRevenueAnalys.TabStop = false;
            this.grpYearlyRevenueAnalys.Text = "Event Type Analys";
            this.grpYearlyRevenueAnalys.Visible = false;
            // 
            // chartEarningAnalys
            // 
            chartArea2.Name = "ChartArea1";
            this.chartEarningAnalys.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEarningAnalys.Legends.Add(legend2);
            this.chartEarningAnalys.Location = new System.Drawing.Point(523, 49);
            this.chartEarningAnalys.Name = "chartEarningAnalys";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartEarningAnalys.Series.Add(series2);
            this.chartEarningAnalys.Size = new System.Drawing.Size(365, 291);
            this.chartEarningAnalys.TabIndex = 2;
            this.chartEarningAnalys.Text = "chart1";
            // 
            // dgvEarningAnalys
            // 
            this.dgvEarningAnalys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEarningAnalys.Location = new System.Drawing.Point(24, 172);
            this.dgvEarningAnalys.Name = "dgvEarningAnalys";
            this.dgvEarningAnalys.Size = new System.Drawing.Size(418, 150);
            this.dgvEarningAnalys.TabIndex = 1;
            // 
            // rtxtEarningAnalysis
            // 
            this.rtxtEarningAnalysis.Location = new System.Drawing.Point(24, 25);
            this.rtxtEarningAnalysis.Name = "rtxtEarningAnalysis";
            this.rtxtEarningAnalysis.Size = new System.Drawing.Size(418, 126);
            this.rtxtEarningAnalysis.TabIndex = 0;
            this.rtxtEarningAnalysis.Text = "";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnShow.Location = new System.Drawing.Point(59, 268);
            this.btnShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(124, 34);
            this.btnShow.TabIndex = 47;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // cmbYear
            // 
            this.cmbYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(65, 184);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(98, 33);
            this.cmbYear.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(61, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Choose year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(434, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Show Yearly Revenue Analys";
            // 
            // frmShowYearlyRevenueAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1205, 500);
            this.Controls.Add(this.grpYearlyRevenueAnalys);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmShowYearlyRevenueAnalyse";
            this.Text = "frmYearlyRevenueAnalyse";
            this.Load += new System.EventHandler(this.frmShowYearlyRevenueAnalyse_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpYearlyRevenueAnalys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEarningAnalys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEarningAnalys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpYearlyRevenueAnalys;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEarningAnalys;
        private System.Windows.Forms.DataGridView dgvEarningAnalys;
        private System.Windows.Forms.RichTextBox rtxtEarningAnalysis;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}