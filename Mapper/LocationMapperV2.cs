/*using _2024_airbnb_herkansing.DTOs.v2;
using _2024_airbnb_herkansing.Models;

namespace _2024_airbnb_herkansing.Mapper
{
    public class LocationMapperV2 : ILocationMapperV2
    {
        public LocationDTOV2 Map(Location location)
        {
            return new LocationDTOV2
            {
                LocationId = location.LocationId,
                Title = location.Title,
                SubTitle = location.SubTitle,
                Description = location.Description,
                ImageURL = location.Images,
                LandlordAvatarURL = location.Landlord,
                Price = location.PricePerDay,
                Type = location.Type,
            };
        }
    }
}
*/