using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using AdoDataAccess;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            var connectionString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;

            // Create a new SqlConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Define the select query
                string selectQuery = "SELECT EmployeeID, FirstName, LastName, Department, Salary FROM Employee;";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet,"Employee");

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Console.WriteLine($"{row[0]}----{row[1]} ");
                }

                //

                string insertQuery = "INSERT INTO Employee (FirstName, LastName, Department, Salary) VALUES (@FirstName, @LastName, @Department, @Salary);";
                dataAdapter.InsertCommand = new SqlCommand(insertQuery, connection);
                dataAdapter.InsertCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50, "FirstName");
                dataAdapter.InsertCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 50, "LastName");
                dataAdapter.InsertCommand.Parameters.Add("@Department", SqlDbType.NVarChar, 50, "Department");
                dataAdapter.InsertCommand.Parameters.Add("@Salary", SqlDbType.Decimal, 10, "Salary");

                DataRow newRow = dataSet.Tables[0].NewRow();
                newRow["FirstName"] = "Salman";
                newRow["LastName"] = "Masood";
                newRow["Department"] = "IT";
                newRow["Salary"] = 80000.00;

                dataSet.Tables["Employee"].Rows.Add(newRow); //DATASET UPDATED

                dataAdapter.Update(dataSet, "Employee"); //INSERT INTO DB 

                Console.WriteLine("After Update");

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Console.WriteLine($"{row[0]}----{row[1]} ");
                }


                Console.ReadKey();
            }



        }
    }
}
