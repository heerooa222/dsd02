using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsd02
{
    class Database
    {
        //Create Connection and Command,and an Adapter.
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        public string AddOrUpdate { get; private set; }
        public object MoviesID { get; private set; }

        //THE CONSTRUCTOR SETS THE DEFAULTS UPON LOADING THE CLASS
        public Database()
        {
            //change the connection string to run from your own music db
            //Data Source=DESKTOP-T68H3OA\SQLEXPRESS02;Initial Catalog=VBMoviesFullData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

            string connectionString = @"Data Source=DESKTOP-T68H3OA\SQLEXPRESS02;Initial Catalog=VBMoviesFullData;Integrated Security=True;";
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;
        }

        public string InsertOrUpdateCustomer(string CustomerID, string Firstname, string Lastname, string Address, string PhoneNumber, string DOB, string AddOrUpdate)
        {
            try
            {
                //Add gets passed through the parameter
                if (AddOrUpdate == "Add")
                {
                    //Create a Command object //Create a Query. Create and open a connection to SQL Server
                    string query = "INSERT INTO Customer (FirstName, LastName, Address, Phone, DOB) " +
                    "VALUES(@Firstname, @Lastname, @Address,@Phone, @DOB)";
                    var myCommand = new SqlCommand(query, Connection);
                    //create params
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("Phone", PhoneNumber);
                    myCommand.Parameters.AddWithValue("DOB", DOB);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                //Update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Customer set FirstName = @Firstname, LastName = @Lastname, Address =@Address, Phone =@Phone, DOB = @DOB where CustID = @ID ", Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("Phone", PhoneNumber);
                    myCommand.Parameters.AddWithValue("DOB", DOB);
                    myCommand.Parameters.AddWithValue("ID", CustomerID);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();

                }
                return " Is Successful";
            }
            catch (Exception e)
            {
                //need to get it to close a second time as it jumps the first connection.close if
                //ExecuteNonQuery fails.
                Connection.Close();
                return " Has Failed with " + e;
            }
        }








        public DataTable FillDGVCustomerWithCustomer()
        {
            //create a datatable as we only have one table, the Customer
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Customer", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);

                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView

        }

        public DataTable FillDGVMoviesWithMovies()
        {
            //create a datatable as we only have one table, the Customer
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from Movies", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);

                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView


        }

        public DataTable FillDGVRentedMoviesWithRentedMovies()
        {
            //create a datatable as we only have one table, the Customer
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from RentedMovies", Connection))
            {
                //connect in to the DB and get the SQL
                Connection.Open();
                //open a connection to the DB
                da.Fill(dt);

                Connection.Close(); //close the connection
            }
            return dt; //pass the datatable data to the DataGridView


        }
        public string InsertOrUpdateMovies(string MovieID, string Title, string Year, string Rating, string Plot, string Genres, string Copies, string AddOrUpdate)
        {
            try
            {
                //Add gets passed through the parameter
                if (AddOrUpdate == "Add")
                {
                    //Create a Command object //Create a Query. Create and open a connection to SQL Server
                    string query = "INSERT INTO Movies (Tittle, Year, Rating, Plot, Genres, Copies) " +
                    "VALUES(@, @Lastname, @Address,@Phone, @DOB)";
                    var myCommand = new SqlCommand(query, Connection);
                    //create params
                    myCommand.Parameters.AddWithValue("Tittle", Title);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("Genres", Genres);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                //Update gets passed through the parameter
                else if (AddOrUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Movies set Tittle = @Tittle, Year = @Year, Rating =@Rating, Plot =@Plot, Genres = @Genres where MovieID = @ID ", Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("Tittle", Title);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("Genres", Genres);
                    myCommand.Parameters.AddWithValue("ID", MovieID);
                    Connection.Open();
                    // open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();

                }





                return "It is successful";
            }

            


            catch
            {

                return "Not successful";

            }


            
        }
    }
}  
