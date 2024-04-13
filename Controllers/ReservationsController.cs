using System;
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
    /// Controller for managing reservations.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly _2024_airbnb_herkansingContext _context;

        public ReservationsController(_2024_airbnb_herkansingContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves all reservations.
        /// </summary>
        /// <returns>A list of reservations.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reservation>>> GetReservation()
        {
            return await _context.Reservation.ToListAsync();
        }

        /// <summary>
        /// Retrieves a specific reservation by ID.
        /// </summary>
        /// <param name="id">The ID of the reservation to retrieve.</param>
        /// <returns>The requested reservation.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Reservation>> GetReservation(int id)
        {
            var reservation = await _context.Reservation.FindAsync(id);

            if (reservation == null)
            {
                return NotFound();
            }

            return reservation;
        }

        /// <summary>
        /// Updates a reservation.
        /// </summary>
        /// <param name="id">The ID of the reservation to update.</param>
        /// <param name="reservation">The updated reservation data.</param>
        /// <returns>No content if successful.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReservation(int id, Reservation reservation)
        {
            if (id != reservation.ReservationId)
            {
                return BadRequest();
            }

            _context.Entry(reservation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationExists(id))
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
        /// Creates a new reservation.
        /// </summary>
        /// <param name="reservation">The reservation to create.</param>
        /// <returns>A newly created reservation.</returns>
        [HttpPost]
        public async Task<ActionResult<Reservation>> PostReservation(Reservation reservation)
        {
            _context.Reservation.Add(reservation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ReservationExists(reservation.ReservationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetReservation", new { id = reservation.ReservationId }, reservation);
        }

        /// <summary>
        /// Deletes a reservation.
        /// </summary>
        /// <param name="id">The ID of the reservation to delete.</param>
        /// <returns>No content if successful.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }

            _context.Reservation.Remove(reservation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservation.Any(e => e.ReservationId == id);
        }
    }
}
