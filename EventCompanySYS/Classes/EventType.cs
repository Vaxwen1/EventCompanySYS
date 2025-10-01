using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCompanySYS.Classes
{
    internal class EventType
    {
        String typeCode;
        String meaning;

        //Constructor
        public EventType(string typeCode, string meaning)
        {
            setTypeCode(typeCode);
            setMeaning(meaning);
        }

        public EventType()
        {
            setTypeCode("Unknown");
            setMeaning("No description available");
        }

        //setters

        public void setTypeCode(string typeCode) 
        {
            this.typeCode = typeCode;
        }
        public void setMeaning(string meaning) 
        {
            this.meaning = meaning;
        }

        //getters
        public string getTypeCode()
        {
            return this.typeCode;
        }
        public String getMeaning()
        {
            return this.meaning;
        }


        public static DataSet getTypes()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM EventTypes ORDER BY TypeID";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "types");

            //Close db connection
            conn.Close();

            return ds;

        }

        public static string getTypeMeaning(string typeId) 
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT Name FROM EventTypes WHERE TypeID = '" + typeId +"'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "typeMeaning");

            //Close db connection
            conn.Close();

            return ds.Tables[0].Rows[0][0].ToString();
        }

        public static string getTypeIDByName(string name)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT TypeID FROM EventTypes WHERE Name = '" + name + "'";

            //Execute the SQL query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            string performerID = "";

            if (dr.Read())
            {
                performerID = dr.GetString(0);
            }

            //Close db connection
            conn.Close();

            return performerID;
        }

    }
}
