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

            var detailsDTO = _mapper.Map<GetDetailsDTO>(location);

            return new ActionResult<GetDetailsDTO>(detailsDTO);
        }


        public async Task<IEnumerable<LocationDTOV2>> GetLocationPrice(CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllLocationsAsync(cancellationToken);
            return _mapper.Map<IEnumerable<Location>, IEnumerable<LocationDTOV2>>(locations);
        }

        public async Task<ActionResult<GetMaxPriceDTO>> GetMaxPrice(CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllLocationsAsync(cancellationToken);
            var maxPriceDTO = locations.Select(location => _mapper.Map<GetMaxPriceDTO>(location));
            var MaxPriceResultsDTO = maxPriceDTO.OrderByDescending(dto => dto.Price).FirstOrDefault();

            return new ActionResult<GetMaxPriceDTO>(MaxPriceResultsDTO);

        }

        public async Task<IEnumerable<LocationDTOV2>> Search(LocationSearchDTO? obj, CancellationToken cancellationToken)
        {
            var locations = await _repository.GetAllLocationsAsync(cancellationToken);

            // Filter the locations based on the search criteria, if provided
            if (obj != null)
            {
                if (obj.Features.HasValue)
                {
                    // Filter by Features
                    locations = locations.Where(location => (int)location.Features == obj.Features.Value);
                }

                if (obj.Type.HasValue)
                {
                    // Filter by Type
                    locations = locations.Where(location => (int)location.Type == obj.Type.Value);
                }


                if (obj.Rooms.HasValue)
                {
                    // Filter by Rooms
                    locations = locations.Where(location => location.Rooms == obj.Rooms.Value);
                }

                if (obj.MinPrice.HasValue)
                {
                    // Filter by MinPrice
                    locations = locations.Where(location => location.PricePerDay >= obj.MinPrice.Value);
                }

                if (obj.MaxPrice.HasValue)
                {
                    // Filter by MaxPrice
                    locations = locations.Where(location => location.PricePerDay <= obj.MaxPrice.Value);
                }
            }

            if (!(obj?.Features.HasValue ?? false) &&
                !(obj?.Type.HasValue ?? false) &&
                !(obj?.Rooms.HasValue ?? false) &&
                !(obj?.MinPrice.HasValue ?? false) &&
                !(obj?.MaxPrice.HasValue ?? false))
            {
                return _mapper.Map<IEnumerable<Location>, IEnumerable<LocationDTOV2>>(locations);
            }


            // Map the filtered locations to the DTO format
            return _mapper.Map<IEnumerable<Location>, IEnumerable<LocationDTOV2>>(locations);
        }

    }
}