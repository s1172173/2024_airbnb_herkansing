/*using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Models;

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

        
    }

}
*/