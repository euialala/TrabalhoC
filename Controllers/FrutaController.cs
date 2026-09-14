using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers.Frutas
{
    [ApiController]
    [Route("[controller]")]
    public class FrutaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FrutaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Fruta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fruta>>> Get()
        {
            var frutas = await _context.Fruta.ToListAsync();

            return Ok(frutas);
        }

        // POST: /Fruta
        [HttpPost]
        public async Task<ActionResult<Fruta>> Post(Fruta fruta)
        {
            _context.Fruta.Add(fruta);

            await _context.SaveChangesAsync();

            return Ok(fruta);
        }

        // DELETE: /Fruta/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var fruta = await _context.Fruta.FindAsync(id);

            if (fruta == null)
            {
                return NotFound();
            }

            _context.Fruta.Remove(fruta);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}