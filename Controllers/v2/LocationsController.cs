using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Services;
using Asp.Versioning;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using _2024_airbnb_herkansing.Models.DTOs;


// All controllers are currently unable to return the data in the correct DTO format due to a configuration error, which remains unresolved.
// This issue causes the Airbnb site to not respond properly to any requests.
// The code can still be checked, but testing it on the site is currently not possible.
namespace _2024_airbnb_herkansing.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly _2024_airbnb_herkansingContext _context;
        private readonly ISearchService _searchService;
        private readonly IMapper _mapper;

        public LocationsController(ISearchService searchService, IMapper mapper, _2024_airbnb_herkansingContext context)
        {
            _searchService = searchService;
            _mapper = mapper;
            _context = context;
        }

        /// <summary>
        /// This endpoint returns all locations based on the structure of week assignment 5,
        /// including the landlord, images, avatar, type, and price.
        /// </summary>
        /// <returns>All locations in the database</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Locations
        ///
        /// </remarks>
        /// <response code="200">All locations in the database</response>
        /// <response code="400">The locations cannot be retrieved due to an error</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IEnumerable<LocationDTOV2>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            return (await _searchService.GetAllLocationsAsync(cancellationToken)).Select(location => _mapper.Map<LocationDTOV2>(location));
        }


    }
}