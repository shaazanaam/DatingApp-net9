using API.Data;
using Microsoft.EntityFrameworkCore;

// Construction Phase
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//And register services with the DI container

//useSqlite will be configuring the Entity Framework Core to use the SQlite as the database provider
//builder.configuration.GetConnectionString("DefaultConnection") gets the connection string named "DefaultConnection"
//from the appsettings.json file 
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt=>
{
      opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors();

//Finalize the configuration and create the app object
var app = builder.Build();

// configure the HTTP request pipeline.
// In side this middle ware portion where the ordering then becomes important and then
// the cors service will need to be added before the MapControllers

//Execution phase(app)

app.UseCors(x=>x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200","https://localhost:4200"));
app.MapControllers();

app.Run();
