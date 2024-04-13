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

namespace _2024_airbnb_herkansing.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly _2024_airbnb_herkansingContext _context;

        public LocationsController(_2024_airbnb_herkansingContext context)
        {
            _context = context;
        }

        // GET: api/Locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocation()
        {
            var locations = await _context.Location
                .Include(l => l.Image)
                .ToListAsync();

            if (locations == null)
            {
                return NotFound();
            }

            return locations;
        }
    }
}
