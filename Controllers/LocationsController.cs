using Microsoft.AspNetCore.Mvc;
using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.Services;
using Asp.Versioning;
using AutoMapper;
using _2024_airbnb_herkansing.Models.DTOs;


// All controllers are currently unable to return the data in the correct format due to a configuration error, which remains unresolved.
// This issue causes the Airbnb site to not respond properly to any requests.
// The code can still be checked, but testing it on the site is currently not possible.
namespace _2024_airbnb_herkansing.Controllers
{
    [ApiVersion("1.0")]
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
        /// Retrieves all locations using a GetAll request This is for week assignment 3.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///    GET /api/Locations/GetAll
        ///
        /// </remarks>
        /// <param name="cancellationToken">The cancellation token.</param>
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Location>>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetAllLocationsAsync(cancellationToken);
            return Ok(locations);
        }

        /// <summary>
        /// Gets all locations as DTOs. This is for weekopdracht 4.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Locations
        ///
        /// </remarks>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An <see cref="IEnumerable{LocationDto}"/> of all locations as DTOs.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationDTO>>> GetLocation(CancellationToken cancellationToken)
        {
            var locations = await _searchService.GetAllLocationsAsync(cancellationToken);
            return Ok(locations);
        }

        /// <summary>
        /// Gets the max price for a location. This is for weekopdracht 6.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Locations/GetMaxPrice
        ///
        /// </remarks>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="GetMaxPriceDTO"/> of the location with the maximum price.</returns>
        [HttpGet("GetMaxPrice")]
        public async Task<ActionResult<GetMaxPriceDTO>> GetMaxPrice(CancellationToken cancellationToken)
        {
            return await _searchService.GetMaxPrice(cancellationToken);

        }

        /// <summary>
        /// Retrieves detailed information for a specific location. This is for week assignment 6.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Locations/GetDetails/{id}
        ///
        /// </remarks>
        /// <param name="id">The ID of the location.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The <see cref="GetDetailsDTO"/> of the specified location.</returns>
        [HttpGet("GetDetails/{id}")]
        public async Task<ActionResult<GetDetailsDTO>> GetLocationDetails(int id, CancellationToken cancellationToken)
        {

            var detailedlocation = await _searchService.GetLocationDetails(id, cancellationToken);
            return detailedlocation;

        }

        /// <summary>
        /// Searches for locations that meet the specified criteria. This is for week assignment 6.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/Locations/Search
        ///
        /// </remarks>
        /// <param name="obj">Search criteria object</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>An enumerable list of <see cref="LocationDTOV2"/> objects that meet the specified criteria</returns>
        [HttpPost("Search")]
        public async Task<IEnumerable<LocationDTOV2>> Search(LocationSearchDTO? obj, CancellationToken cancellationToken)
        {
            return await _searchService.Search(obj, cancellationToken);
        }

        /// <summary>
        /// Retrieves the unavailable dates for a specific location based on its reservations. This is for week assignment 7.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/Locations/UnAvailableDates/<locationId>
        ///
        /// </remarks>
        /// <param name="locationId">The ID of the location to retrieve the unavailable dates for.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>An <see cref="ActionResult{T}"/> containing the <see cref="UnavailableDatesDTO"/> object with the unavailable dates.</returns>
        [HttpGet("UnAvailableDates/{locationId}")]
        public async Task<ActionResult<UnAvailableDatesDTO>> GetUnavailableDatesAsync(int locationId, CancellationToken cancellationToken)
        {
            var unavailableDatesDTO = await _searchService.GetUnavailableDatesAsync(locationId, cancellationToken);
            return unavailableDatesDTO;
        }




    }
}
