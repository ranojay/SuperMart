using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using SuperMart.API.Models;
using Dapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperMart.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            //SQLitePCL.raw.SetProvider(new SQLitePCL.sqlite3());
            using var connection = new SqliteConnection("Data Source=D:\\Dev\\Repos\\SuperMart\\SuperMartDB\\SuperMartDB.db");
            await connection.OpenAsync();
            try
            {
                return await connection.QueryAsync<Product>("SELECT * FROM Products;");
            }
            catch (Exception ex)
            {
                int i = 0;
            }

            return new List<Product>();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
