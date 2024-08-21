using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizGame.Server.Models;

namespace QuizGame.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly QuizDbContext _context;

        public UsersController(QuizDbContext context)
        {
            _context = context;
        }

        // GET: api/Felhasznalok
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            return await _context.Users.ToListAsync();
        }

        // GET: api/Felhasznalok/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUsers(int id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var users = await _context.Users.FindAsync(id);

            if (users == null)
            {
                return NotFound();
            }

            return users;
        }

        // PUT: api/Felhasznalok/5       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int id, Users users)
        {
            if (id != users.id)
            {
                return BadRequest();
            }

            _context.Entry(users).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool UsersExists(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Felhasznalok
        
        [HttpPost]
        public async Task<ActionResult<Users>> PostUsers(Users users)
        {
            var temp = _context.Users.Where(x => x.name == users.name && x.email == users.email).FirstOrDefault();
            if (temp == null)
            {
                _context.Users.Add(users);
                await _context.SaveChangesAsync();
            }
            else
            {
                users = temp;
            }
            return Ok(users);


            // DELETE: api/Felhasznalok/5
            [HttpDelete("{id}")]
             async Task<IActionResult> DeleteUsers(int id)
            {
                if (_context.Users == null)
                {
                    return NotFound();
                }
                var users = await _context.Users.FindAsync(id);
                if (users == null)
                {
                    return NotFound();
                }

                _context.Users.Remove(users);
                await _context.SaveChangesAsync();

                return NoContent();
            }

             bool UsersExists(int id)
            {
                return (_context.Users?.Any(e => e.id == id)).GetValueOrDefault();
            }
        }
    }
}