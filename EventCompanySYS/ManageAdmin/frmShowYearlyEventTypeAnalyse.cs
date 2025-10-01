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
    public partial class frmShowYearlyEventTypeAnalyse : Form
    {
        frmMainMenu parent;
        public frmShowYearlyEventTypeAnalyse(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
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
            showTypeAnalysChat();
            grpEventTypeAnalys.Visible = true;
        }

        // Source: "How to create Chart/Graph in C#" by Tan Lee, FoxLearn (Mar 30, 2019)
        // https://foxlearn.com/windows-forms/chart-graph-in-csharp-257.html
        // This tutorial demonstrates binding database-derived data and static data to the Chart control
        // using the System.Windows.Forms.DataVisualization.Charting


        public void showTypeAnalysChat()
        {

            int year = Int32.Parse(cmbYear.SelectedItem.ToString());

            
            DataTable dt = RevenueAnalys.getRevenueByEventType(year).Tables["RevenueByEventType"];
            dgvTypeAnalys.DataSource = dt;


           
            chartEventTypeRevenue.Series.Clear();
            chartEventTypeRevenue.ChartAreas.Clear();
            chartEventTypeRevenue.Titles.Clear();

            
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Event Type";
            chartArea.AxisY.Title = "Total Revenue";
            chartArea.AxisX.Interval = 1;
            chartEventTypeRevenue.ChartAreas.Add(chartArea);

            
            Series series = new Series("Revenue");
            series.ChartType = SeriesChartType.Column;
            series.XValueMember = "EventType";
            series.YValueMembers = "TotalRevenue";
            series.IsValueShownAsLabel = true;
            chartEventTypeRevenue.Series.Add(series);

            
            chartEventTypeRevenue.DataSource = dt;
            chartEventTypeRevenue.DataBind();

            
            chartEventTypeRevenue.Titles.Add($"Total Revenue by Event Type ({year})");
            writeRevenueEventTypeAnalysisToRichTextBox(dt);
        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmShowYearlyEventTypeAnalyse_Load(object sender, EventArgs e)
        {
            loadYears();
        }

        public void writeRevenueEventTypeAnalysisToRichTextBox(DataTable dt)
        {
            rtxtTypeAnalysis.Clear();
            rtxtTypeAnalysis.AppendText("Revenue Analysis by Event Type\n");
            rtxtTypeAnalysis.AppendText("----------------------------------\n");

            foreach (DataRow row in dt.Rows)
            {
                string eventType = row["EventType"].ToString();
                decimal totalRevenue = Convert.ToDecimal(row["TotalRevenue"]);

                rtxtTypeAnalysis.AppendText($"Event Type: {eventType}\n");
                rtxtTypeAnalysis.AppendText($"Total Revenue: {totalRevenue:C}\n");
                rtxtTypeAnalysis.AppendText("\n");
            }

            rtxtTypeAnalysis.AppendText("End of Report");
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

    }
}
