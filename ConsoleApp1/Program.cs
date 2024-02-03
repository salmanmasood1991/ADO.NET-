using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new SqlConnection
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    // Define the select query
            //    string selectQuery = "SELECT EmployeeID, FirstName, LastName, Department, Salary FROM Employee;";

            //    // Create a new SqlDataAdapter for select
            //    using (SqlDataAdapter selectAdapter = new SqlDataAdapter(selectQuery, connection))
            //    {
            //        // Create a new DataSet to hold the data
            //        DataSet dataSet = new DataSet();

            //        try
            //        {
            //            // Open the connection
            //            connection.Open();

            //            // Fill the DataSet with existing data using the selectAdapter
            //            selectAdapter.Fill(dataSet, "Employee");

            //            // Display existing data
            //            Console.WriteLine("Existing Employee data:");
            //            PrintDataSet(dataSet, "Employee");

            //            // Create a new insert query
            //            string insertQuery = "INSERT INTO Employee (FirstName, LastName, Department, Salary) VALUES (@FirstName, @LastName, @Department, @Salary);";

            //            // Create a new SqlDataAdapter for insert
            //            using (SqlDataAdapter insertAdapter = new SqlDataAdapter())
            //            {
            //                // Set the insert command for the insertAdapter
            //                insertAdapter.InsertCommand = new SqlCommand(insertQuery, connection);
            //                insertAdapter.InsertCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
            //                insertAdapter.InsertCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName");
            //                insertAdapter.InsertCommand.Parameters.Add("@Department", SqlDbType.NVarChar, 50, "Department");
            //                insertAdapter.InsertCommand.Parameters.Add("@Salary", SqlDbType.Decimal, 10, "Salary");

            //                // Create a new DataRow for the new employee
            //                DataRow newRow = dataSet.Tables["Employee"].NewRow();
            //                newRow["FirstName"] = "Jane";
            //                newRow["LastName"] = "Smith";
            //                newRow["Department"] = "HR";
            //                newRow["Salary"] = 50000.00;

            //                // Add the new DataRow to the DataSet
            //                dataSet.Tables["Employee"].Rows.Add(newRow);

            //                // Use the insertAdapter to update the database with the changes
            //                insertAdapter.Update(dataSet, "Employee");

            //                // Display updated data
            //                Console.WriteLine("\nEmployee data after insertion:");
            //                PrintDataSet(dataSet, "Employee");

            //                Console.WriteLine("\nRecord inserted successfully.");
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("Error: " + ex.Message);
            //        }
            //        finally
            //        {
            //            // Close the connection
            //            connection.Close();
            //        }
            //    }
            //    Console.ReadKey();
            //}


            Console.Read();
        }


        static void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Method1 :" + i);
            }
        }

        static void Method2()
        {
            
            for (int i = 1; i <= 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Method2 :" + i);
                if (i == 3)
                {
                    Console.WriteLine("Performing the Database Operation Started");
                    //Sleep for 10 seconds
                    Thread.Sleep(10000);
                    Console.WriteLine("Performing the Database Operation Completed");
                }
            }
        }
        static void Method3()
        {
           
            for (int i = 1; i <= 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Method3 :" + i);
            }
        }
    }
}
