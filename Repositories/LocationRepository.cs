using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Models;
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

        public async Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            return await _context.Location.ToListAsync(cancellationToken);
        }

        public async Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Location.FindAsync(id);
        }
    }
}