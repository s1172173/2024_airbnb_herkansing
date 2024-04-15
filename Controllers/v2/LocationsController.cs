/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.Services;
using Asp.Versioning;
using AutoMapper;
using _2024_airbnb_herkansing.Repositories;

namespace _2024_airbnb_herkansing.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly _2024_airbnb_herkansingContext _context;
      *//*  private readonly ISearchService _searchService;
        private readonly IMapper _mapper;

        public LocationsController(ISearchService searchService, IMapper mapper)
        {
            _searchService = searchService;
            _mapper = mapper;
        }*//*

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

        // GET: api/Locations
        /// <summary>
        /// Dit endpoint geeft alle locations terug aan de hand van de structuur van weekopdracht 5
        /// Inclusief de landlord, images en avatar
        /// </summary>
        /// <returns>Alle locations in de database</returns>
        /// <remarks>
        /// </remarks>
        /// <response code="200">Alle locations in de database</response>
        /// <response code="400">De locations kunnen niet worden opgehaald door een error</response>
        *//*[HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IEnumerable<Location> GetAllLocationsAsync()
        {
            return _searchService.GetAllLocationsAsync().Select(location => _mapper.Map<Location>(location));
        }*//*

    }
}
*/