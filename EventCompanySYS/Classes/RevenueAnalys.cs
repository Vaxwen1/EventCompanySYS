using EventCompanySYS;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EventCompanySYS.Classes
{
    internal class RevenueAnalys
    {

        public static DataSet getRevenueByEventType(int year)
        {
            // Open a DB connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            // Define the SQL query with filtering by year
            string sqlQuery = @"SELECT 
                                    et.Name AS EventType,
                                    SUM(b.Price) AS TotalRevenue
                                FROM Bookings b
                                JOIN Events e ON b.EventID = e.EventID
                                JOIN EventTypes et ON e.EventTypeID = et.TypeID
                                WHERE b.Status = 'A'
                                AND EXTRACT(YEAR FROM e.EventDate) = :year
                                GROUP BY et.Name
                                ORDER BY TotalRevenue DESC";

            // Use OracleCommand with parameter
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter("year", year));

            // Fill the dataset
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "RevenueByEventType");

            // Close the DB connection
            conn.Close();

            return ds;
        }

        public static DataSet getRevenueByEarnings(int year)
        {
            // Open a DB connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            // Define the SQL query with filtering by year
            string sqlQuery = @"SELECT 
                                    TO_CHAR(e.EventDate, 'Month') AS Month,
                                    SUM(b.Price) AS TotalRevenue
                                FROM Bookings b
                                JOIN Events e ON b.EventID = e.EventID
                                WHERE b.Status = 'A' 
                                    AND EXTRACT(YEAR FROM e.EventDate) = :year
                                GROUP BY TO_CHAR(e.EventDate, 'Month'), EXTRACT(MONTH FROM e.EventDate)
                                ORDER BY EXTRACT(MONTH FROM e.EventDate)";

            // Use OracleCommand with parameter
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            cmd.Parameters.Add(new OracleParameter("year", year));

            // Fill the dataset
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "RevenueByMonth");

            // Close the DB connection
            conn.Close();

            return ds;
        }




    }


}




