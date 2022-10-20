

using System;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Academy.Store.App
{
    class Program
    {
        static void Main(string[] args)
        { var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
            IConfiguration config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultConnection");
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            try
            {
                string sql = "Select * From production.brands";
                SqlCommand command = new SqlCommand(sql, connection);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    
                    // Loop over the results
                    while (dataReader.Read())
                    {
                        var id = Convert.ToInt32(dataReader["brand_id"]);
                        var name = Convert.ToString(dataReader["brand_name"]);
                        Console.WriteLine($"Brand -> Id: {id}, Name: {name}");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                connection.Close();
            }
           
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
            
        }
    }
}