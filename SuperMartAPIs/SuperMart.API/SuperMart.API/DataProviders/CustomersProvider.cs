using Dapper;
using Microsoft.Data.Sqlite;
using SuperMart.API.Models;

namespace SuperMart.API.DataProviders
{
    public class CustomersProvider
    {
        protected SqliteConnection connection;
        protected DataBaseConfig dataBaseConfig;
        public CustomersProvider(DataBaseConfig config) 
        {
            dataBaseConfig = config;
            connection = new SqliteConnection(dataBaseConfig.connectionString);
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
