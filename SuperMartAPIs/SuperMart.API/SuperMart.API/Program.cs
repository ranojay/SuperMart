using SuperMart.API.DataProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton(new DataBaseConfig { connectionString = builder.Configuration["ConnectionString"] });
builder.Services.AddSingleton<ProductsProvider, ProductsProvider>();
builder.Services.AddSingleton<CustomersProvider, CustomersProvider>();
builder.Services.AddSingleton<ProductsProvider, ProductsProvider>();
builder.Services.AddSingleton<OrdersProvider, OrdersProvider>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
