using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCompanySYS
{
    internal class Event
    {
        private int eventID;
        public string eventName;
        public string eventType;
        public string description;
        public DateTime date;
        public string startTime;
        public int duration;
        public int numberOfTickets;
        public int avaliableTickets;
        public float ticketPrice;
        public char status;


        //constractor
        public Event(string eventName, string eventType, string description, DateTime date, string startTime, int duration, int numberOfTickets, int avaliableTickets, float ticketPrice)
        {
            this.eventName = eventName;
            this.eventType = eventType;
            this.description = description;
            this.date = date;
            this.startTime = startTime;
            this.duration = duration;
            this.numberOfTickets = numberOfTickets;
            this.avaliableTickets = avaliableTickets;
            this.ticketPrice = ticketPrice;
        }

        //setters

        public void setEventID(int eventID) 
        {
            this.eventID = getNextEventID();
        }
        public void setEventName(string eventName) 
        {
            this.eventName = eventName;
        }
        public void setEventType(string eventType)
        {
            this.eventType = eventType;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public void setDate(DateTime date) 
        {
            this.date = date;
        }
        public void setStartTime(string startTime)
        {
            this.startTime = startTime;
        }
        public void setDuration(int duration)
        {
            this.duration = duration;
        }
        public void setNumberOfTickets(int numberOfTickets)
        {
            this.numberOfTickets = numberOfTickets;
        }
        public void setAvaliableTickets(int avaliableTickets)
        {
            this.avaliableTickets=avaliableTickets;
        }
        public void setPrice(float ticketPrice)
        {
            this.ticketPrice = ticketPrice;
        }
        public void setStatus() 
        {
            this.status = 'A';
        }

        //getters
        public int getEevntID()
        {
            return this.eventID;
        }

        public string getEventName()
        {
            return this.eventName;
        }
        public string getEventType()
        {
            return this.eventType;
        }
        public string getDescription()
        {
            return this.description;
        }
        public DateTime getDate()
        {
            return this.date;
        }
        public int getEevntID()
        {
            return this.eventID;
        }
        public int getEevntID()
        {
            return this.eventID;
        }
        public int getEevntID()
        {
            return this.eventID;
        }
        public int getEevntID()
        {
            return this.eventID;
        }
        public int getEevntID()
        {
            return this.eventID;
        }


        public static DataSet getEvents()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Events ORDER BY EventID";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "event");

            //Close db connection
            conn.Close();

            return ds;

        }

        public void addEvent()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Events Values (" +
                this.eventID + ",'" +
                this.eventName + "','" +
                this.eventType + "','" +
                this.description + "','" +
                this.date + "'," +
                this.startTime + "," +
                this.duration + ",'" +
                this.numberOfTickets + ",'" +
                this.avaliableTickets + ",'" +
                this.ticketPrice + ",'" +
                this.status + "')";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void updateEvent()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Products SET " +
                "EventID = " + this.eventID + "," +
                "Name = '" + this.eventName + "'," +
                "EventType = '" + this.eventType + "'," +
                "Description = '" + this.description + "'," +
                "Date = '" + this.date + "'," +
                "StartTime = " + this.startTime + "," +
                "Duration = " + this.duration + "," +
                "NumberOFTickets = '" + this.numberOfTickets + "' " +
                "AvaliableTickets = '" + this.avaliableTickets + "' " +
                "TicketPrice = '" + this.ticketPrice + "' " +
                "Status = '" + this.status + "' " +
                "WHERE ProductId = " + this.eventID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public static int getNextEventID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(EventID) FROM Events";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            //Does dr contain a value or NULL?
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

        public static DataSet findEvent(String prodName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT , Name, Manufacturer FROM Products " +
                "WHERE Name LIKE '%" + prodName + "%' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "prod");

            //Close db connection
            conn.Close();

            return ds;
        }


    }
}
