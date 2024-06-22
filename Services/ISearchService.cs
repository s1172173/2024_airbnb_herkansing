using _2024_airbnb_herkansing.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _2024_airbnb_herkansing.Models.DTOs;


namespace _2024_airbnb_herkansing.Services
{
    public interface ISearchService 
    {
        Task<IEnumerable<Location>> GetAllLocationsStandard(CancellationToken cancellationToken);
        Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken);
        Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken);

        public Task<IEnumerable<LocationDTO>> GetLocation(CancellationToken cancellationToken);
        public Task<ActionResult<GetDetailsDTO>> GetLocationDetails(int id, CancellationToken cancellationToken);
        public Task<IEnumerable<LocationDTOV2>> GetLocationPrice(CancellationToken cancellationToken);
        public Task<ActionResult<GetMaxPriceDTO>> GetMaxPrice(CancellationToken cancellationToken);
        public Task<IEnumerable<LocationDTOV2>> Search(LocationSearchDTO? obj, CancellationToken cancellationToken);
        Task<UnAvailableDatesDTO> GetUnavailableDatesAsync(int locationId, CancellationToken cancellationToken);
    }
}
