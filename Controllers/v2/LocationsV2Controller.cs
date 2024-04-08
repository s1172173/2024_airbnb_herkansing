using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _2024_airbnb_herkansing.Data;
using Asp.Versioning;
using _2024_airbnb_herkansing.Models.v2;

namespace _2024_airbnb_herkansing.Controllers.v2
{
    /// <summary>
    /// The LocationsController class provides endpoints for managing locations in the API.
    /// </summary>
    [ApiVersion("2.0")]
    /*[Route("api/v{version:apiVersion}/Locations")]*/
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v2")]
    public class LocationsV2Controller : ControllerBase
    {
        private readonly _2024_airbnb_herkansingContext _context;

        /// <summary>
        /// Initializes a new instance of the LocationsController class.
        /// </summary>
        /// <param name="context">The DbContext instance for the application.</param>
        public LocationsV2Controller(_2024_airbnb_herkansingContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets a list of locations.
        /// </summary>
        /// <returns>A list of locations.</returns>
        [HttpGet]
        [MapToApiVersion("2.0")]
        public async Task<ActionResult<IEnumerable<LocationV2>>> GetLocationsV2()
        {
            var locations = await _context.Location.ToListAsync();
            return Ok(locations);
        }

        /// <summary>
        /// Gets a specific location.
        /// </summary>
        /// <param name="id">The ID of the location.</param>
        /// <returns>The location with the specified ID.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationV2>> GetLocationV2(int id)
        {
            var locationV2 = await _context.LocationV2.FindAsync(id);

            if (locationV2 == null)
            {
                return NotFound();
            }

            return locationV2;
        }

        /// <summary>
        /// Updates a specific location.
        /// </summary>
        /// <param name="id">The ID of the location.</param>
        /// <param name="locationV2">The updated location.</param>
        /// <returns>No content.</returns>
        /// <response code="204">Returns no content.</response>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocationV2(int id, LocationV2 locationV2)
        {
            if (id != locationV2.LocationId)
            {
                return BadRequest();
            }

            _context.Entry(locationV2).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationV2Exists(id))
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
        /// <param name="locationV2">The new location.</param>
        /// <returns>The created location.</returns>
        /// <response code="201">Returns the created location.</response>
        [HttpPost]
        public async Task<ActionResult<LocationV2>> PostLocationV2(LocationV2 locationV2)
        {
            _context.LocationV2.Add(locationV2);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocationV2", new { id = locationV2.LocationId }, locationV2);
        }

        /// <summary>
        /// Deletes a specific location.
        /// </summary>
        /// <param name="id">The ID of the location.</param>
        /// <returns>No content.</returns>
        /// <response code="204">Returns no content.</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocationV2(int id)
        {
            var locationV2 = await _context.LocationV2.FindAsync(id);
            if (locationV2 == null)
            {
                return NotFound();
            }

            _context.LocationV2.Remove(locationV2);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        /// <summary>
        /// Checks if a location with the specified ID exists.
        /// </summary>
        /// <param name="id">The ID of the location.</param>
        /// <returns>True if the location exists, false otherwise.</returns>
        private bool LocationV2Exists(int id)
        {
            return _context.LocationV2.Any(e => e.LocationId == id);
        }
    }
}