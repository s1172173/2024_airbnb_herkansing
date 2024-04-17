using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.Models
{
    public class Image
    {       
        public int Id { get; set; }
        public string? Url { get; set; }
        public bool IsCover { get; set; }

        public int? LocationId { get; set; }
        public virtual Location? Location { get; set; }

        public virtual Landlord? Landlord { get; set; }
    }
}



