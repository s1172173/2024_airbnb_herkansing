using Microsoft.EntityFrameworkCore;
using _2024_airbnb_herkansing.Models;

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



        // Add a new Seed method | Seeding is currently functional
        // Deze seeding structuur heb ik gebaseerd op een van de voorbeelden van Tom Siever (project CheckjeAdvanced),
        // Als dit als plagiaat wordt herkent is dat volledig de fout van Nick Bergmans en niet de eerder benoemde naam.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasOne(i => i.Landlord).WithOne(l => l.Avatar).HasForeignKey<Landlord>(i => i.AvatarId);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
                new { Id = 1, FirstName = "Alice", LastName = "Wonderland", Email = "alice@example.com" },
                new { Id = 2, FirstName = "Bob", LastName = "Builder", Email = "bob@example.com" },
                new { Id = 3, FirstName = "Charlie", LastName = "Chocolate", Email = "charlie@example.com" }
            );

            modelBuilder.Entity<Landlord>().HasData(
                new { Id = 1, FirstName = "John", LastName = "Doe", Age = 30, AvatarId = 1 },
                new { Id = 2, FirstName = "Jane", LastName = "Smith", Age = 25, AvatarId = 2 },
                new { Id = 3, FirstName = "Jim", LastName = "Bean", Age = 40, AvatarId = 3 },
                new { Id = 4, FirstName = "Jill", LastName = "Hill", Age = 35, AvatarId = 4 },
                new { Id = 5, FirstName = "Jack", LastName = "Black", Age = 28, AvatarId = 5 }
            );

            modelBuilder.Entity<Location>().HasData(
                new { Id = 1, Rooms = 2, Description = "Modern apartment in the city center", Features = Features.Wifi | Features.TV, SubTitle = "Close to all amenities", NumberOfGuests = 4, Title = "City Center Apartment", Type = LocationType.Appartment, PricePerDay = 80.0F, LandlordId = 1 },
                new { Id = 2, Rooms = 3, Description = "Cozy cottage in the countryside", Features = Features.PetsAllowed | Features.Breakfast, SubTitle = "Peaceful and quiet", NumberOfGuests = 6, Title = "Countryside Cottage", Type = LocationType.Cottage, PricePerDay = 120.0F, LandlordId = 2 },
                new { Id = 3, Rooms = 4, Description = "Beachfront villa with stunning views", Features = Features.Wifi | Features.Bath, SubTitle = "Steps from the beach", NumberOfGuests = 8, Title = "Beachfront Villa", Type = LocationType.House, PricePerDay = 250.0F, LandlordId = 3 },
                new { Id = 4, Rooms = 1, Description = "Single room in a shared house", Features = Features.TV, SubTitle = "Affordable and convenient", NumberOfGuests = 2, Title = "Shared House Room", Type = LocationType.Room, PricePerDay = 40.0F, LandlordId = 4 },
                new { Id = 5, Rooms = 5, Description = "Luxury mansion with private pool", Features = Features.Wifi | Features.Bath | Features.TV, SubTitle = "Exclusive and luxurious", NumberOfGuests = 10, Title = "Luxury Mansion", Type = LocationType.House, PricePerDay = 450.0F, LandlordId = 5 },
                new { Id = 6, Rooms = 2, Description = "Charming townhouse in a historic district", Features = Features.Wifi, SubTitle = "Experience the history", NumberOfGuests = 4, Title = "Historic Townhouse", Type = LocationType.House, PricePerDay = 90.0F, LandlordId = 1 },
                new { Id = 7, Rooms = 3, Description = "Modern chalet with mountain views", Features = Features.PetsAllowed | Features.TV, SubTitle = "Perfect for a getaway", NumberOfGuests = 6, Title = "Mountain Chalet", Type = LocationType.Chalet, PricePerDay = 200.0F, LandlordId = 2 },
                new { Id = 8, Rooms = 1, Description = "Cozy studio in the heart of the city", Features = Features.Wifi, SubTitle = "Ideal for solo travelers", NumberOfGuests = 2, Title = "City Studio", Type = LocationType.Appartment, PricePerDay = 60.0F, LandlordId = 3 },
                new { Id = 9, Rooms = 4, Description = "Spacious house with garden", Features = Features.PetsAllowed | Features.Breakfast, SubTitle = "Perfect for families", NumberOfGuests = 8, Title = "Family House", Type = LocationType.House, PricePerDay = 150.0F, LandlordId = 4 },
                new { Id = 10, Rooms = 6, Description = "Historic castle with modern amenities", Features = Features.Bath | Features.TV | Features.Wifi, SubTitle = "Live like royalty", NumberOfGuests = 12, Title = "Modern Castle", Type = LocationType.House, PricePerDay = 350.0F, LandlordId = 5 }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new { Id = 1, Discount = 0.1f, StartDate = new DateTime(2024, 5, 1), EndDate = new DateTime(2024, 5, 5), LocationId = 1, CustomerId = 1 },
                new { Id = 2, Discount = 0.0f, StartDate = new DateTime(2024, 6, 10), EndDate = new DateTime(2024, 6, 15), LocationId = 2, CustomerId = 2 },
                new { Id = 3, Discount = 0.2f, StartDate = new DateTime(2024, 7, 1), EndDate = new DateTime(2024, 7, 10), LocationId = 3, CustomerId = 3 },
                new { Id = 4, Discount = 0.15f, StartDate = new DateTime(2024, 8, 15), EndDate = new DateTime(2024, 8, 20), LocationId = 4, CustomerId = 1 },
                new { Id = 5, Discount = 0.1f, StartDate = new DateTime(2024, 9, 5), EndDate = new DateTime(2024, 9, 12), LocationId = 5, CustomerId = 2 }
            );

            modelBuilder.Entity<Image>().HasData(
                new { Id = 1, IsCover = false, Url = "https://images.pexels.com/photos/4626807/pexels-photo-4626807.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                new { Id = 2, IsCover = false, Url = "https://images.pexels.com/photos/4588043/pexels-photo-4588043.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                new { Id = 3, IsCover = false, Url = "https://images.pexels.com/photos/3789871/pexels-photo-3789871.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                new { Id = 4, IsCover = false, Url = "https://images.pexels.com/photos/3687061/pexels-photo-3687061.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                new { Id = 5, IsCover = false, Url = "https://images.pexels.com/photos/4099585/pexels-photo-4099585.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
                new { Id = 6, IsCover = true, Url = "https://images.pexels.com/photos/2998307/pexels-photo-2998307.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 1 },
                new { Id = 7, IsCover = true, Url = "https://images.pexels.com/photos/1459493/pexels-photo-1459493.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 2 },
                new { Id = 8, IsCover = true, Url = "https://images.pexels.com/photos/279746/pexels-photo-279746.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 3 },
                new { Id = 9, IsCover = true, Url = "https://images.pexels.com/photos/2102587/pexels-photo-2102587.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 4 },
                new { Id = 10, IsCover = true, Url = "https://images.pexels.com/photos/2118125/pexels-photo-2118125.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 5 },
                new { Id = 11, IsCover = true, Url = "https://images.pexels.com/photos/4325436/pexels-photo-4325436.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 6 },
                new { Id = 12, IsCover = true, Url = "https://images.pexels.com/photos/2433061/pexels-photo-2433061.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 7 },
                new { Id = 13, IsCover = true, Url = "https://images.pexels.com/photos/1759895/pexels-photo-1759895.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 8 },
                new { Id = 14, IsCover = true, Url = "https://images.pexels.com/photos/1282315/pexels-photo-1282315.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 9 },
                new { Id = 15, IsCover = true, Url = "https://images.pexels.com/photos/205827/pexels-photo-205827.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 10 },
                new { Id = 16, IsCover = false, Url = "https://images.pexels.com/photos/2050994/pexels-photo-2050994.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 1 },
                new { Id = 17, IsCover = false, Url = "https://images.pexels.com/photos/2179213/pexels-photo-2179213.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 1 },
                new { Id = 18, IsCover = false, Url = "https://images.pexels.com/photos/2194262/pexels-photo-2194262.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 5 },
                new { Id = 19, IsCover = false, Url = "https://images.pexels.com/photos/3117091/pexels-photo-3117091.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 5 },
                new { Id = 20, IsCover = false, Url = "https://images.pexels.com/photos/39866/pexels-photo-39866.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 9 },
                new { Id = 21, IsCover = false, Url = "https://images.pexels.com/photos/235647/pexels-photo-235647.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 6 },
                new { Id = 22, IsCover = false, Url = "https://images.pexels.com/photos/1105766/pexels-photo-1105766.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 8 },
                new { Id = 23, IsCover = false, Url = "https://images.pexels.com/photos/1961457/pexels-photo-1961457.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 10 }
            );
        }


    }
}