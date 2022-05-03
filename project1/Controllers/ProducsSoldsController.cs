using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project1.Models;

namespace project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducsSoldsController : ControllerBase
    {
        private readonly ProductContext _context;

        public ProducsSoldsController(ProductContext context)
        {
            _context = context;
        }

        // GET: api/ProducsSolds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProducsSold>>> GetProducsSold()
        {
            return await _context.ProducsSold.ToListAsync();
        }

        // GET: api/ProducsSolds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProducsSold>> GetProducsSold(int id)
        {
            var producsSold = await _context.ProducsSold.FindAsync(id);

            if (producsSold == null)
            {
                return NotFound();
            }

            return producsSold;
        }

        // PUT: api/ProducsSolds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducsSold(int id, ProducsSold producsSold)
        {
            if (id != producsSold.id)
            {
                return BadRequest();
            }

            _context.Entry(producsSold).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProducsSoldExists(id))
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

        // POST: api/ProducsSolds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProducsSold>> PostProducsSold(ProducsSold producsSold)
        {
            _context.ProducsSold.Add(producsSold);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducsSold", new { id = producsSold.id }, producsSold);
        }

        // DELETE: api/ProducsSolds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProducsSold(int id)
        {
            var producsSold = await _context.ProducsSold.FindAsync(id);
            if (producsSold == null)
            {
                return NotFound();
            }

            _context.ProducsSold.Remove(producsSold);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProducsSoldExists(int id)
        {
            return _context.ProducsSold.Any(e => e.id == id);
        }
    }
}
