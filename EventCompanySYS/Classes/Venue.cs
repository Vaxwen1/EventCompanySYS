using Microsoft.SqlServer.Server;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCompanySYS
{
    class Venue
    {
        int venueID;
        string name;
        string description;
        string contactPerson;
        string contactNumber;
        int capacity;
        double pricePerDay;
        string building;
        string street;
        string city;
        string county;
        string eircode;
        char status;

        //constractor
        public Venue(string name, string description, string contactPerson, string contactNumber, int capacity, double pricePerDay, string building, string street, string city, string county, string eircode, char status)
        {
            setName(name);
            setDescription(description);
            setContactPerson(contactPerson);
            setContactNumber(contactNumber);
            setCapacity(capacity);
            setBuilding(building);
            setStreet(street);
            setCity(city);
            setCounty(county);
            setEircode(eircode);
            setStatus(status);
        }
        public Venue()
        {
            setVenueID(0);
            setName("Null");
            setDescription("Null");
            setContactPerson("Null");
            setContactNumber("Null");
            setCapacity(0);
            setPricePerDay(0.0);
            setBuilding("Null");
            setStreet("Null");
            setCity("Null");
            setCounty("Null");
            setEircode("Null");
            setStatus('A');
        }

        //Setters
        public void setVenueID(int venueID)
        {
            this.venueID = venueID;
        }

        public void setName(string name) 
        {
            this.name = name;
        }

        public void setPricePerDay(double pricePerDay)
        {
            this.pricePerDay = pricePerDay;
        }
        public void setDescription(string description)
        {
            this.description = description;
        }
        public void setContactPerson(string contactPerson)
        {
            this.contactPerson = contactPerson;
        }

        public void setContactNumber(string contactNumber)
        {
            this.contactNumber = contactNumber;
        }

        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public void setBuilding(string building)
        {
            this.building = building;
        }

        public void setStreet(string street)
        {
            this.street = street;
        }

        public void setCity(string city)
        {
            this.city = city;
        }
        public void setCounty(string county)
        {
            this.county = county;
        }
        public void setEircode(string eircode)
        {
            this.eircode = eircode;
        }
        public void setStatus(char status) 
        {
            this.status = status;
        }

        //Getters
        public int getVenueID()
        {
            return venueID;
        }

        public string getName()
        {
            return name;
        }
        public double getPricePerDay() 
        {
            return pricePerDay;
        }
        public string getDecription()
        {
            return description;
        }

        public string getContactPerson()
        {
            return contactPerson;
        }
        public string getContactNumber()
        {
            return contactNumber;
        }
        public int getCapacity()
        {
            return capacity;
        }
        public string getBuilding()
        {
            return building;
        }

        public string getStreet()
        {
            return street;
        }

        public string getCity()
        {
            return city;
        }

        public string getCounty()
        {
            return county;
        }

        public string getEircode()
        {
            return eircode;
        }
        public char getStatus() 
        {
            return status;
        }

        public static int getNextVenueID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(VenueID) FROM Venues";

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
        public static DataSet getAvailableVenues(DateTime date)
        {
            // Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            
            conn.Open();

            // Define the SQL query to be executed
            String sqlQuery = "SELECT VenueId, Name, Description, Capacity, PricePerDay " +
                              "FROM Venues WHERE Status = 'A' AND VenueID NOT IN " +
                              "( SELECT VenueID FROM Events WHERE TRUNC(EventDate) = :eventDate)";

            // Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

           cmd.Parameters.Add(new OracleParameter("eventDate", date.Date));


            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "availableVenue");

            // Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet findAvaliableVenue(String capacity, DateTime date)
        {
            // Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            String sqlQuery = "SELECT VenueId, Name, Description, Capacity, PricePerDay " +
                             "FROM Venues WHERE Status = 'A' AND VenueID NOT IN " +
                             "(SELECT VenueID FROM Events WHERE TRUNC(EventDate) = :eventDate)";

            if (!string.IsNullOrEmpty(capacity))
            {
                sqlQuery += " AND Capacity >= " + capacity;
            }
   
               

            // Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            cmd.Parameters.Add(new OracleParameter("eventDate", date.Date));


            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "availableVenuebyDateAndCapacity");

            // Close db connection
            conn.Close();

            return ds;
        }


        public static DataSet findVenue(String venName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Venues " +
                "WHERE Status = 'A' AND Name LIKE '%" + venName + "%' ORDER BY Name";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "venue");

            //Close db connection
            conn.Close();

            return ds;
        }

        public static DataSet getAllVenues()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuerry = "SELECT * " +
            "FROM Venues ORDER BY VenueID";

            OracleCommand cmd = new OracleCommand(sqlQuerry, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "allVenue");

            conn.Close();

            return ds;

        }

        public void getVenue(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Venues WHERE VenueId = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setVenueID(dr.GetInt32(0));
            setName(dr.GetString(1));
            setDescription(dr.GetString(2));
            setContactPerson(dr.GetString(3));
            setContactNumber(dr.GetString(4));
            setCapacity(dr.GetInt32(5));
            setPricePerDay(dr.GetDouble(6));
            setBuilding(dr.GetString(7));
            setStreet(dr.GetString(8));
            setCity(dr.GetString(9));
            setCounty(dr.GetString(10));
            setEircode(dr.GetString(11));
            setStatus(char.Parse(dr.GetString(12)));

            //close DB
            conn.Close();
        }

        public static int getVenueIDByName(string name)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT VENUEID FROM Venues WHERE Name = '" + name+"'";

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
