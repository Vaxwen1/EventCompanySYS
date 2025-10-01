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
    internal class Performer
    {
        private int performerID;
        private string performerName;
        private string description;
        private string contactPerson;
        private string contactPhone;
        private string email;
        private double pricePerDay;
        private char status;
        private DateTime createDate;
        private DateTime updatedDate;
        

        public Performer(int performerID, string performerName, string description, string contactPerson, string contactPhone, string email, double pricePerDay, DateTime createDate, DateTime updatedDate)
        {
            setPerformerID(performerID);
            setPerformerName(performerName);
            setDescription(description);
            setContactPerson(contactPerson);
            setContactPhone(contactPhone);
            setEmail(email);
            setPricePerDay(pricePerDay);
            setStatus(status);  
            setCreateDate(createDate);
            setUpdatedDate(updatedDate);
        }

        public Performer(string performerName, string description, string contactPerson, string contactPhone, string email, double pricePerDay)
        {
            setPerformerID(getNextPerformerID());
            setPerformerName(performerName);
            setDescription(description);
            setContactPerson(contactPerson);
            setContactPhone(contactPhone);
            setEmail(email);
            setPricePerDay(pricePerDay);
            setStatus('A');
        }

        public Performer()
        {
            setPerformerID(0);
            setPerformerName("Unknown");
            setDescription("No description");
            setContactPerson("Unknown");
            setContactPhone("Unknown");
            setEmail("Unknown");
            setPricePerDay(0.0);
            setStatus('A');
            setCreateDate(DateTime.Now);
            setUpdatedDate(DateTime.Now);
        }

        public void setPerformerID(int performerID) 
        {
            this.performerID = performerID;
        }
        public void setPerformerName(string performerName)
        {
            this.performerName = performerName;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public void setContactPerson(string contactPerson)
        {
            this.contactPerson = contactPerson;
        }
        public void setContactPhone(string contactPhone)
        {
            this.contactPhone = contactPhone;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setPricePerDay(double pricePerDay)
        {
            this.pricePerDay = pricePerDay;
        }
        public void setStatus(char status)
        {
            this.status = status;
        }
        public void setCreateDate(DateTime createDate)
        {
            this.createDate = createDate;
        }
        public void setUpdatedDate(DateTime updatedTime)
        {
            this.updatedDate = updatedTime;
        }
        public int getPerformerID()
        {
            return performerID;
        }

        public string getPerformerName()
        {
            return performerName;
        }

        public string getDescription()
        {
            return description;
        }

        public string getContactPerson()
        {
            return contactPerson;
        }

        public string getContactPhone()
        {
            return contactPhone;
        }

        public string getEmail()
        {
            return email;
        }

        public double getPricePerDay()
        {
            return pricePerDay;
        }

        public char getStatus()
        {
            return status;
        }

        public DateTime getCreateDate()
        {
            return createDate;
        }

        public DateTime getUpdatedDate()
        {
            return this.updatedDate;
        }

        public static int getNextPerformerID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(PerformerID) FROM Performers";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            //Close db connection
            conn.Close();

            return nextId;
        }

        public static DataSet getAvaliablePerformers(DateTime date)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            string sqlQuery = "SELECT PerformerID, Name, Description, PricePerDay " +
                          "FROM Performers " +
                          "WHERE PerformerID NOT IN (" +
                              "SELECT PerformerID FROM Events " +
                              "WHERE TRUNC(EventDate) = :eventDate" +
                          ")";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(new OracleParameter("eventDate", date.Date));

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "avaliablePerformers");

            //Close db connection
            conn.Close();

            return ds;

        }

       

        public static DataSet getAllPerformers()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuerry = "SELECT * " +
            "FROM Performers ORDER BY PerformerID";

            OracleCommand cmd = new OracleCommand(sqlQuerry, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "allPerformers");

            conn.Close();

            return ds;

        }

        public void getPerformer(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Performers WHERE PerformerID = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setPerformerID(dr.GetInt32(0));
            setPerformerName(dr.GetString(1));
            setDescription(dr.GetString(2));
            setContactPerson(dr.GetString(3));
            setContactPhone(dr.GetString(4));
            setEmail(dr.GetString(5));
            setPricePerDay(dr.GetDouble(6));
            setStatus(char.Parse(dr.GetString(7)));
            setCreateDate(dr.GetDateTime(8));
            setUpdatedDate(dr.GetDateTime(9));

            //close DB
            conn.Close();
        }

        public static int getPerformerIDByName(string name)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT PerformerID FROM Performers WHERE Name = '" + name +"'";

            //Execute the SQL query
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            int performerID = -1;

            if (dr.Read())
            {
                performerID = dr.GetInt32(0);
            }

            //Close db connection
            conn.Close();

            return performerID;
        }




    }
}
