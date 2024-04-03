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
        [ForeignKey("ImageId")]
        public Image? Images { get; set; }
        public float PricePerDay { get; set; }
        [ForeignKey("ReservationId")]
        public Reservation? Reservations { get; set; }
        [ForeignKey("LanlordId")]
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

   /* public static class LocationSeed
    {
        public static Location[] GetLocations()
        {
            return
            [
                new Location
                {
                    LocationId = 1,
                    Title = "De Boerenhoeve",
                    SubTitle = "Lekker veel ruimte",
                    Description = "De camping ligt verscholen achter de boerderij in de polder. Op fietsafstand (5 minuten) liggen het dorpje Nieuwvliet, de zee, het strand, het bos van Erasmus en het natuurgebied de Knokkert.",
                    Type = LocationType.Cottage,
                    Rooms = 1,
                    NumberOfGuests = 2,
                    Features = Features.Wifi,
                    PricePerDay = 100,
                    Images = new Image { ImageId = 3},
                    Landlord =  new Landlord { LandlordId = 1 },
                    Reservations = null,
                },
                new Location
                {
                    LocationId = 2,
                    Title = "Location 2",
                    SubTitle = "Subtitle 4",
                    Description = "Description 4",
                    Type = LocationType.Appartment,
                    Rooms = 1,
                    NumberOfGuests = 2,
                    Features = Features.Wifi,
                    PricePerDay = 100,
                    Images = new Image { ImageId = 3 },
                    Landlord = new Landlord { LandlordId = 2},
                    Reservations = null,
                }
            ];
        }
    }*/
}
