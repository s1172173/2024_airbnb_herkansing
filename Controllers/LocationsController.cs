using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Models;
using Asp.Versioning;

namespace _2024_airbnb_herkansing.Controllers
{
    /// <summary>
    /// Controller for managing locations.
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly _2024_airbnb_herkansingContext _context;

        public LocationsController(_2024_airbnb_herkansingContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all locations.
        /// </summary>
        /// <returns>A list of locations.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocation()
        {
            return await _context.Location.ToListAsync();
        }

        /// <summary>
        /// Retrieves a specific location by ID.
        /// </summary>
        /// <param name="id">The ID of the location to retrieve.</param>
        /// <returns>The requested location.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id)
        {
            var location = await _context.Location.FindAsync(id);

            if (location == null)
            {
                return NotFound();
            }

            return location;
        }

        /// <summary>
        /// Retrieves all locations.
        /// </summary>
        /// <returns>A list of all locations.</returns>
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocations()
        {
            return await _context.Location.ToListAsync();
        }

        /// <summary>
        /// Updates a location.
        /// </summary>
        /// <param name="id">The ID of the location to update.</param>
        /// <param name="location">The updated location data.</param>
        /// <returns>No content if successful.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation(int id, Location location)
        {
            if (id != location.LocationId)
            {
                return BadRequest();
            }

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationExists(id))
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
        /// Creates a new location.
        /// </summary>
        /// <param name="location">The location to create.</param>
        /// <returns>A newly created location.</returns>
        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            _context.Location.Add(location);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocation", new { id = location.LocationId }, location);
        }

        /// <summary>
        /// Deletes a location.
        /// </summary>
        /// <param name="id">The ID of the location to delete.</param>
        /// <returns>No content if successful.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            var location = await _context.Location.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }

            _context.Location.Remove(location);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocationExists(int id)
        {
            return _context.Location.Any(e => e.LocationId == id);
        }
    }
}
