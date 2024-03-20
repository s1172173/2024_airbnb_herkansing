using _2024_airbnb_herkansing.DTOs;
using Microsoft.CodeAnalysis;

namespace _2024_airbnb_herkansing.Mapper
{
    public interface ILocationMapper
    {
        public LocationDTO Map(Location location);
    }
}
