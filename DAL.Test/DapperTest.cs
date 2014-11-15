using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace DAL.Test
{
   public class DapperTest
    {
        private IDbConnection GetOpenConnection()
        {         
            var connection = new SqlCeConnection("Data Source=C:\\Northwind40.sdf;");
            connection.Open();
            return connection;
        }
       
        public void Test()
        {
            Console.Write("Running TableNameAsync");
            Task.WaitAll(TableNameAsync());
            Console.WriteLine(" - OK!");
        }

        private async Task TableNameAsync()
        {
             using (var connection = GetOpenConnection())
             {
                 // tests against "Automobiles" table (Table attribute)
                 await connection.InsertAsync(new Category { CategoryName = "Volvo" });
                
             }
        }
    }
}
