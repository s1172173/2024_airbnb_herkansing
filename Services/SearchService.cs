using _2024_airbnb_herkansing.DTOs;
using _2024_airbnb_herkansing.Repositories;
using Microsoft.AspNetCore.Mvc;
using _2024_airbnb_herkansing.Models;
using AutoMapper;

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

        public async Task<IEnumerable<Location>> GetAllLocationsAsync(CancellationToken cancellationToken)
        {
            return await _repository.GetAllLocationsAsync(cancellationToken);
        }

        public async Task<Location> GetLocationByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _repository.GetLocationByIdAsync(id, cancellationToken);
        }

        public async Task<IEnumerable<LocationDTO>> GetLocation(CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllLocationsAsync(cancellationToken);
            return _mapper.Map<IEnumerable<Location>, IEnumerable<LocationDTO>>(locations);
        }

        public async Task<ActionResult<GetDetailsDTO>> GetLocationDetails(int id, CancellationToken cancellationToken)
        {
            var location = await _repository.GetLocationByIdAsync(id, cancellationToken);

            if (location == null)
                return new NotFoundResult();

            var detailsDto = _mapper.Map<GetDetailsDTO>(location);
            return new ActionResult<GetDetailsDTO>(detailsDto);
        }

        public async Task<IEnumerable<LocationDTOV2>> GetLocationPrice(CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllLocationsAsync(cancellationToken);
            return _mapper.Map<IEnumerable<Location>, IEnumerable<LocationDTOV2>>(locations);
        }

        public async Task<ActionResult<GetMaxPriceDTO>> GetMaxPrice(CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllLocationsAsync(cancellationToken);
            var maxPrice = locations.Max(location => location.PricePerDay);
            return new ActionResult<GetMaxPriceDTO>(new GetMaxPriceDTO { Price = (int)maxPrice });
        }

        public async Task<IEnumerable<LocationDTOV2>> Search(LocationSearchDTO? obj, CancellationToken cancellationToken)
        {
            // Implement your search logic based on the provided criteria
            // For simplicity, let's return all locations for now
            return await GetLocationPrice(cancellationToken);
        }
    }
}