using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.DTOs;
using System.Collections.Generic;


namespace _2024_airbnb_herkansing.Services
{
    public interface ISearchService
    {
        Task<IEnumerable<Location>> GetAllLocationsAsync();
        Task<Location> GetLocationByIdAsync(int id);
        
    }
}
