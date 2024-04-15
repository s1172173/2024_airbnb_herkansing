/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Models;

namespace _2024_airbnb_herkansing.Controllers
{
    /// <summary>
    /// Controller for managing landlords.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LandlordsController : ControllerBase
    {
        private readonly _2024_airbnb_herkansingContext _context;

        public LandlordsController(_2024_airbnb_herkansingContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all landlords.
        /// </summary>
        /// <returns>A list of landlords.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Landlord>>> GetLandlord()
        {
            return await _context.Landlord.ToListAsync();
        }

        /// <summary>
        /// Retrieves a specific landlord by ID.
        /// </summary>
        /// <param name="id">The ID of the landlord to retrieve.</param>
        /// <returns>The requested landlord.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Landlord>> GetLandlord(int id)
        {
            var landlord = await _context.Landlord.FindAsync(id);

            if (landlord == null)
            {
                return NotFound();
            }

            return landlord;
        }

        /// <summary>
        /// Updates a landlord.
        /// </summary>
        /// <param name="id">The ID of the landlord to update.</param>
        /// <param name="landlord">The updated landlord data.</param>
        /// <returns>No content if successful.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLandlord(int id, Landlord landlord)
        {
            if (id != landlord.LandlordId)
            {
                return BadRequest();
            }

            _context.Entry(landlord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LandlordExists(id))
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

        /// <summary>
        /// Creates a new landlord.
        /// </summary>
        /// <param name="landlord">The landlord to create.</param>
        /// <returns>A newly created landlord.</returns>
        [HttpPost]
        public async Task<ActionResult<Landlord>> PostLandlord(Landlord landlord)
        {
            _context.Landlord.Add(landlord);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLandlord", new { id = landlord.LandlordId }, landlord);
        }

        /// <summary>
        /// Deletes a landlord.
        /// </summary>
        /// <param name="id">The ID of the landlord to delete.</param>
        /// <returns>No content if successful.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLandlord(int id)
        {
            var landlord = await _context.Landlord.FindAsync(id);
            if (landlord == null)
            {
                return NotFound();
            }

            _context.Landlord.Remove(landlord);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LandlordExists(int id)
        {
            return _context.Landlord.Any(e => e.LandlordId == id);
        }
    }
}
*/