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
builder.Services.AddCors();

//Finalize the configuration and create the app object
var app = builder.Build();

// configure the HTTP request pipeline.
//Execution phase(app)
// you must provide the cors expression before the MapControllers and also the app.Run

app.UseCors(x=>x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200","https://localhost:4200"));
app.MapControllers();

app.Run();
