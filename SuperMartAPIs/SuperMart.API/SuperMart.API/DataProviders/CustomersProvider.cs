using Dapper;
using Microsoft.Data.Sqlite;
using SuperMart.API.Models;

namespace SuperMart.API.DataProviders
{
    public class CustomersProvider
    {
        protected SqliteConnection connection;
        public CustomersProvider() 
        {
            connection = new SqliteConnection("Data Source=D:\\Dev\\Repos\\SuperMart\\SuperMartDB\\SuperMartDB.db");
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await connection.QueryAsync<Customer>("SELECT * FROM Customers;");
        }

        public async Task<Customer> Get(string id)
        {
            return await connection.QueryFirstAsync<Customer>($"SELECT * FROM Customers where ID='{id}';");
        }

    }
}
