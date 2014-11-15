using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dapper.Contrib.Extensions;
namespace DAL.Test
{
    [TestClass]
    public class DapperTest1
    {
        
        public void TestMethod1()
        {
        }


        private IDbConnection GetOpenConnection()
        {
            var connection = new SqlCeConnection("Data Source=C:\\Northwind40.sdf;");
            connection.Open();
            return connection;
        }
        [TestMethod]
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
                var result = await connection.GetAsync<Category>(1);
                //await connection.G(new Category { CategoryName = "Volvo" });

            }
        }
    }
}
