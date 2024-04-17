using Microsoft.Build.Evaluation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? LocationId { get; set; }
        public virtual Location? Location { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        public float Discount { get; set; }
    }


}
