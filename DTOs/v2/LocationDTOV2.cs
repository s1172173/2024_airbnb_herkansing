using _2024_airbnb_herkansing.Models;

namespace _2024_airbnb_herkansing.DTOs.v2
{
    public class LocationDTOV2
    {
        public int LocationId { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string? Description { get; set; }
        public Image? ImageURL { get; set; }
        public Landlord? LandlordAvatarURL { get; set; }
        public float? Price { get; set; }
        public LocationType? Type { get; set; }
    }
}
