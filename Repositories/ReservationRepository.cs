using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.Models.DTOs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _2024_airbnb_herkansing.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly _2024_airbnb_herkansingContext _context;
        private readonly IMapper _mapper;

        public ReservationRepository(_2024_airbnb_herkansingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // Retrieves all reservations asynchronously, including related location and customer information
        public async Task<IEnumerable<Reservation>> GetAllReservationsAsync(CancellationToken cancellationToken)
        {
            return await _context.Reservation
                .Include(r => r.Location)
                .Include(r => r.Customer)
                .ToListAsync(cancellationToken);
        }

        // Retrieves a reservation by its ID asynchronously, including related location and customer information
        public async Task<Reservation> GetReservationByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Reservation
                .Include(r => r.Location)
                .Include(r => r.Customer)
                .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);
        }

        // Makes a new reservation asynchronously, including creating a new customer if not exists
        public async Task<Reservation> MakeReservationAsync(ReservationRequestDTO reservationRequest, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer
                .FirstOrDefaultAsync(c => c.Email == reservationRequest.Email, cancellationToken);

            if (customer == null)
            {
                // Create a new customer if not exists
                customer = new Customer
                {
                    FirstName = reservationRequest.FirstName,
                    LastName = reservationRequest.LastName,
                    Email = reservationRequest.Email
                };

                _context.Customer.Add(customer);
            }

            // Map reservation request DTO to reservation entity
            var reservationEntity = _mapper.Map<Reservation>(reservationRequest);
            reservationEntity.CustomerId = customer.Id;

            // Add reservation to context and save changes
            _context.Reservation.Add(reservationEntity);
            await _context.SaveChangesAsync(cancellationToken);

            return reservationEntity;
        }

        // Retrieves location by ID asynchronously, including related images and landlord information
        public async Task<Location> GetLocationAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Location
                .Include(l => l.Images)
                .Include(l => l.Landlord)
                .ThenInclude(l => l.Avatar)
                .FirstOrDefaultAsync(l => l.Id == id, cancellationToken);
        }
    }
}
