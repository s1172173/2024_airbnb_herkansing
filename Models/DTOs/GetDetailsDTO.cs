using _2024_airbnb_herkansing.Models;

namespace _2024_airbnb_herkansing.Models.DTOs
{
    public class GetDetailsDTO
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public int NumberOfGuests { get; set; }
        public float PricePerDay { get; set; }
        public LocationType Type { get; set; }
        public Features Features { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public LandlordDTO Landlord { get; set; }
    }
}
