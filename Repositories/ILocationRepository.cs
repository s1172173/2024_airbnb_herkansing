using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.Models.DTOs;


namespace _2024_airbnb_herkansing.Repositories
{
    public interface ILocationRepository
    {
        public Task<IEnumerable<Location>> GetAllLocationsStandard(CancellationToken cancellationToken);
        public Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken);
    /*    public Task<IEnumerable<Location>> GetLocations(CancellationToken cancellationToken);*/
        public Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken);
        public Task<UnAvailableDatesDTO> GetUnavailableDatesAsync(int locationId, CancellationToken cancellationToken);

    }
}
