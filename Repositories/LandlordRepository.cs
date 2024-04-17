using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Models;
using Microsoft.EntityFrameworkCore;

namespace _2024_airbnb_herkansing.Repositories
{
    public class LandlordRepository : ILandlordRepository
    {
        private readonly _2024_airbnb_herkansingContext _context;

        public LandlordRepository(_2024_airbnb_herkansingContext context)
        {
            _context = context;
        }

        // Retrieves all landlords asynchronously, including their associated locations
        public async Task<IEnumerable<Landlord>> GetAllLandlordsAsync(CancellationToken cancellationToken)
        {
            return await _context.Landlord.Include(l => l.Locations).ToListAsync(cancellationToken);
        }

        // Retrieves a landlord by their ID asynchronously
        public async Task<Landlord> GetLandlordByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Landlord.FindAsync(id);
        }
    }
}
