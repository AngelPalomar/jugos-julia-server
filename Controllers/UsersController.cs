using jugos_julia_server.Data;
using jugos_julia_server.Models;
using Microsoft.AspNetCore.Mvc;

namespace jugos_julia_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        // GET: api/User/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            // Replace with actual logic to retrieve a user by ID
            return Ok(new { Message = $"Get user with ID {id}" });
        }

        // POST: api/User
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                return Ok(User);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
                throw;
            }
        }

        // PUT: api/User/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] object user)
        {
            // Replace with actual logic to update a user
            return NoContent();
        }

        // DELETE: api/User/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            // Replace with actual logic to delete a user
            return NoContent();
        }
    }
}