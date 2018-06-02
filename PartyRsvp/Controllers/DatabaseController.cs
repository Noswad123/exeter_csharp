using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using SqliteFromScratch;

namespace rawSql.Controllers
{
    // MVC is handling the routing for us.
    [Route("api/[Controller]")]
    public class TrackController : Controller
    {
        /* public void GetData(string sql, List<T> dataList)
         {
             // GetFullPath will complete the path for the file named passed in as a string.
             string dataSource = "Data Source=" + Path.GetFullPath("chinook.db");

             // using will make sure that the resource is cleaned from memory after it exists
             // conn inittializes the connection to the .db file.
             using (SqliteConnection conn = new SqliteConnection(dataSource))
             {

                 conn.Open();


                 // command combines the connection and the command string and creates the query
                 using (SqliteCommand command = new SqliteCommand(sql, conn))
                 {

                     // reader allows us to read each value that comes back and do something to it.
                     using (SqliteDataReader reader = command.ExecuteReader())
                     {

                         // Read returns true while there are more rows to advance to. then false when done.
                         while (reader.Read())
                         {

                             // map the data to our model.

                             Track newTrack = new Track()
                             {
                                 Id = reader.GetInt32(0),
                                 Name = reader.GetString(1),
                                 AlbumId = reader.GetInt32(2),
                                 MediaTypeId = reader.GetInt32(3),
                                 GenreId = reader.GetInt32(4),
                                 Composer = reader.GetValue(5).ToString(),
                                 Milliseconds = reader.GetInt32(6),
                                 Bytes = reader.GetInt32(7),
                                 UnitPrice = reader.GetInt32(8)
                             };

                             // add each one to the list.
                             //dataList.Add(newTrack);

                         }
                     }
                 }
                 conn.Close();
             }
             //return dataList;
         }*/
        public List<Track> GetTrack()
        {

            // tracks will be populated with the result of the query.
            List<Track> tracks = new List<Track>();

            // GetFullPath will complete the path for the file named passed in as a string.
            string dataSource = "Data Source=" + Path.GetFullPath("chinook.db");

            // using will make sure that the resource is cleaned from memory after it exists
            // conn inittializes the connection to the .db file.
            using (SqliteConnection conn = new SqliteConnection(dataSource))
            {

                conn.Open();

                // sql is the string that will be run as an sql command
                string sql = $"select * from tracks limit 200;";

                // command combines the connection and the command string and creates the query
                using (SqliteCommand command = new SqliteCommand(sql, conn))
                {

                    // reader allows us to read each value that comes back and do something to it.
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {

                        // Read returns true while there are more rows to advance to. then false when done.
                        while (reader.Read())
                        {

                            // map the data to our model.

                            Track newTrack = new Track()
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                AlbumId = reader.GetInt32(2),
                                MediaTypeId = reader.GetInt32(3),
                                GenreId = reader.GetInt32(4),
                                Composer = reader.GetValue(5).ToString(),
                                Milliseconds = reader.GetInt32(6),
                                Bytes = reader.GetInt32(7),
                                UnitPrice = reader.GetInt32(8)
                            };

                            // add each one to the list.
                            tracks.Add(newTrack);

                        }
                    }
                }
                conn.Close();
            }
            return tracks;
        }

    }
    [Route("api/[Controller]")]
    public class EmployeeController : Controller
    {
        public List<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>();

            // GetFullPath will complete the path for the file named passed in as a string.
            string dataSource = "Data Source=" + Path.GetFullPath("chinook.db");

            // using will make sure that the resource is cleaned from memory after it exists
            // conn inittializes the connection to the .db file.
            using (SqliteConnection conn = new SqliteConnection(dataSource))
            {

                conn.Open();

                // sql is the string that will be run as an sql command
                string sql = $"select * from employees where hiredate >= 20030101 limit 200;";

                // command combines the connection and the command string and creates the query
                using (SqliteCommand command = new SqliteCommand(sql, conn))
                {

                    // reader allows us to read each value that comes back and do something to it.
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {

                        // Read returns true while there are more rows to advance to. then false when done.
                        while (reader.Read())
                        {

                            // map the data to our model.

                            Employee newEmployee = new Employee()
                            {
                                EmployeeId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Title = reader.GetValue(3).ToString(),
                                //ReportsTo = reader.GetInt32(4),

                                /*City = reader.GetValue(5).ToString(),
                                 State = reader.GetValue(6).ToString(),
                                 Country = reader.GetValue(7).ToString(),
                                 PostCode = reader.GetValue(8).ToString(),
                                 Phone = reader.GetValue(9).ToString(),
                                 Fax = reader.GetValue(10).ToString(),
                                 Email = reader.GetValue(11).ToString()*/
                            };

                            // add each one to the list.
                            employees.Add(newEmployee);

                        }
                    }
                }
                conn.Close();
            }
            return employees;
        }
    }
    [Route("api/[Controller]")]
    public class CustomerController : Controller
    {
        public List<Customer> GetCustomer()
        {
            List<Customer> customers = new List<Customer>();

            // GetFullPath will complete the path for the file named passed in as a string.
            string dataSource = "Data Source=" + Path.GetFullPath("chinook.db");

            // using will make sure that the resource is cleaned from memory after it exists
            // conn inittializes the connection to the .db file.
            using (SqliteConnection conn = new SqliteConnection(dataSource))
            {

                conn.Open();

                // sql is the string that will be run as an sql command
                string sql = $"select * from customers limit 20;";

                // command combines the connection and the command string and creates the query
                using (SqliteCommand command = new SqliteCommand(sql, conn))
                {

                    // reader allows us to read each value that comes back and do something to it.
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {

                        // Read returns true while there are more rows to advance to. then false when done.
                        while (reader.Read())
                        {

                            // map the data to our model.

                            Customer newCustomer = new Customer()
                            {
                                CustomerId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Company = reader.GetValue(3).ToString(),
                                Address = reader.GetValue(4).ToString(),
                                City = reader.GetValue(5).ToString(),

                                State = reader.GetValue(6).ToString(),
                                Country = reader.GetValue(7).ToString(),
                                PostCode = reader.GetValue(8).ToString(),
                                Phone = reader.GetValue(9).ToString(),
                                Fax = reader.GetValue(10).ToString(),
                                Email = reader.GetValue(11).ToString(),
                                SupportRepId = reader.GetInt32(12)
                            };

                            // add each one to the list.
                            customers.Add(newCustomer);

                        }
                    }
                }
                conn.Close();
            }
            return customers;
        }
    }
}