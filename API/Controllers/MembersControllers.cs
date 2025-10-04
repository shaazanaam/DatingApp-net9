using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]  // the way we  get to this end point is that we use the  localhost::5001/api/members  the controller part  inside the square bracket is going to   replace the first part of the controller
    [ApiController]
    // Any services that we added to the container of the program.cs where we tell the applciation as to what we have done so far
    //are made available for the dependency injection to the other classes that we use. So inside our member controller
    // we inject the AppDbContext . What this means in practive is that when an httpget request is reeived by our .Netapplication 
    //it checks the route and it  forwards it to the appropriate controller
    // And the framework is responsible for instantiating a new instance of this controller . it  in turn looks at the constructor and the it also creates 
    //a new  instance of the DbContext so that we effectively create a session with our database.
    //And all that works becasue we have got the DbContext Registered in our program class .
    // We are using the IRead only list as the List by itself is a list of strongly types members and  also provides the means to sort and change the data which we dont need in our case and thats  why we would need this method

    public class MembersController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AppUserssss>>> GetMembers()
        {
            var members = await context.Usersssses.ToListAsync();
            return Ok(members);
        }


        [HttpGet("{id}")]   //localhost:5001/api/members/bob-id

        // we use that parameter inside the curly braces inside the root parameter of the  function below 
        public async Task<ActionResult<AppUserssss>> GetMember(string id)
        {
            var member = await context.Usersssses.FindAsync(id);  // the find method will be using that id we pass  in and then get that from the tile and find  from the context
            if (member == null) return NotFound();

            return member;
        }
    }
}
