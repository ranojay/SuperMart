using Dapper;
using Microsoft.Data.Sqlite;
using SuperMart.API.Models;

namespace SuperMart.API.DataProviders
{
    public class ProductsProvider
    {
        private DataBaseConfig dataBaseConfig;
        private SqliteConnection connection;
        public ProductsProvider(DataBaseConfig config) 
        {
            dataBaseConfig = config;
            connection = new SqliteConnection(dataBaseConfig.connectionString);
        }
        
       
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
