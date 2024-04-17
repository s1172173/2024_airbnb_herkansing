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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Deze seeding heb ik gebaseerd op een van de voorbeelden van Tom Siever (project CheckjeAdvanced) en de seeding van Max Metz,
            // Als dit als plagiaat wordt herkent is dat volledig de fout van Nick Bergmans en niet de eerder benoemde namen.

            modelBuilder.Entity<Image>().HasOne(i => i.Landlord).WithOne(l => l.Avatar).HasForeignKey<Landlord>(i => i.AvatarId);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
             new { Id = 1, FirstName = "Nick", LastName = "Bergmans", Email = "nick.bergmans@gmail.com" },
             new { Id = 2, FirstName = "Test", LastName = "Tester", Email = "test.tester@gmail.com" }
                );

            modelBuilder.Entity<Landlord>().HasData(
               new { Id = 1, FirstName = "Ren", LastName = "Traveller", Age = 19, AvatarId = 1 },
               new { Id = 2, FirstName = "Bob", LastName = "Bouwer", Age = 29, AvatarId = 2 },
               new { Id = 3, FirstName = "Charles ", LastName = "Xavier", Age = 35, AvatarId = 3 },
               new { Id = 4, FirstName = "Peter ", LastName = "Parker", Age = 45, AvatarId = 4 },
               new { Id = 5, FirstName = "Iron ", LastName = "de Man", Age = 26, AvatarId = 5 }
               );


            modelBuilder.Entity<Location>().HasData(
                new { Id = 1, Rooms = 2, Description = "Brand new hotel in the heart of the city", Features = Features.Breakfast | Features.Wifi, SubTitle = "Just steps away from the old city center", NumberOfGuests = 4, Title = "New City Hotel", Type = LocationType.Hotel, PricePerDay = 74.99F, LandlordId = 1, ImageId = 6 },
                new { Id = 2, Rooms = 3, Description = "Detached house in a peaceful neighborhood surrounded by nature", Features = Features.PetsAllowed | Features.Wifi, SubTitle = "Enjoy the beautiful greenery in this serene environment", NumberOfGuests = 6, Title = "Detached House", Type = LocationType.House, PricePerDay = 50F, LandlordId = 1, ImageId = 4 },
                new { Id = 3, Rooms = 4, Description = "Large old house with a stunning lakeside location", Features = Features.Smoking | Features.PetsAllowed, SubTitle = "A beautiful 19th-century house by the water", NumberOfGuests = 8, Title = "Lakeside Villa", Type = LocationType.House, PricePerDay = 88.5F, LandlordId = 2, ImageId = 5 },
                new { Id = 4, Rooms = 1, Description = "Room in an apartment complex", Features = Features.TV, SubTitle = "Double room in Barcelona", NumberOfGuests = 2, Title = "Double Room", Type = LocationType.Room, PricePerDay = 58.33F, LandlordId = 3, ImageId = 6 },
                new { Id = 5, Rooms = 10, Description = "Luxurious villa with a pool and spacious garden", Features = Features.Wifi | Features.TV | Features.Bath, SubTitle = "Perfect villa for a wonderful vacation with friends or family", NumberOfGuests = 15, Title = "Luxury Villa Milan", Type = LocationType.House, PricePerDay = 399.5F, LandlordId = 4, ImageId = 7 },
                new { Id = 6, Rooms = 3, Description = "Family home for starters in Almere", Features = Features.PetsAllowed, SubTitle = "A good starter home with easy commute", NumberOfGuests = 4, Title = "Almere Townhouse", Type = LocationType.House, PricePerDay = 25F, LandlordId = 5, ImageId = 8 },
                new { Id = 7, Rooms = 4, Description = "Villa overlooking the coast in Kijkduin", Features = Features.TV, SubTitle = "Perfect for summer vacation in the Netherlands", NumberOfGuests = 8, Title = "Beachside Villa", Type = LocationType.Chalet, PricePerDay = 66.65F, LandlordId = 1, ImageId = 9 },
                new { Id = 8, Rooms = 8, Description = "Historic castle in the inland of France", Features = Features.Bath | Features.PetsAllowed, SubTitle = "Stay here like royalty", NumberOfGuests = 12, Title = "Castle in France", Type = LocationType.House, PricePerDay = 420.1F, LandlordId = 5, ImageId = 10 },
                new { Id = 9, Rooms = 2, Description = "Luxurious room in the most beautiful city in the Netherlands", Features = Features.Wifi, SubTitle = "Explore Amsterdam and enjoy the city's offerings", NumberOfGuests = 5, Title = "Amsterdam Apartment", Type = LocationType.Appartment, PricePerDay = 500F, LandlordId = 1, ImageId = 11 },
                new { Id = 10, Rooms = 4, Description = "Old restored windmill with 4 rooms", Features = Features.TV | Features.Wifi, SubTitle = "Authentic windmill used for cheese making", NumberOfGuests = 8, Title = "Old Windmill", Type = LocationType.Cottage, PricePerDay = 140F, LandlordId = 2, ImageId = 12 }
            );



            modelBuilder.Entity<Reservation>().HasData(
                new { Id = 1, Discount = 0.1f, StartDate = new DateTime(2024, 5, 1), EndDate = new DateTime(2023, 5, 5), LocationId = 1, CustomerId = 1 },
                new { Id = 2, Discount = 0.0f, StartDate = new DateTime(2024, 6, 10), EndDate = new DateTime(2023, 6, 15), LocationId = 2, CustomerId = 2 },
                new { Id = 3, Discount = 0.2f, StartDate = new DateTime(2024, 7, 1), EndDate = new DateTime(2023, 7, 10), LocationId = 1, CustomerId = 1 },
                new { Id = 4, Discount = 0.15f, StartDate = new DateTime(2024, 8, 15), EndDate = new DateTime(2023, 8, 20), LocationId = 1, CustomerId = 2 }
            );

            modelBuilder.Entity<Image>().HasData(
               new { Id = 1, IsCover = false, Url = "https://images.pexels.com/photos/1681010/pexels-photo-1681010.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
               new { Id = 2, IsCover = false, Url = "https://images.pexels.com/photos/733872/pexels-photo-733872.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
               new { Id = 3, IsCover = false, Url = "https://images.pexels.com/photos/91227/pexels-photo-91227.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
               new { Id = 4, IsCover = false, Url = "https://images.pexels.com/photos/874158/pexels-photo-874158.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
               new { Id = 5, IsCover = false, Url = "https://images.pexels.com/photos/1212984/pexels-photo-1212984.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2" },
               new { Id = 6, IsCover = true, Url = "https://images.pexels.com/photos/2462015/pexels-photo-2462015.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 1 },
               new { Id = 7, IsCover = true, Url = "https://images.pexels.com/photos/259588/pexels-photo-259588.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 2 },
               new { Id = 8, IsCover = true, Url = "https://images.pexels.com/photos/1438832/pexels-photo-1438832.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 3 },
               new { Id = 9, IsCover = true, Url = "https://images.pexels.com/photos/2681205/pexels-photo-2681205.jpeg", LocationId = 4 },
               new { Id = 10, IsCover = true, Url = "https://images.pexels.com/photos/5563472/pexels-photo-5563472.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 5 },
               new { Id = 11, IsCover = true, Url = "https://cdn.cbs.nl/images/6c544435792f56565844344b67534e686f3964532b413d3d/900x450.jpg", LocationId = 6 },
               new { Id = 12, IsCover = true, Url = "https://images.pexels.com/photos/1131573/pexels-photo-1131573.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 7 },
               new { Id = 13, IsCover = true, Url = "https://images.pexels.com/photos/18705895/pexels-photo-18705895/free-photo-of-exterior-of-a-castle.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 8 },
               new { Id = 14, IsCover = true, Url = "https://images.pexels.com/photos/1329510/pexels-photo-1329510.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 9 },
               new { Id = 15, IsCover = true, Url = "https://images.pexels.com/photos/161123/windmill-water-church-agriculture-161123.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 10 },
               new { Id = 16, IsCover = false, Url = "https://images.pexels.com/photos/1643384/pexels-photo-1643384.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 1 },
               new { Id = 17, IsCover = false, Url = "https://images.pexels.com/photos/1428348/pexels-photo-1428348.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 1 },
               new { Id = 18, IsCover = false, Url = "https://images.pexels.com/photos/870170/pexels-photo-870170.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 5 },
               new { Id = 19, IsCover = false, Url = "https://images.pexels.com/photos/984619/pexels-photo-984619.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 5 },
               new { Id = 20, IsCover = false, Url = "https://images.pexels.com/photos/4237154/pexels-photo-4237154.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 9 },
               new { Id = 21, IsCover = false, Url = "https://images.pexels.com/photos/2098913/pexels-photo-2098913.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 6 },
               new { Id = 22, IsCover = false, Url = "https://images.pexels.com/photos/2954929/pexels-photo-2954929.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 8 },
               new { Id = 23, IsCover = false, Url = "https://images.pexels.com/photos/2449549/pexels-photo-2449549.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2", LocationId = 10 }
                 );
        }
    }
}