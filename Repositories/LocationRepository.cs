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

        public async Task<IEnumerable<Location>> GetAllLocationsAsync()
        {
            return await _context.Location.ToListAsync();
        }

        public async Task<Location> GetLocationByIdAsync(int id)
        {
            return await _context.Location.FirstOrDefaultAsync(l => l.LocationId == id);
        }
    }
}