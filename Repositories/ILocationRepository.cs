using _2024_airbnb_herkansing.Models;


namespace _2024_airbnb_herkansing.Repositories
{
    public interface ILocationRepository
    {
        public Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken);
        public Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken);

    }
}
