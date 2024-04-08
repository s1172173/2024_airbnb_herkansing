using Microsoft.Build.Evaluation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        [ForeignKey("LocationId")]
        public Location? Location { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        
        public int? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public float Discount { get; set; }
    }

    /*public static class ReservationSeed
    {
        public static Reservation[] GetReservations()
        {
            return [
                new Reservation
                {
                    ReservationId = 1,
                    Location = new Location { LocationId = 1 },
                    StartDate = DateTime.Today.AddDays(1),
                    EndDate = DateTime.Today.AddDays(7),
                    Customer = new Customer { CustomerId = 1 },
                    Discount = 0
                },
                new Reservation
                {
                    ReservationId = 2,
                    Location = new Location { LocationId = 2 },
                    StartDate = DateTime.Today.AddDays(1),
                    EndDate = DateTime.Today.AddDays(7),
                    Customer = new Customer { CustomerId = 2 },
                    Discount = 0
                },
            ];

        }
    }*/
}
