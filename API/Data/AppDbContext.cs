using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
      //We do need to tell the entity framework about our enities 
      // we do this by creating a property called the DBSet
      //If I give the property the name of the User then this is going to be representing the name of the User inside the DataBase
      //Name of the table in the data base
      public DbSet<AppUserssss> Usersssses { get; set; }
}