using Microsoft.Build.Evaluation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }      
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location? Location { get; set; }

        public int? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public float Discount { get; set; }
    }


}
