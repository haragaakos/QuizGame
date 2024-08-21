using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizGame.Server.Models;

namespace QuizAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatingSystemsController : ControllerBase
    {
        private readonly QuizDbContext _context;

        public OperatingSystemsController(QuizDbContext context)
        {
            _context = context;
        }

        // GET: api/OperaciosRendszerek
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OperatingSystems>>> GetOperatingSystems()
        {
          if (_context.OperatingSystems == null)
          {
              return NotFound();
          }
            return await _context.OperatingSystems.ToListAsync();
        }

        // GET: api/OperaciosRendszerek/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OperatingSystems>> GetOperatingSystems(int id)
        {
          if (_context.OperatingSystems == null)
          {
              return NotFound();
          }
            var operatingSystems = await _context.OperatingSystems.FindAsync(id);

            if (operatingSystems == null)
            {
                return NotFound();
            }

            return operatingSystems;
        }

        // PUT: api/OperaciosRendszerek/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOperatingSystems(int id, OperatingSystems operatingSystems)
        {
            if (id != operatingSystems.id)
            {
                return BadRequest();
            }

            _context.Entry(operatingSystems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperatingSystemsExists(id))
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

        // POST: api/OperaciosRendszerek
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OperatingSystems>> PostOperatingSystems(OperatingSystems operatingSystems)
        {
      
          if (_context.OperatingSystems == null)
          {
              return Problem("Entity set 'QuizDbContext.OperatingSystems'  is null.");
          }
            _context.OperatingSystems.Add(operatingSystems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOperatingSystems", new { id = operatingSystems.id }, operatingSystems);
        }

        // DELETE: api/OperaciosRendszerek/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOperatingSystems(int id)
        {
            if (_context.OperatingSystems == null)
            {
                return NotFound();
            }
            var operatingSystems = await _context.OperatingSystems.FindAsync(id);
            if (operatingSystems == null)
            {
                return NotFound();
            }

            _context.OperatingSystems.Remove(operatingSystems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OperatingSystemsExists(int id)
        {
            return (_context.OperatingSystems?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
