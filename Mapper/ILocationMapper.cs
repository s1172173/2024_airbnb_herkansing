using _2024_airbnb_herkansing.DTOs;
using _2024_airbnb_herkansing.Models;

namespace _2024_airbnb_herkansing.Mapper
{
    public interface ILocationMapper
    {
        LocationDTO Map(Location location);
    }
}
