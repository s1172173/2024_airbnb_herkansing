using _2024_airbnb_herkansing.Models;

namespace _2024_airbnb_herkansing.Repositories
{
    public interface ILandlordRepository
    {
        public Task<IEnumerable<Landlord>> GetAllLandlordsAsync(CancellationToken cancellationToken);
        public Task<Landlord> GetLandlordByIdAsync(int id, CancellationToken cancellationToken);
    }
}
