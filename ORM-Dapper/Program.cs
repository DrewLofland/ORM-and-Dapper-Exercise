using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("jsconfig1.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);
            var repo = new DapperDepartmentRepository(conn);
            
            Console.WriteLine("please enter a new department name");
            var newDepartment = Console.ReadLine();
            
            repo.InsertDepartment(newDepartment);
            var departments = repo.GetAllDepartments();
            
            foreach (var dept in departments)
            {
                Console.WriteLine(dept.Name);
            }
        }
    }
}
