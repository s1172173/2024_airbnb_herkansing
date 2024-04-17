using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.Models
{
    public class Landlord
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }

        public int? AvatarId { get; set; }
        
        public virtual Image? Avatar { get; set; }

        public virtual List<Location> Locations { get; set; }

        public Landlord()
        {
            Locations = new List<Location>();

        }
    }
}


