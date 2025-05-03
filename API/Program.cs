using API.Data;
using Microsoft.EntityFrameworkCore;

// Construction Phase
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//And register services with the DI container
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt=>
{
      opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Finalize the configuration and create the app object
var app = builder.Build();

// configure the HTTP request pipeline.
//Execution phase(app)
app.MapControllers();

app.Run();
