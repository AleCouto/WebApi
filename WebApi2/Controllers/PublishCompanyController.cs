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
    public class PublishCompanyController : ControllerBase
    {
        private readonly DataBaseBooks _context;

        public PublishCompanyController(DataBaseBooks context)
        {
            _context = context;
        }

        // GET: api/PublishCompanys
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PublishCompany>>> GetPublishCompany()
        {
            return await _context.PublishCompany.ToListAsync();
        }

        // GET: api/PublishCompanys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PublishCompany>> GetPublishCompany(int id)
        {
            var publishCompany = await _context.PublishCompany.FindAsync(id);

            if (publishCompany == null)
            {
                return NotFound();
            }

            return publishCompany;
        }

        // PUT: api/PublishCompanys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublishCompany(int id, PublishCompany publishCompany)
        {
            if (id != publishCompany.PublishCompanyId)
            {
                return BadRequest();
            }

            _context.Entry(publishCompany).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublishCompanyExists(id))
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

        // POST: api/PublishCompanys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PublishCompany>> PostPublishCompany(PublishCompany publishCompany)
        {
            _context.PublishCompany.Add(publishCompany);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPublishCompany", new { id = publishCompany.PublishCompanyId }, publishCompany);
        }

        // DELETE: api/PublishCompanys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublishCompany(int id)
        {
            var publishCompany = await _context.PublishCompany.FindAsync(id);
            if (publishCompany == null)
            {
                return NotFound();
            }

            _context.PublishCompany.Remove(publishCompany);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PublishCompanyExists(int id)
        {
            return _context.PublishCompany.Any(e => e.PublishCompanyId == id);
        }
    }
}
