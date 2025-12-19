using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = @"Server=SAJENDRA;Database=CompanyDB;Integrated Security=true;TrustServerCertificate=true;";

        GetAllEmployees(connectionString);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    static void GetAllEmployees(string connectionString)
    {
        string query = "SELECT * FROM Employees";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connected to database successfully!\n");

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("EMPLOYEE RECORDS:");
                Console.WriteLine("=".PadRight(80, '='));

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["EmployeeId"]}");
                    Console.WriteLine($"Name: {reader["FirstName"]} {reader["LastName"]}");
                    Console.WriteLine($"Department: {reader["Department"]}");
                    Console.WriteLine($"Salary: ${reader["Salary"]:N2}");
                    Console.WriteLine($"Hire Date: {reader["HireDate"]:yyyy-MM-dd}");
                    Console.WriteLine("-".PadRight(80, '-'));
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}