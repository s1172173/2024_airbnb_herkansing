/*namespace _2024_airbnb_herkansing.Models
{
    public class SeedData
    {
        // Customer Seeding
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

        // Image Seeding
        public static class ImageSeed
        {
            public static Image[] GetImages()
            {
                return [
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
                        ImageId = 3,
                        Url = "image_location_2.jpg",
                        Description = "Image of location 2",
                        IsCover = true,
                    },
                ];

            }

            // Landlord Seeding
            public static class LandlordSeed
            {
                public static Landlord[] GetLandlords()
                {
                    return [
                        new Landlord
                        {
                            FirstName = "Landlord 1",
                            LastName = "Lastname 1",
                            Age = 35,
                            Avatar = new Image { ImageId = 1 },
                            Locations = new Location { LocationId = 1 }
                        },
                        new Landlord
                        {
                            FirstName = "Landlord 2",
                            LastName = "Lastname 2",
                            Age = 45,
                            Avatar = new Image { ImageId = 2 },
                            Locations = new Location { LocationId = 2 }
                        },
                    ];
                }
            }

            // Location Seeding
            public static class LocationSeed
            {
                public static Location[] GetLocations()
                {
                    return
                    [
                        new Location
                        {
                            LocationId = 1,
                            Title = "De Boerenhoeve",
                            SubTitle = "Lekker veel ruimte",
                            Description = "De camping ligt verscholen achter de boerderij in de polder. Op fietsafstand (5 minuten) liggen het dorpje Nieuwvliet, de zee, het strand, het bos van Erasmus en het natuurgebied de Knokkert.",
                            Type = LocationType.Cottage,
                            Rooms = 1,
                            NumberOfGuests = 2,
                            Features = Features.Wifi,
                            PricePerDay = 100,
                            Images = new Image { ImageId = 3 },
                            Landlord = new Landlord { LandlordId = 1 },
                            Reservations = null,
                        },
                        new Location
                        {
                            LocationId = 2,
                            Title = "Location 2",
                            SubTitle = "Subtitle 4",
                            Description = "Description 4",
                            Type = LocationType.Appartment,
                            Rooms = 1,
                            NumberOfGuests = 2,
                            Features = Features.Wifi,
                            PricePerDay = 100,
                            Images = new Image { ImageId = 3 },
                            Landlord = new Landlord { LandlordId = 2 },
                            Reservations = null,
                        }
                    ];
                }
            }

            // Reservation Seeding
            public static class ReservationSeed
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
            }

        }
    }
}
*/