using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2024_airbnb_herkansing.Models.v2
{
    public class LocationV2
    {
        [Key]
        public int LocationId { get; set; }
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public string? Description { get; set; }
        public LocationType? Type { get; set; }
        public int Rooms { get; set; }
        public int NumberOfGuests { get; set; }
        public Features? Features { get; set; }
        [ForeignKey("ImageId")]
        public Image? Images { get; set; }
        public float PricePerDay { get; set; }
        [ForeignKey("ReservationId")]
        public Reservation? Reservations { get; set; }
        [ForeignKey("LanlordId")]
        public Landlord? Landlord { get; set; }
        /*public float Price { get; set; }*/
    }
}
