using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCompanySYS
{
    internal class County
    {
        string name;

        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }

        County() 
        {
            setName("Null");
        }

        public static DataSet getCounties() 
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Counties ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "County");

            //Close db connection
            conn.Close();

            return ds;
        }

    }
}
