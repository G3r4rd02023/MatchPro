using MatchPro.Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MatchPro.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        private readonly DataContext _context;

        public GruposController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Grupos.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Grupo grupo)
        {
            _context.Add(grupo);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var grupo = await _context.Grupos
                .SingleOrDefaultAsync(c => c.Id == id);
            if (grupo == null)
            {
                return NotFound();
            }
            return Ok(grupo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] Grupo grupo)
        {
            if (id != grupo.Id)
            {
                return BadRequest();
            }

            _context.Update(grupo);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var grupo = await _context.Grupos.FindAsync(id);
            if (grupo == null)
            {
                return NotFound();
            }
            _context.Remove(grupo);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
