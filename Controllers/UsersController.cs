using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace DatingApp.Controllers
{

    [ApiController]
    [Route("api/controller")]
    public class UsersController : ControllerBase
    {

        private readonly DataContext _context;

        //this is a constructor
        public UsersController(DataContext context)
        {
            _context = context;
             
        }

        [HttpGet]
        public async  Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            //var user = _context.Users.Find(id);

            //return user;

            //or 

            return await _context.Users.FindAsync(id);
        }


    }
}
