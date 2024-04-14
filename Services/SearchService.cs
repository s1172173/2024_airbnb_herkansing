using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.Data;
using _2024_airbnb_herkansing.Repositories;
using AutoMapper;

namespace _2024_airbnb_herkansing.Services
{
    public class SearchService : ISearchService
    {
        private readonly ILocationRepository _repository;
        private readonly _2024_airbnb_herkansingContext _context;
        private readonly IMapper _mapper;
        public SearchService(ILocationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Location>> GetAllLocationsAsync()
        {
            return await _repository.GetAllLocationsAsync();
        }

        public async Task<Location> GetLocationByIdAsync(int id)
        {
            return await _repository.GetLocationByIdAsync(id);
        }
    }
}