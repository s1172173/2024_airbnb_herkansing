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

        public async Task<IEnumerable<Reservation>> GetAllReservationsAsync(CancellationToken cancellationToken)
        {
            return await _context.Reservation
                .Include(r => r.Location)
                .Include(r => r.Customer)
                .ToListAsync(cancellationToken);
        }

        public async Task<Reservation> GetReservationByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Reservation
                .Include(r => r.Location)
                .Include(r => r.Customer)
                .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);
        }

        public async Task<Reservation> MakeReservationAsync(ReservationRequestDTO reservationRequest, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer
                .FirstOrDefaultAsync(c => c.Email == reservationRequest.Email, cancellationToken);

            if (customer == null)
            {
                customer = new Customer
                {
                    FirstName = reservationRequest.FirstName,
                    LastName = reservationRequest.LastName,
                    Email = reservationRequest.Email
                };

                _context.Customer.Add(customer);
                await _context.SaveChangesAsync(cancellationToken);
            }

            var reservationEntity = _mapper.Map<Reservation>(reservationRequest);
            reservationEntity.CustomerId = customer.Id;

            var location = await _context.Location
                .FirstOrDefaultAsync(l => l.Id == reservationRequest.LocationId, cancellationToken);

            reservationEntity.Location = location;
            reservationEntity.Customer = customer;

            _context.Reservation.Add(reservationEntity);
            await _context.SaveChangesAsync(cancellationToken);

            return reservationEntity;
        }

        public async Task<UnAvailableDatesDTO> GetUnavailableDatesAsync(int locationId, CancellationToken cancellationToken)
        {
            var unavailableDates = await _context.Reservation
                .Where(r => r.LocationId == locationId)
                .Select(r => r.StartDate ?? DateTime.MinValue)
                .ToListAsync(cancellationToken);

            return new UnAvailableDatesDTO { UnAvailableDates = unavailableDates };
        }
    }
}
