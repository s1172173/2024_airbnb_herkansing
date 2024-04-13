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

        public int? AvatarId { get; set; }
        [ForeignKey("AvatarId")]
        public Image? Avatar { get; set; }

        public List<Location> Locations { get; set; }
    }
}


