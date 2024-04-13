/*using _2024_airbnb_herkansing.DTOs;
using _2024_airbnb_herkansing.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2024_airbnb_herkansing.Mapper
{
    public class LocationMapper : ILocationMapper
    {
        public  LocationDTO Map(Location location)
        {
                return new LocationDTO
                {
                    LocationId = location.LocationId,
                    Title = location.Title,
                    SubTitle = location.SubTitle,
                    Description = location.Description,
                    ImageURL = location.Images.Where(image => image.IsCover ==  true).First().Url,
                    LandlordAvatarURL = location.Landlord,
                };
        }
    }
}


*/