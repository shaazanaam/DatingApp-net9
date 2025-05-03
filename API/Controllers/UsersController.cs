using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")]   // you will be browsing to the /api/users and then you will be routed to the 
                              // API controller  UsersController
public class UsersController(DataContext context) : ControllerBase
{
      
      // this is where we will be creating the API end points
      [HttpGet]
      public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
      {
            //here we are going to return the list of our users which means we need access to the database and the system that we use inside 
            var users = await context.Users.ToListAsync();
            return users;

      }

      [HttpGet("{id:int}")]   //app/users/2
      public async Task<ActionResult<AppUser>> GetUser(int id)
      {
            //here we are going to return the list of our users which means we need access to the database and the system that we use inside 
            var user = await context.Users.FindAsync(id);
            if(user== null) return NotFound();
            return user;

      }

}
