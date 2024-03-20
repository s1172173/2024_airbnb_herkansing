using _2024_airbnb_herkansing.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.DTOs
{
    public class LocationDTO
    {
        public int LocationId { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string? Description { get; set; }
        public Image? ImageURL { get; set; }
        public Landlord? LandlordAvatarURL { get; set; }
    }
}
