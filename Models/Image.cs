using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string? Description { get; set; }
        public string? Url { get; set; }
        public bool? IsCover { get; set; }

        public int? LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location? Location { get; set; }

        public int? LandlordId { get; set; }
        [ForeignKey("LandlordId")]
        public Landlord Landlord { get; set; }
    }
}



