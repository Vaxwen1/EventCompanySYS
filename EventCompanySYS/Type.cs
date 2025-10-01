using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCompanySYS
{
    internal class Type
    {
        String typeCode;
        String meaning;

        public Type(string typeCode, string meaning)
        {
            this.typeCode = typeCode;
            this.meaning = meaning;
        }

        public static DataSet getTypes()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Types ORDER BY TypeCode";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "types");

            //Close db connection
            conn.Close();

            return ds;

        }
    }
}
