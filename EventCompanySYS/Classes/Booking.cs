using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventCompanySYS
{
    class Booking
    {
        private int bookingID;
        private int eventID;
        private string email;
        private int numberOfTickets;
        private double price;
        private char status;
        private DateTime createdDate;
        private DateTime updatedDate;


        public Booking(int eventID, string email, int numberOfTickets, double price)
        {
            setBookingID(getNextBookingID());
            setEventID(eventID);
            setEmail(email);
            setNumberOfTickets(numberOfTickets);
            setPrice(price);
            setStatus('A');
        }
        public Booking()
        {
            setBookingID(0);
            setEventID(0);
            setEmail(string.Empty);
            setNumberOfTickets(0);
            setPrice(0.0);
            setStatus('A');
            setCreatedDate(DateTime.Now);
            setUpdatedDate(DateTime.Now);
        }

        //Setters
        public void setBookingID(int bookingID) { this.bookingID = bookingID; }
        public void setEventID(int eventID) { this.eventID = eventID; }
        public void setEmail(string email) { this.email = email; }
        public void setCreatedDate(DateTime createdDate) { this.createdDate = createdDate; }
        public void setUpdatedDate(DateTime updatedDate) { this.updatedDate = updatedDate; }
        public void setNumberOfTickets(int numberOfTickets) { this.numberOfTickets = numberOfTickets; }
        public void setPrice(double price) { this.price = price; }
        public void setStatus(char status) { this.status = status; }

        //Getters
        public int getBookingID() { return bookingID; }
        public int getEventID() { return eventID; }
        public string getEmail() { return email; }
        public DateTime getCreatedDate() { return this.createdDate; }
        public DateTime getUpdatedDate() { return this.updatedDate; }
        public int getNumberOfTikets() { return numberOfTickets; }
        public double getPrice() { return price; }
        public char getStatus() { return status; }

        public static DataSet getBookings()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Bookings ORDER BY BookingID";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "allBookings");

            //Close db connection
            conn.Close();

            return ds;

        }

        public void addBooking()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Bookings Values (" +
                this.bookingID + ",'" +
                this.email + "'," +
                this.eventID + "," +
                this.numberOfTickets + "," +
                this.price + ",'" +
                this.status +"'," +
                "SYSTIMESTAMP," +
                "SYSTIMESTAMP)";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }

        public static int getNextBookingID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(BookingID) FROM Bookings";

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

        public void updateBooking()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            string sqlQuery = "UPDATE Bookings SET " +
            "Email = '" + this.email + "', " +
            "EventID = " + this.eventID + ", " +
            "NumberOfTickets = " + this.numberOfTickets + ", " +
            "Price = " + this.price + ", " +
            "Status = '" + this.status + "', " +
            "UpdatedDate = CURRENT_TIMESTAMP " +
            "WHERE BookingID = " + this.bookingID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public static DataSet findBooking(String bookingID)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Bookings " +
                "WHERE bookingID LIKE '%" + bookingID + "%' ORDER BY bookingID";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "booking");

            //Close db connection
            conn.Close();

            return ds;
        }


        public void removeBooking(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "DELETE FROM Bookings WHERE BookingID = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void getBooking(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Bookings WHERE BOOKINGID = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setBookingID(dr.GetInt32(0));
            setEmail(dr.GetString(1));
            setEventID(dr.GetInt32(2));
            setNumberOfTickets(dr.GetInt32(3));
            setPrice(dr.GetInt32(4));
            setStatus(char.Parse(dr.GetString(5)));
            setCreatedDate(dr.GetDateTime(6));
            setUpdatedDate(dr.GetDateTime(7));
            
            //close DB
            conn.Close();
        }
         
    }
}
