using Microsoft.AspNetCore.Mvc;
using _2024_airbnb_herkansing.Data;
using Asp.Versioning;
using _2024_airbnb_herkansing.Services;
using AutoMapper;
using _2024_airbnb_herkansing.Models.DTOs;

namespace _2024_airbnb_herkansing.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;

        public ReservationsController(IReservationService reservationService, IMapper mapper)
        {
            _reservationService = reservationService;
            _mapper = mapper;
        }

        /// <summary>
        /// Creates a new reservation.
        /// </summary>
        /// <param name="reservationRequest">The reservation request DTO.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The created reservation response DTO.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> MakeReservationAsync([FromBody] ReservationRequestDTO reservationRequest, CancellationToken cancellationToken)
        {
            try
            {
                var reservationResponse = await _reservationService.MakeReservationAsync(reservationRequest, cancellationToken);
                if (reservationResponse == null)
                {
                    return Conflict("The selected dates are not available.");
                }
                return Ok(reservationResponse);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while creating the reservation.");
            }
        }
    }
}
