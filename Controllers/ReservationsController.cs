using Microsoft.AspNetCore.Mvc;
using _2024_airbnb_herkansing.Data;
using Asp.Versioning;
using _2024_airbnb_herkansing.Services;
using AutoMapper;
using _2024_airbnb_herkansing.Models.DTOs;


// All controllers are currently unable to return the data in the correct DTO format  due to a configuration error, which remains unresolved.
// This issue causes the Airbnb site to not respond properly to any requests.
// The code can still be checked, but testing it on the site is currently not possible.
namespace _2024_airbnb_herkansing.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly _2024_airbnb_herkansingContext _context;
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;

        public ReservationsController(IReservationService reservationService, IMapper mapper, _2024_airbnb_herkansingContext context)
        {
            _reservationService = reservationService;
            _mapper = mapper;
            _context = context;
        }

        /// <summary>
        /// This POST method creates a reservation using the input of the DTO object. This is for week assignment 7.
        ///</summary>
        ///<remarks>
        /// Sample request:
        ///
        ///     GET /api/Reservations/
        ///
        /// </remarks>
        /// <param name="reservationRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Saves a new reservation in the database</returns>
        /// <response code="200">The reservation has been succesfully completed</response>
        /// <response code="500">Internal server is not working properly</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ReservationReponseDTO> MakeReservationAsync(ReservationRequestDTO reservationRequest, CancellationToken cancellationToken)
        {
            return await _reservationService.MakeReservationAsync(reservationRequest, cancellationToken);
        }





        
    }
}
