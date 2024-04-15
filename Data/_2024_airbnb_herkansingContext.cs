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



        // Add a new Seed method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            // Deze seeding heb ik overgenomen van een van de voorbeelden van Tom Siever (project CheckjeAdvanced)
            modelBuilder.Entity<Landlord>().HasData(
                new { LandlordId = 1, FirstName = "Peter-Jan", LastName = "Balkenende", Age = 33, AvatarId = 4 },
                new { LandlordId = 2, FirstName = "Jan", LastName = "de Man", Age = 20, AvatarId = 2 },
                new { LandlordId = 3, FirstName = "Sandra", LastName = "Vries", Age = 25, AvatarId = 7 }
            );

            modelBuilder.Entity<Location>().HasData(
                new { LocationId = 1, Rooms = 2, Title = "De Boerenhoeve", SubTitle = "Lekker veel ruimte", PricePerDay = 75f, Features = Features.Wifi, Description = "This modern and stylish apartment is located right in the heart of the city. With its spacious living area, fully equipped kitchen, and luxurious bathroom, it's the perfect home away from home.", Type = LocationType.Appartment, NumberOfGuests = 4, LandlordId = 1 },
                new { LocationId = 2, Rooms = 3, Title = "Frankie's Penthouse", SubTitle = "Te gek uitzicht", PricePerDay = 100f, Features = Features.Wifi | Features.Bath, Description = "Escape the hustle and bustle of the city and unwind in this beautiful cottage surrounded by nature. With its cozy fireplace, comfortable bedrooms, and fully equipped kitchen, you'll have everything you need for a relaxing and enjoyable stay.", Type = LocationType.Cottage, NumberOfGuests = 6, LandlordId = 2 },
                new { LocationId = 3, Rooms = 1, Title = "Seaside Getaway", SubTitle = "Relax by the beach", PricePerDay = 90f, Features = Features.Breakfast | Features.Smoking, Description = "Experience the ultimate beach vacation in this stunning seaside getaway. Enjoy breathtaking ocean views, luxurious amenities, and direct access to the beach.", Type = LocationType.Appartment, NumberOfGuests = 2, LandlordId = 1, },
                new { LocationId = 4, Rooms = 2, Title = "Mountain Retreat", SubTitle = "Escape to nature", PricePerDay = 120f, Features = Features.Bath, Description = "Surrounded by majestic mountains, this cozy retreat offers a peaceful and idyllic setting. Explore hiking trails, enjoy outdoor activities, or simply relax in the comfort of your mountain getaway.", Type = LocationType.Cottage, NumberOfGuests = 4, LandlordId = 3 },
                new { LocationId = 5, Rooms = 3, Title = "City Oasis", SubTitle = "Urban luxury", PricePerDay = 150f, Features = Features.Wifi | Features.TV | Features.Breakfast, Description = "Indulge in the vibrant city life while enjoying the comfort of this stylish urban oasis. With its modern design, top-notch amenities, and convenient location, it's the perfect choice for your city adventure.", Type = LocationType.Appartment, NumberOfGuests = 3, LandlordId = 3 },
                new { LocationId = 6, Rooms = 2, Title = "Rustic Farmhouse", SubTitle = "A taste of country living", PricePerDay = 80f, Features = Features.Bath | Features.Breakfast, Description = "Experience the charm of country living in this beautiful rustic farmhouse. Surrounded by rolling hills and lush greenery, it's the perfect retreat for those seeking peace and tranquility.", Type = LocationType.Room, NumberOfGuests = 5, LandlordId = 1 },
                new { LocationId = 7, Rooms = 1, Title = "Cozy Studio", SubTitle = "City center convenience", PricePerDay = 60f, Features = Features.Smoking | Features.PetsAllowed | Features.Wifi, Description = "Stay in the heart of the city in this cozy studio apartment. Enjoy easy access to restaurants, shops, and attractions, and experience the vibrant energy of the city.", Type = LocationType.Appartment, NumberOfGuests = 2, LandlordId = 2 },
                new { LocationId = 8, Rooms = 3, Title = "Lakefront Cottage", SubTitle = "Unwind by the lake", PricePerDay = 110f, Features = Features.PetsAllowed | Features.Wifi | Features.TV, Description = "Escape to this charming lakefront cottage and immerse yourself in the serenity of nature. Relax on the private dock, go fishing, or simply enjoy the breathtaking views of the tranquil lake.", Type = LocationType.House, NumberOfGuests = 6, LandlordId = 3 },
                new { LocationId = 9, Rooms = 2, Title = "Modern Loft", SubTitle = "Industrial chic", PricePerDay = 95f, Features = Features.Wifi | Features.Bath | Features.TV, Description = "Step into this stylish and modern loft and be captivated by its industrial chic design. With its open floor plan, high ceilings, and state-of-the-art amenities, it's the perfect urban retreat.", Type = LocationType.Hotel, NumberOfGuests = 4, LandlordId = 1 },
                new { LocationId = 10, Rooms = 3, Title = "Luxury Villa", SubTitle = "Exquisite elegance", PricePerDay = 250f, Features = Features.Wifi | Features.TV | Features.Breakfast, Description = "Indulge in the lap of luxury in this breathtaking villa. With its lavish interiors, private pool, and impeccable service, it offers an unforgettable experience of pure elegance and opulence.", Type = LocationType.Chalet, NumberOfGuests = 8, LandlordId = 2 }
            );

            modelBuilder.Entity<Customer>().HasData(
                new { CustomerId = 1, Email = "john.doe@example.com", FirstName = "John", LastName = "Doe" },
                new { CustomerId = 2, Email = "jane.doe@example.com", FirstName = "Jane", LastName = "Doe" }
            );

            modelBuilder.Entity<Reservation>().HasData(
                new { ReservationId = 1, Discount = 0.1f, StartDate = new DateTime(2023, 5, 1), EndDate = new DateTime(2023, 5, 5), LocationId = 1, CustomerId = 1 },
                new { ReservationId = 2, Discount = 0.0f, StartDate = new DateTime(2023, 6, 10), EndDate = new DateTime(2023, 6, 15), LocationId = 2, CustomerId = 2 },
                new { ReservationId = 3, Discount = 0.2f, StartDate = new DateTime(2023, 7, 1), EndDate = new DateTime(2023, 7, 10), LocationId = 1, CustomerId = 1 },
                new { ReservationId = 4, Discount = 0.15f, StartDate = new DateTime(2023, 8, 15), EndDate = new DateTime(2023, 8, 20), LocationId = 1, CustomerId = 2 }
            );

            modelBuilder.Entity<Image>().HasData(
              new { ImageId = 1, Url = "https://media.architecturaldigest.com/photos/5a30296738bb817b7ffe1b4b/3:2/w_1023,h_682,c_limit/Airbnb_Georgia3.jpg", IsCover = true, LocationId = 2 },
              new { ImageId = 2, Url = "https://www.adobe.com/nl/express/create/media_1bcd514348a568faed99e65f5249895e38b06c947.jpeg?width=400&format=jpeg&optimize=medium", IsCover = false, LocationId = 2 }, //avatar for landlord
              new { ImageId = 3, Url = "https://www.myglobalviewpoint.com/wp-content/uploads/2020/11/Best-Airbnbs-in-the-World-Featured-Image.jpg", IsCover = true, LocationId = 1 },
              new { ImageId = 4, Url = "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?cs=srgb&dl=pexels-pixabay-220453.jpg&fm=jpg", IsCover = false, LocationId = 1 }, //avatar for landlord
              new { ImageId = 5, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/MaisonCausapscal.JPG/640px-MaisonCausapscal.JPG", IsCover = false, LocationId = 1 },
              new { ImageId = 6, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/Ljungris_July_2013.jpg/640px-Ljungris_July_2013.jpg", IsCover = false, LocationId = 2 },
              new { ImageId = 7, Url = "https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8cmFuZG9tJTIwcGVyc29ufGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60", IsCover = false, LocationId = 3 }, //avatar for landlord
              new { ImageId = 8, Url = "https://images.unsplash.com/photo-1600585154340-be6161a56a0c?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60", IsCover = true, LocationId = 3 },
              new { ImageId = 9, Url = "https://images.unsplash.com/photo-1502005097973-6a7082348e28?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8aW5zaWRlJTIwaG91c2V8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60", IsCover = false, LocationId = 3 },
              new { ImageId = 10, Url = "https://images.unsplash.com/photo-1600047509807-ba8f99d2cdde?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60", IsCover = true, LocationId = 4 },
              new { ImageId = 11, Url = "https://images.unsplash.com/photo-1591247378418-c77f1532d2f8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8aW5zaWRlJTIwaG91c2V8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60", IsCover = false, LocationId = 4 },
              new { ImageId = 12, Url = "https://images.unsplash.com/photo-1605146769289-440113cc3d00?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60", IsCover = true, LocationId = 5 },
              new { ImageId = 13, Url = "https://images.unsplash.com/photo-1629079448105-35ab3e5152d4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTF8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60", IsCover = false, LocationId = 5 },
              new { ImageId = 14, Url = "https://images.unsplash.com/photo-1602343168117-bb8ffe3e2e9f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTJ8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60", IsCover = true, LocationId = 6 },
              new { ImageId = 15, Url = "https://images.unsplash.com/photo-1501685532562-aa6846b14a0e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60", IsCover = false, LocationId = 6 },
              new { ImageId = 16, Url = "https://images.unsplash.com/photo-1430285561322-7808604715df?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60", IsCover = true, LocationId = 7 },
              new { ImageId = 17, Url = "https://images.unsplash.com/photo-1611145367596-364abefb1f9f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTZ8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60", IsCover = false, LocationId = 7 },
              new { ImageId = 18, Url = "https://images.unsplash.com/photo-1600047509358-9dc75507daeb?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjR8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60", IsCover = true, LocationId = 8 },
              new { ImageId = 19, Url = "https://images.unsplash.com/photo-1607582544644-f1da2a004994?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjB8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60", IsCover = false, LocationId = 8 },
              new { ImageId = 20, Url = "https://images.unsplash.com/photo-1588012886079-baef0ac45fbd?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzB8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60", IsCover = true, LocationId = 9 },
              new { ImageId = 21, Url = "https://images.unsplash.com/photo-1484301548518-d0e0a5db0fc8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mjl8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60", IsCover = false, LocationId = 9 },
              new { ImageId = 22, Url = "https://images.unsplash.com/photo-1600607688969-a5bfcd646154?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzZ8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60", IsCover = true, LocationId = 10 },
              new { ImageId = 23, Url = "https://images.unsplash.com/photo-1599619351208-3e6c839d6828?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzR8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60", IsCover = false, LocationId = 10 }
          );
        }
    }
}