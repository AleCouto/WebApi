using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using Models;

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockLocalController : ControllerBase
    {
        private readonly DataBaseBooks _context;

        public StockLocalController(DataBaseBooks context)
        {
            _context = context;
        }

        // GET: api/StockLocals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockLocal>>> GetStockLocal()
        {
            return await _context.StockLocal.ToListAsync();
        }

        // GET: api/StockLocals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StockLocal>> GetStockLocal(int id)
        {
            var stockLocal = await _context.StockLocal.FindAsync(id);

            if (stockLocal == null)
            {
                return NotFound();
            }

            return stockLocal;
        }

        // PUT: api/StockLocals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStockLocal(int id, StockLocal stockLocal)
        {
            if (id != stockLocal.Id)
            {
                return BadRequest();
            }

            _context.Entry(stockLocal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockLocalExists(id))
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

        // POST: api/StockLocals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StockLocal>> PostStockLocal(StockLocal stockLocal)
        {
            _context.StockLocal.Add(stockLocal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStockLocal", new { id = stockLocal.Id }, stockLocal);
        }

        // DELETE: api/StockLocals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStockLocal(int id)
        {
            var stockLocal = await _context.StockLocal.FindAsync(id);
            if (stockLocal == null)
            {
                return NotFound();
            }

            _context.StockLocal.Remove(stockLocal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StockLocalExists(int id)
        {
            return _context.StockLocal.Any(e => e.Id == id);
        }
    }
}
