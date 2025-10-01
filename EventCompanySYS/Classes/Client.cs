using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventCompanySYS
{
    internal class Client
    {
        public int clientID;
        public string organizationName;
        public string contactPerson;
        public string telNumb;
        public string email;
        public string building;
        public string street;
        public string city;
        public string county;
        public string eircode;
        public char status;


        public Client() 
        {
            setClientID(0);
            setOrganizationName("Null");
            setContactPerson("Null");
            setTelNumb("Null");
            setEmail("Null");
            setBuilding("Null");
            setStreet("Null");
            setCity("Null");
            setCounty("Null");
            setEircode("Null");
            setStatus('A');

        }

        public Client(int clientID, string organizationName, string contactPerson, string telNumb, string email, string building, string street, string city, string county, string eircode, char status)
        {
            setClientID(clientID);
            setOrganizationName(organizationName);
            setContactPerson(contactPerson);
            setTelNumb(telNumb);
            setEmail(email);
            setBuilding(building);
            setStreet(street);
            setCity(city);
            setCounty(county);
            setEircode(eircode);
            setStatus(status);
        }

        public void setClientID(int clientID) { this.clientID = clientID; }
        public void setOrganizationName(string organizationName) { this.organizationName = organizationName; }
        public void setTelNumb(string telNumb) { this.telNumb = telNumb; }
        public void setEmail(string email) { this.email = email; }
        public void setBuilding(string building) { this.building = building; }
        public void setStreet(string street) { this.street = street; }
        public void setCity(string city) { this.city = city; }
        public void setContactPerson(string contactPerson) { this.contactPerson = contactPerson; }
        public void setCounty(string county) { this.county = county; }
        public void setEircode(string eircode) { this.eircode = eircode; }
        public void setStatus(char status) { this.status = status; }

        public int getClientID() { return clientID; }
        public string getOrganizationName() { return organizationName; }
        public string getContactPerson() { return contactPerson; }
        public string getTelNumb() { return telNumb; }
        public string getEmail() { return email; }
        public string getBuilding() { return building; }
        public string getStreet() { return street; }
        public string getCity() { return city; }
        public string getCounty() { return county; }
        public string getEircode() { return eircode;}
        public char getStatus() { return status; }


        public static DataSet getAllClients()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuerry = "SELECT * "+
            "FROM CLIENTS ORDER BY CLIENTID";

            OracleCommand cmd = new OracleCommand(sqlQuerry, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "client");

            conn.Close();

            return ds;

        }

        public static DataSet getAllAvaliableClients()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            String sqlQuerry = "SELECT CLIENTID, ORGANIZATIONNAME, EMAIL FROM CLIENTS WHERE Status = 'A' " +
                "ORDER BY OrganizationName";

            OracleCommand cmd = new OracleCommand(sqlQuerry, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "avaliableClients");

            conn.Close();

            return ds;

        }

        public void addClient()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "INSERT INTO Clients Values (" +
            this.clientID + ",'" +
            this.organizationName + "','" +
            this.contactPerson + "','" +
            this.telNumb + "','" +
            this.email + "','" +
            this.building + "','" +
            this.street + "','" +
            this.city + "','" +
            this.county + "','" +
            this.eircode + "','" +
            this.status + "',"+
            "SYSTIMESTAMP," +
            "SYSTIMESTAMP)";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
     
        public void updateClient()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "UPDATE Clients SET " +
                "ClientId = " + this.clientID + "," +
                "OrganizationName = '" + this.organizationName + "'," +
                "ContactPerson = '" + this.contactPerson + "'," +
                "Telephone = '" + this.telNumb + "'," +
                "Email = '" + this.email + "'," +
                "Building = '" + this.building + "'," +
                "Street = '" + this.street + "'," +
                "City = '" + this.city + "', " +
                "County = '" + this.county + "', " +
                "Eircode = '" + this.eircode + "', " +
                "Status  ='" + this.status + "' "+
                "WHERE ClientID = " + this.clientID;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            cmd.ExecuteNonQuery();

            //Close db connection
            conn.Close();
        }
        public void getClient(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT * FROM Clients WHERE ClientId = " + Id;

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            //set the instance variables with values from data reader
            setClientID(dr.GetInt32(0));
            setOrganizationName(dr.GetString(1));
            setContactPerson(dr.GetString(2));
            setTelNumb(dr.GetString(3));
            setEmail(dr.GetString(4));
            setBuilding(dr.GetString(5));
            setStreet(dr.GetString(6));
            setCity(dr.GetString(7));
            setCounty(dr.GetString(8));
            setEircode(dr.GetString(9));
            setStatus(dr.GetString(10)[0]);

            //close DB
            conn.Close();
        }

        public bool removeClient(int Id)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "DELETE FROM Clients WHERE ClientId = " + Id;

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
                MessageBox.Show("The clientID cannot be deleted. ClientID used in other tables",
                     "Error",
                      MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return false;

            }
                
            return true;
                        
        }




        public static DataSet findClient(String clientName)
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT ClientID, OrganizationName, ContactPerson, Telephone, Email FROM Clients " +
            "WHERE LOWER(OrganizationName) LIKE LOWER('%" + clientName + "%') ORDER BY OrganizationName";

            //Execute the SQL query (OracleCommand)
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "client");

            //Close db connection
            conn.Close();

            return ds;
        }



        public static int getNextClientID()
        {
            //Open a db connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            //Define the SQL query to be executed
            String sqlQuery = "SELECT MAX(ClientID) FROM Clients";

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


    }
}
