using Dapper;
using Microsoft.Data.Sqlite;
using SuperMart.API.Models;

namespace SuperMart.API.DataProviders
{
    public class OrdersProvider
    {
        private DataBaseConfig dataBaseConfig;
        private SqliteConnection connection;
        public OrdersProvider(DataBaseConfig config)
        {
            dataBaseConfig = config;
            connection = new SqliteConnection(dataBaseConfig.connectionString);
        }

        public async Task<Orders> SaveOrdersAsync(Orders orders)
        {
            string sqlQuery = "INSERT INTO Orders (OrderID, CustID, Date) VALUES(@OrderID, @CustID, @Date)";

            return await connection.ExecuteScalarAsync<Orders>(sqlQuery, orders);
        }
    }
}
