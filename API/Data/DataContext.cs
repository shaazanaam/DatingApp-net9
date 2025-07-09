using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data; // namespace was showing as API only in the beginning and we have to change that to the 
//API.data // DbContext is the class that we want to import and this adds the using Microsoft.EntityFrameworkCore to the
// top of our file. the DbContext class is located in the EntityFramework Core namespace
//When you add a property like the public DbSet<Appuser>Users {get;set;} to your DataContext, you are telling the 
//Entity Framework Core that :"This context  manages a set of Appuser Entities".
//DbContext provides the infrastucture for us to define the properties of the type DbSet<T> in your own context class

public class DataContext(DbContextOptions options) : DbContext(options)
{
      public DbSet<AppUser> Users { get; set; }
}
