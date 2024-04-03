using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.Models
{
    public class Landlord
    {
        [Key]
        public int LandlordId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        [ForeignKey("ImageId")]
        public Image? Avatar { get; set; }
        [ForeignKey("LocationId")]
        public Location? Locations { get; set; }
    }

       /* public static class LandlordSeed
        {
            public static Landlord[] GetLandlords()
            {
                return [
                    new Landlord
                    {
                        FirstName = "Landlord 1",
                        LastName = "Lastname 1",
                        Age = 35,
                        Avatar = new Image { ImageId = 1 },
                        Locations = new Location { LocationId = 1 }
                    },
                    new Landlord
                    {
                        FirstName = "Landlord 2",
                        LastName = "Lastname 2",
                        Age = 45,
                        Avatar = new Image { ImageId = 2},
                        Locations = new Location { LocationId = 2 }
                    },
                ];              
            }
        }*/
    }


