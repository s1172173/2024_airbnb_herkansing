using _2024_airbnb_herkansing.Models;

namespace _2024_airbnb_herkansing.Models.DTOs
{
    public class LocationDTOV2
    {
        public int LocationId { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string? Description { get; set; }
        public virtual List<string> ? ImageURL { get; set; }
        public virtual string ? LandlordAvatarURL { get; set; }
        public float? Price { get; set; }
        public LocationType? Type { get; set; }
    }


}
