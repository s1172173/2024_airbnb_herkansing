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
    }
}



