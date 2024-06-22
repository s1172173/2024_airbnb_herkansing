using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace _2024_airbnb_herkansing.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly _2024_airbnb_herkansingContext _context;

        public LocationRepository(_2024_airbnb_herkansingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Location>> GetAllLocationsStandard(CancellationToken cancellationToken)
        {
            return await _context.Location.ToListAsync(cancellationToken);
        }

        // Retrieves all locations asynchronously
        public async Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            return await _context.Location.Include(l => l.Images).Include(l => l.Landlord).ToListAsync(cancellationToken);
        }

        // Retrieves all locations asynchronously
        public async Task<IEnumerable<Location>> GetLocations(CancellationToken cancellationToken)
        {
            return await _context.Location.Include(l => l.Images).Include(l => l.Landlord).ToListAsync(cancellationToken);
        }

        // Retrieves a location by its ID asynchronously
        public async Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Location.FindAsync(id);
        }

        // Retrieves unavailable dates for a specific location asynchronously
        public async Task<UnAvailableDatesDTO> GetUnavailableDatesAsync(int locationId, CancellationToken cancellationToken)
        {
            var unavailableDates = await _context.Reservation
                .Where(r => r.LocationId == locationId && r.StartDate.HasValue)
                .Select(r => r.StartDate ?? DateTime.MinValue)
                .ToListAsync(cancellationToken);

            return new UnAvailableDatesDTO { UnAvailableDates = unavailableDates };
        }
    }
}
