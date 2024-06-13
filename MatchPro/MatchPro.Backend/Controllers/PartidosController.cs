using MatchPro.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MatchPro.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidosController : ControllerBase
    {
        private readonly DataContext _context;

        public PartidosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Partidos.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Partido partido)
        {
            _context.Add(partido);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var partido = await _context.Partidos
                .SingleOrDefaultAsync(c => c.Id == id);
            if (partido == null)
            {
                return NotFound();
            }
            return Ok(partido);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] Partido partido)
        {
            if (id != partido.Id)
            {
                return BadRequest();
            }

            _context.Update(partido);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var partido = await _context.Partidos.FindAsync(id);
            if (partido == null)
            {
                return NotFound();
            }
            _context.Remove(partido);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
