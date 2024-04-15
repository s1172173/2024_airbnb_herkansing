using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.Models
{
    public class Location
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

        /*public int? ImageId { get; set; }
        [ForeignKey("ImageId")]*/
        /*public Image? Image { get; set; }*/

        // I changed it to a "List" so that it becomes possible to have more then one image for a location
        public List<Image> Images { get; set; } = new List<Image>();

        public float PricePerDay { get; set; }
       
        public List<Reservation>? Reservations { get; set; }

        public int? LandlordId { get; set; }
        [ForeignKey("LandlordId")]
        public Landlord? Landlord { get; set; }


    }

    [Flags]
    public enum Features
    {
        Smoking = 1,
        PetsAllowed = 2,
        Wifi = 4,
        TV = 8,
        Bath = 16,
        Breakfast = 32
    }

    public enum LocationType
    {
        Appartment,
        Cottage,
        Chalet,
        Room,
        Hotel,
        House
    }

  
}
