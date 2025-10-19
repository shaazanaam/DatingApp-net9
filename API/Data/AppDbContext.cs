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


// Property : public DbSet<AppUserssss> Userssss{get;set;}
// this is the member of the AppDbContext class ( and not inherited from the Dbcontext)
// It is of the type DbSet<AppUsersss> where AppUserss is another class (entity)
// the property  name Usersssses is the string identifier within the AppDbContext object


//Primary constructor: AppDbCOntext(DbContextOptions options) : DbContext(options)
      // this is the constructor for the AppDbContext object
      //it takes the DbContextoptions object as a parameter
      //It calls the base class constructor (DbContext(options)) to initialize the inherited DbContext part of the object