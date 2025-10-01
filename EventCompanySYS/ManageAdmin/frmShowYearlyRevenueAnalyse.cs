using EventCompanySYS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EventCompanySYS.ManageAdmin
{
    public partial class frmShowYearlyRevenueAnalyse : Form
    {
        frmMainMenu parent;
        public frmShowYearlyRevenueAnalyse(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
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

        private void frmShowYearlyRevenueAnalyse_Load(object sender, EventArgs e)
        {
            loadYears();
        }
        // Source: "How to create Chart/Graph in C#" by Tan Lee, FoxLearn (Mar 30, 2019)
        // https://foxlearn.com/windows-forms/chart-graph-in-csharp-257.html
        // This tutorial demonstrates binding database-derived data and static data to the Chart control
        // using the System.Windows.Forms.DataVisualization.Charting
        public void writeRevenueOverTimeToRichTextBox(DataTable dt)
        {
            rtxtEarningAnalysis.Clear(); 
            rtxtEarningAnalysis.AppendText("Revenue Analysis Over Time\n");
            rtxtEarningAnalysis.AppendText("----------------------------------\n");

            foreach (DataRow row in dt.Rows)
            {
                string timePeriod = row.Table.Columns.Contains("Month")
                                    ? "Month: " + row["Month"].ToString()
                                    : "Year: " + row["Year"].ToString();

                decimal totalRevenue = Convert.ToDecimal(row["TotalRevenue"]);

                rtxtEarningAnalysis.AppendText($"{timePeriod}\n");
                rtxtEarningAnalysis.AppendText($"Total Revenue: {totalRevenue:C}\n");
                rtxtEarningAnalysis.AppendText("\n");
            }

            rtxtEarningAnalysis.AppendText("End of Report");
        }



        public void showRevenueOverTimeChart()
        {
            int year = Int32.Parse(cmbYear.SelectedItem.ToString());

            
            DataTable dt = RevenueAnalys.getRevenueByEarnings(year).Tables["RevenueByMonth"];
            dgvEarningAnalys.DataSource = dt;

            
            chartEarningAnalys.Series.Clear();
            chartEarningAnalys.ChartAreas.Clear();
            chartEarningAnalys.Titles.Clear();

            
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Month";
            chartArea.AxisY.Title = "Total Revenue";
            chartArea.AxisX.Interval = 1;
            chartEarningAnalys.ChartAreas.Add(chartArea);

            
            Series series = new Series("Monthly Revenue");
            series.ChartType = SeriesChartType.Column;
            series.XValueMember = "Month";             
            series.YValueMembers = "TotalRevenue";     
            series.IsValueShownAsLabel = true;
            chartEarningAnalys.Series.Add(series);

            
            chartEarningAnalys.DataSource = dt;
            chartEarningAnalys.DataBind();

            
            chartEarningAnalys.Titles.Add($"Total Revenue by Month ({year})");

            
            writeRevenueOverTimeToRichTextBox(dt);
        }


        public void loadYears()
        {
            int year = DateTime.Now.Year;
            for (int i = 0; i < 3; i++)
            {
                cmbYear.Items.Add(year.ToString());
                year--;
            }
            cmbYear.Items.RemoveAt(0);
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbYear.Text))
            {
                MessageBox.Show("The year must be selected",
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                cmbYear.Focus();
                return;
            }
            showRevenueOverTimeChart();
            grpYearlyRevenueAnalys.Visible = true;
        }
    }
}
