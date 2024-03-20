using _2024_airbnb_herkansing.DTOs;
using _2024_airbnb_herkansing.Mapper;
using _2024_airbnb_herkansing.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2024_airbnb_herkansing.profiles
{
    public class LocationMapper : ILocationMapper
    {
        public LocationDTO Map(Location location)
            {
                return new LocationDTO
                {
                    LocationId = location.LocationId,
                    Title = location.Title,
                    SubTitle = location.SubTitle,
                    Description = location.Description,
                    ImageURL = location.Images,
                    LandlordAvatarURL = location.Landlord,
                };
        }

        public LocationDTO Map(Microsoft.CodeAnalysis.Location location)
        {
            throw new NotImplementedException();
        }
    }
}


