using Microsoft.EntityFrameworkCore;
using _2024_airbnb_herkansing.Models;
using _2024_airbnb_herkansing.Models.v2;

namespace _2024_airbnb_herkansing.Data
{
    public class _2024_airbnb_herkansingContext : DbContext
    {
        public _2024_airbnb_herkansingContext(DbContextOptions<_2024_airbnb_herkansingContext> options)
            : base(options)
        {

        }

        public DbSet<_2024_airbnb_herkansing.Models.Landlord> Landlord { get; set; } = default!;
        public DbSet<_2024_airbnb_herkansing.Models.Location> Location { get; set; } = default!;
        public DbSet<_2024_airbnb_herkansing.Models.Image> Image { get; set; } = default!;
        public DbSet<_2024_airbnb_herkansing.Models.Customer> Customer { get; set; } = default!;
        public DbSet<_2024_airbnb_herkansing.Models.Reservation> Reservation { get; set; } = default!;

       
      
            // Add a new Seed method
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Seed the database
                Seed(modelBuilder);
            }

            private void Seed(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Reservations)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId);



            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    FirstName = "James",
                    LastName = "Jamerson",
                    Email = "jamesjamerson@gmail.com",
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Emily",
                    LastName = "Boberson",
                    Email = "emilyboberson@gmail.com",
                }
            );





            modelBuilder.Entity<Reservation>().HasData(
                 new Reservation
                 {
                     ReservationId = 1,
                     StartDate = DateTime.Today.AddDays(1),
                     EndDate = DateTime.Today.AddDays(7),
                     Discount = 0,
                     CustomerId = 1
                 },
                new Reservation
                {
                    ReservationId = 2,
                    StartDate = DateTime.Today.AddDays(1),
                    EndDate = DateTime.Today.AddDays(7),
                    Discount = 0,
                    CustomerId = 2
                }
                );

            modelBuilder.Entity<Image>().HasData(
                 new Image
                 {
                     ImageId = 1,
                     Url = "avatar_landlord_2.jpg",
                     Description = "Avatar of Landlord 1",
                     IsCover = true,
                 },
                new Image
                {
                    ImageId = 2,
                    Url = "avatar_landlord_2.jpg",
                    Description = "Avatar of Landlord 2",
                    IsCover = true,
                },
                new Image
                {
                    ImageId = 3,
                    Url = "image_location_1.jpg",
                    Description = "Image of location 1",
                    IsCover = true,
                },
                new Image
                {
                    ImageId = 4,
                    Url = "image_location_2.jpg",
                    Description = "Image of location 2",
                    IsCover = true,
                }
                );


            modelBuilder.Entity<Location>().HasData(
                    new Location
                    {
                        LocationId = 3,
                        Title = "De Boerenhoeve",
                        SubTitle = "Lekker veel ruimte",
                        Description = "De camping ligt verscholen achter de boerderij in de polder. Op fietsafstand (5 minuten) liggen het dorpje Nieuwvliet, de zee, het strand, het bos van Erasmus en het natuurgebied de Knokkert.",
                        Type = LocationType.Cottage,
                        Rooms = 1,
                        NumberOfGuests = 2,
                        Features = Features.Wifi,
                        PricePerDay = 100,
                  
                    },
                new Location
                {
                    LocationId = 4,
                    Title = "Location 4",
                    SubTitle = "Subtitle 4",
                    Description = "Description 4",
                    Type = LocationType.Appartment,
                    Rooms = 1,
                    NumberOfGuests = 2,
                    Features = Features.Wifi,
                    PricePerDay = 100,
                   
                }
                );

            modelBuilder.Entity<Landlord>().HasData(
                 new Landlord
                 {
                     LandlordId = 1,
                     FirstName = "Landlord 1",
                     LastName = "Lastname 1",
                     Age = 35,
                 },
                 new Landlord
                 {
                     LandlordId = 2,
                     FirstName = "Landlord 2",
                     LastName = "Lastname 2",
                     Age = 45,
                 }
            );

            }
        public DbSet<LocationV2> LocationV2 { get; set; } = default!;
    }
}