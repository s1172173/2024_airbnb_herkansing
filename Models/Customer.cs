using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        [ForeignKey("ReservationId")]
        public Reservation? Reservations { get; set; }
    }

    public static class CustomerSeed
    {
        public static Customer[] GetCustomers()
        {
            return [
                new Customer
                {
                    CustomerId = 1,
                    FirstName = "James",
                    LastName = "Jamerson",
                    Email = "jamesjamerson@gmail.com",
                    Reservations = new Reservation { ReservationId = 1 },
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Emily",
                    LastName = "Boberson",
                    Email = "emilyboberson@gmail.com",
                    Reservations = new Reservation { ReservationId = 2 },
                },
            ];
        }
    }
}
