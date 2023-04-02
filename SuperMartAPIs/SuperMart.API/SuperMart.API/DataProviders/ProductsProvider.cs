using Dapper;
using Microsoft.Data.Sqlite;
using SuperMart.API.Models;

namespace SuperMart.API.DataProviders
{
    public class ProductsProvider
    {
        DataBaseConfig dataBaseConfig;
        public ProductsProvider(DataBaseConfig config) 
        {
            dataBaseConfig = config;
            connection = new SqliteConnection(dataBaseConfig.connectionString);
        }
        protected SqliteConnection connection;
       
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await connection.QueryAsync<Product>("SELECT * FROM Products;");
        }

        public async Task<Product> Get(string pid)
        {
            return await connection.QueryFirstAsync<Product>($"SELECT * FROM Products where PID='{pid}';");
        }
    }
}
