using MatchPro.Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MatchPro.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TorneosController : ControllerBase
    {
        private readonly DataContext _context;

        public TorneosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok(await _context.Torneos.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Torneo torneo)
        {
            _context.Add(torneo);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var torneo = await _context.Torneos
                .SingleOrDefaultAsync(c => c.Id == id);
            if (torneo == null)
            {
                return NotFound();
            }
            return Ok(torneo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] Torneo torneo)
        {
            if (id != torneo.Id)
            {
                return BadRequest();
            }

            _context.Update(torneo);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var torneo = await _context.Torneos.FindAsync(id);
            if (torneo == null)
            {
                return NotFound();
            }
            _context.Remove(torneo);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
