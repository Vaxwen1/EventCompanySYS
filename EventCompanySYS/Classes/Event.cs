using EventCompanySYS.Classes;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventCompanySYS.ManageClient
{
    internal class Event
    {
        private int eventID;
        private string eventName;
        private string eventType;
        private int clientID;
        private string description;
        private string date;
        private string startTime;
        private int venueID;
        private int performerID;
        private int duration;
        private int numberOfTickets;
        private int avaliableTickets;
        private double ticketPrice;
        private char status;


        //constractor
        public Event(int id, string eventName, string eventType, int clientID, string description, int venueID, string date, int performerID, string startTime, int duration, int numberOfTickets, int avaliableTickets, float ticketPrice)
        {
            setEventID(id);
            setEventName(eventName);
            setEventType(eventType);
            setClientID(clientID);
            setDescription(description);
            setVenueID(venueID);
            setDate(date);
            setPerformerID(performerID);
            setStartTime(startTime);
            setDuration(duration);
            setNumberOfTickets(numberOfTickets);
            setAvaliableTickets(avaliableTickets);
            setTicketPrice(ticketPrice);
            setStatus('A');
        }

        public Event()
        {
            setEventID(0);
            setEventName("Null");
            setEventType("Null");
            setClientID(0);
            setDescription("Null");
            setDate("Null"); 
            setStartTime("Null");
            setVenueID(0);
            setPerformerID(0);
            setDuration(0);
            setNumberOfTickets(0);
            setAvaliableTickets(0);
            setTicketPrice(0.0);
            setStatus('A');
        }

        //setters
        public void setPerformerID(int performerID)
        {
            this.performerID = performerID;
        }

        public void setEventID(int eventID)
        {
            this.eventID = eventID;
        }
        public void setEventName(string eventName)
        {
            this.eventName = eventName;
        }
        public void setEventType(string eventType)
        {
            this.eventType = eventType;
        }
        public void setClientID(int clientID) 
        {
            this.clientID = clientID;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public void setDate(string date)
        {
            this.date = date;
        }
        public void setVenueID(int venueID)
        {
            this.venueID = venueID;
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
            this.avaliableTickets = avaliableTickets;
        }
        public void setTicketPrice(double ticketPrice)
        {
            this.ticketPrice = ticketPrice;
        }
        public void setStatus(char status)
        {
            this.status = status;
        }

        //getters
        public int getEventID()
        {
            return this.eventID;
        }
        public int getPerformerID() 
        {
            return this.performerID;
        }
        public string getEventName()
        {
            return this.eventName;
        }
        public string getEventType()
        {
            return this.eventType;
        }
        public int getClientID()
        {
            return this.clientID;
        }
        public string getDescription()
        {
            return this.description;
        }
        public string getDate()
        {
            return this.date;
        }
        public string getStatrTime()
        {
            return this.startTime;
        }
        public int getDuration()
        {
            return this.duration;
        }
        public int getVenueID() 
        {
            return this.venueID;
        }
        public int getNumberOFTickets()
        {
            return this.numberOfTickets;
        }
        public int getAvaliableTickets()
        {
            return this.avaliableTickets;
        }
        public double getTiketPrice()
        {
            return this.ticketPrice;
        }
        public float getStatus()
        {
            return this.status;
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
            da.Fill(ds, "events");

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
                this.eventType + "'," +
                this.clientID + ",'" +
                this.description + "'," +
                this.venueID + ", TO_DATE('" +
                this.date + "', 'DD-Mon-YY')," +
                this.performerID + ",'" +
                this.startTime + "'," +
                this.duration + "," +
                this.numberOfTickets + "," +
                this.numberOfTickets + "," +
                this.ticketPrice + ",'" +
                this.status + "'," +
                "SYSTIMESTAMP," +
                "SYSTIMESTAMP)";

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
            String sqlQuery = "UPDATE Events SET " +
                "Name = '" + this.eventName + "', " +
                "EventTypeID = '" + this.eventType + "', " +
                "ClientID = " + this.clientID + ", " +
                "Description = '" + this.description + "', " +
                "VenueID = " + this.venueID + ", " +
                "EventDate = '" + this.date + "', " +
                "PerformerID = " + this.performerID + ", " +
                "StartTime = '" + this.startTime + "', " +
                "Duration = " + this.duration + ", " +
                "NumberOfTickets = " + this.numberOfTickets + ", " +
                "AvailableTickets = " + this.avaliableTickets + ", " +
                "TicketPrice = " + this.ticketPrice + ", " +
                "Status = '" + this.status + "', " +
                "UpdatedDate = CURRENT_TIMESTAMP " +
                "WHERE EventID = " + this.eventID;


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

        public static DataSet findEvent(String eventName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Events " +
                "WHERE LOWER(Name) LIKE LOWER('%" + eventName + "%') ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "event");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet FindAvaliableNextEvents(String eventName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            string sqlQuery = "SELECT * FROM Events " +
                       "WHERE Status = 'A' " +
                       "AND EventDate >= TRUNC(SYSDATE)";

            if (!string.IsNullOrEmpty(eventName))
            {
                sqlQuery += " AND LOWER(Name) LIKE LOWER('%" + eventName + "%')";
            }
            sqlQuery += " ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "avaliableEventsByDateAndName");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet findEventByDate(String eventName, string eventDate)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            string sqlQuery = "SELECT * FROM Events " +
                "WHERE Name LIKE '%" + eventName + "' " +
                "AND TRUNC(EventDate) = TO_DATE('" + eventDate + "', 'DD-Mon-YY') " +
                "ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "EventsByDate");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet getAllEvents()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuerry = "SELECT * " +
            "FROM Events ORDER BY EventID";

            OracleCommand cmd = new OracleCommand(sqlQuerry, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "allEvents");

            conn.Close();

            return ds;

        }
        public static void AdjustedTickets(int avaliableTickets, int numberOfTickets, string eventName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Events SET " +
                "AVAILABLETICKETS = " + (avaliableTickets - numberOfTickets) + "," +
                "UPDATEDDATE = SYSTIMESTAMP " +
                "WHERE Name = '" + eventName + "'";



            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void restockTickets(int numberOfTickets)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Events SET " +
                "AVAILABLETICKETS = " + (this.avaliableTickets + numberOfTickets) + ", " +
                "UPDATEDDATE = SYSTIMESTAMP " +
                "WHERE EventID = '" + this.eventID.ToString() + "'";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public void getEventAvaliableForChanging(DateTime currentEventDate)
        {

        }

        public void getEvent(int id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Events WHERE EVENTID = " + id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setEventID(dr.GetInt32(0));
            setEventName(dr.GetString(1));
            setEventType(dr.GetString(2));
            setClientID(dr.GetInt32(3));
            setDescription(dr.GetString(4));
            setVenueID(dr.GetInt32(5));
            setDate(dr.GetString(6));
            setPerformerID(dr.GetInt32(7));
            setStartTime(dr.GetString(8));
            setDuration(dr.GetInt32(9));
            setNumberOfTickets(dr.GetInt32(10));
            setAvaliableTickets(dr.GetInt32(11));
            setTicketPrice(dr.GetFloat(12));
            setStatus(dr.GetString(13)[0]);

            //close DB
            conn.Close();
        }
        public bool removeEvent(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "DELETE FROM Events WHERE EventID = " + Id;

            //Execute the SQL query (OracleCommand)
            try
            {
                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("The Event cannot be deleted. EventID used in other tables",
                     "Error",
                      MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return false;

            }
            return true;
        }



    }
}
