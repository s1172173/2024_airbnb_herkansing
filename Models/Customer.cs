using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _2024_airbnb_herkansing.Models
{
    public class Customer
    {  
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public List<Reservation> Reservations { get; set; }
        public Customer()
        {
            Reservations = new List<Reservation>();
        }
    }
}
