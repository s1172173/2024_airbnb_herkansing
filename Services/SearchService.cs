using _2024_airbnb_herkansing.Repositories;
using Microsoft.AspNetCore.Mvc;
using _2024_airbnb_herkansing.Models;
using AutoMapper;
using _2024_airbnb_herkansing.Models.DTOs;

namespace _2024_airbnb_herkansing.Services
{
    public class SearchService : ISearchService
    {
        private readonly ILocationRepository _repository;
        private readonly IMapper _mapper;

        public SearchService(ILocationRepository locationRepository, IMapper mapper)
        {
            _repository = locationRepository;
            _mapper = mapper;
        }

        // Retrieves all locations asynchronously
        public async Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            return await _repository.GetAllLocationsAsync(cancellationToken);
        }

        // Retrieves a location by its ID asynchronously
        public async Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _repository.GetLocationByIdAsync(id, cancellationToken);
        }

        // Retrieves all locations as DTOs asynchronously
        public async Task<IEnumerable<LocationDTO>> GetLocation(CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllLocationsAsync(cancellationToken);
            return _mapper.Map<IEnumerable<Location>, IEnumerable<LocationDTO>>(locations);
        }

        // Retrieves detailed information for a specific location asynchronously
        public async Task<ActionResult<GetDetailsDTO>> GetLocationDetails(int id, CancellationToken cancellationToken)
        {
            var location = await _repository.GetLocationByIdAsync(id, cancellationToken);

            if (location == null)
                return new NotFoundResult();

            var detailsDTO = _mapper.Map<GetDetailsDTO>(location);

            return new ActionResult<GetDetailsDTO>(detailsDTO);
        }

        // Retrieves locations with their prices as DTOs asynchronously
        public async Task<IEnumerable<LocationDTOV2>> GetLocationPrice(CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllLocationsAsync(cancellationToken);
            return _mapper.Map<IEnumerable<Location>, IEnumerable<LocationDTOV2>>(locations);
        }

        // Retrieves the maximum price among all locations asynchronously
        public async Task<ActionResult<GetMaxPriceDTO>> GetMaxPrice(CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllLocationsAsync(cancellationToken);
            var maxPriceDTO = locations.Select(location => _mapper.Map<GetMaxPriceDTO>(location));
            var MaxPriceResultsDTO = maxPriceDTO.OrderByDescending(dto => dto.Price).FirstOrDefault();

            if (MaxPriceResultsDTO != null)
            {
                return new ActionResult<GetMaxPriceDTO>(MaxPriceResultsDTO);
            }
            else
            {
                return new NotFoundResult();
            }
        }

        // Searches for locations based on criteria asynchronously
        public async Task<IEnumerable<LocationDTOV2>> Search(LocationSearchDTO? obj, CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllLocationsAsync(cancellationToken);

            // Filter the locations based on the search criteria, if provided
            if (obj != null)
            {
                // Various filtering criteria
            }

            // Map the filtered locations to the DTO format
            return _mapper.Map<IEnumerable<Location>, IEnumerable<LocationDTOV2>>(locations);
        }

        // Retrieves the unavailable dates for a specific location asynchronously
        public async Task<UnAvailableDatesDTO> GetUnavailableDatesAsync(int locationId, CancellationToken cancellationToken)
        {
            var unavailableDates = await _repository.GetUnavailableDatesAsync(locationId, cancellationToken);
            return unavailableDates;
        }
    }
}
