namespace _2024_airbnb_herkansing.Models.DTOs
{
    public class LocationSearchDTO
    {
        public int? Features { get; set; }
        public int? Type { get; set; }
        public int? Rooms { get; set; }
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
    }
}
