﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2024_airbnb_herkansing.Data;

#nullable disable

namespace _2024_airbnb_herkansing.Migrations
{
    [DbContext(typeof(_2024_airbnb_herkansingContext))]
    [Migration("20240414121939_init_migration5")]
    partial class init_migration5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "jane.doe@example.com",
                            FirstName = "Jane",
                            LastName = "Doe"
                        });
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsCover")
                        .HasColumnType("bit");

                    b.Property<int?>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageId");

                    b.HasIndex("LandlordId");

                    b.HasIndex("LocationId");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            ImageId = 1,
                            IsCover = true,
                            LocationId = 2,
                            Url = "https://media.architecturaldigest.com/photos/5a30296738bb817b7ffe1b4b/3:2/w_1023,h_682,c_limit/Airbnb_Georgia3.jpg"
                        },
                        new
                        {
                            ImageId = 2,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://www.adobe.com/nl/express/create/media_1bcd514348a568faed99e65f5249895e38b06c947.jpeg?width=400&format=jpeg&optimize=medium"
                        },
                        new
                        {
                            ImageId = 3,
                            IsCover = true,
                            LocationId = 1,
                            Url = "https://www.myglobalviewpoint.com/wp-content/uploads/2020/11/Best-Airbnbs-in-the-World-Featured-Image.jpg"
                        },
                        new
                        {
                            ImageId = 4,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg?cs=srgb&dl=pexels-pixabay-220453.jpg&fm=jpg"
                        },
                        new
                        {
                            ImageId = 5,
                            IsCover = false,
                            LocationId = 1,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/80/MaisonCausapscal.JPG/640px-MaisonCausapscal.JPG"
                        },
                        new
                        {
                            ImageId = 6,
                            IsCover = false,
                            LocationId = 2,
                            Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/Ljungris_July_2013.jpg/640px-Ljungris_July_2013.jpg"
                        },
                        new
                        {
                            ImageId = 7,
                            IsCover = false,
                            LocationId = 3,
                            Url = "https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8cmFuZG9tJTIwcGVyc29ufGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 8,
                            IsCover = true,
                            LocationId = 3,
                            Url = "https://images.unsplash.com/photo-1600585154340-be6161a56a0c?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 9,
                            IsCover = false,
                            LocationId = 3,
                            Url = "https://images.unsplash.com/photo-1502005097973-6a7082348e28?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mnx8aW5zaWRlJTIwaG91c2V8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 10,
                            IsCover = true,
                            LocationId = 4,
                            Url = "https://images.unsplash.com/photo-1600047509807-ba8f99d2cdde?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8NHx8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 11,
                            IsCover = false,
                            LocationId = 4,
                            Url = "https://images.unsplash.com/photo-1591247378418-c77f1532d2f8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8aW5zaWRlJTIwaG91c2V8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 12,
                            IsCover = true,
                            LocationId = 5,
                            Url = "https://images.unsplash.com/photo-1605146769289-440113cc3d00?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8aG91c2VzfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 13,
                            IsCover = false,
                            LocationId = 5,
                            Url = "https://images.unsplash.com/photo-1629079448105-35ab3e5152d4?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTF8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 14,
                            IsCover = true,
                            LocationId = 6,
                            Url = "https://images.unsplash.com/photo-1602343168117-bb8ffe3e2e9f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTJ8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 15,
                            IsCover = false,
                            LocationId = 6,
                            Url = "https://images.unsplash.com/photo-1501685532562-aa6846b14a0e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 16,
                            IsCover = true,
                            LocationId = 7,
                            Url = "https://images.unsplash.com/photo-1430285561322-7808604715df?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTV8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 17,
                            IsCover = false,
                            LocationId = 7,
                            Url = "https://images.unsplash.com/photo-1611145367596-364abefb1f9f?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTZ8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 18,
                            IsCover = true,
                            LocationId = 8,
                            Url = "https://images.unsplash.com/photo-1600047509358-9dc75507daeb?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjR8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 19,
                            IsCover = false,
                            LocationId = 8,
                            Url = "https://images.unsplash.com/photo-1607582544644-f1da2a004994?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MjB8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 20,
                            IsCover = true,
                            LocationId = 9,
                            Url = "https://images.unsplash.com/photo-1588012886079-baef0ac45fbd?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzB8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 21,
                            IsCover = false,
                            LocationId = 9,
                            Url = "https://images.unsplash.com/photo-1484301548518-d0e0a5db0fc8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Mjl8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 22,
                            IsCover = true,
                            LocationId = 10,
                            Url = "https://images.unsplash.com/photo-1600607688969-a5bfcd646154?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzZ8fGhvdXNlc3xlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60"
                        },
                        new
                        {
                            ImageId = 23,
                            IsCover = false,
                            LocationId = 10,
                            Url = "https://images.unsplash.com/photo-1599619351208-3e6c839d6828?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MzR8fGluc2lkZSUyMGhvdXNlfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                        });
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Landlord", b =>
                {
                    b.Property<int>("LandlordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LandlordId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("AvatarId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LandlordId");

                    b.HasIndex("AvatarId");

                    b.ToTable("Landlord");

                    b.HasData(
                        new
                        {
                            LandlordId = 1,
                            Age = 33,
                            AvatarId = 4,
                            FirstName = "Peter-Jan",
                            LastName = "Balkenende"
                        },
                        new
                        {
                            LandlordId = 2,
                            Age = 20,
                            AvatarId = 2,
                            FirstName = "Jan",
                            LastName = "de Man"
                        },
                        new
                        {
                            LandlordId = 3,
                            Age = 25,
                            AvatarId = 7,
                            FirstName = "Sandra",
                            LastName = "Vries"
                        });
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Features")
                        .HasColumnType("int");

                    b.Property<int?>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<float>("PricePerDay")
                        .HasColumnType("real");

                    b.Property<int>("Rooms")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Type")
                        .HasColumnType("int");

                    b.HasKey("LocationId");

                    b.HasIndex("LandlordId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Description = "This modern and stylish apartment is located right in the heart of the city. With its spacious living area, fully equipped kitchen, and luxurious bathroom, it's the perfect home away from home.",
                            Features = 4,
                            LandlordId = 1,
                            NumberOfGuests = 4,
                            PricePerDay = 75f,
                            Rooms = 2,
                            SubTitle = "Lekker veel ruimte",
                            Title = "De Boerenhoeve",
                            Type = 0
                        },
                        new
                        {
                            LocationId = 2,
                            Description = "Escape the hustle and bustle of the city and unwind in this beautiful cottage surrounded by nature. With its cozy fireplace, comfortable bedrooms, and fully equipped kitchen, you'll have everything you need for a relaxing and enjoyable stay.",
                            Features = 20,
                            LandlordId = 2,
                            NumberOfGuests = 6,
                            PricePerDay = 100f,
                            Rooms = 3,
                            SubTitle = "Te gek uitzicht",
                            Title = "Frankie's Penthouse",
                            Type = 1
                        },
                        new
                        {
                            LocationId = 3,
                            Description = "Experience the ultimate beach vacation in this stunning seaside getaway. Enjoy breathtaking ocean views, luxurious amenities, and direct access to the beach.",
                            Features = 33,
                            LandlordId = 1,
                            NumberOfGuests = 2,
                            PricePerDay = 90f,
                            Rooms = 1,
                            SubTitle = "Relax by the beach",
                            Title = "Seaside Getaway",
                            Type = 0
                        },
                        new
                        {
                            LocationId = 4,
                            Description = "Surrounded by majestic mountains, this cozy retreat offers a peaceful and idyllic setting. Explore hiking trails, enjoy outdoor activities, or simply relax in the comfort of your mountain getaway.",
                            Features = 16,
                            LandlordId = 3,
                            NumberOfGuests = 4,
                            PricePerDay = 120f,
                            Rooms = 2,
                            SubTitle = "Escape to nature",
                            Title = "Mountain Retreat",
                            Type = 1
                        },
                        new
                        {
                            LocationId = 5,
                            Description = "Indulge in the vibrant city life while enjoying the comfort of this stylish urban oasis. With its modern design, top-notch amenities, and convenient location, it's the perfect choice for your city adventure.",
                            Features = 44,
                            LandlordId = 3,
                            NumberOfGuests = 3,
                            PricePerDay = 150f,
                            Rooms = 3,
                            SubTitle = "Urban luxury",
                            Title = "City Oasis",
                            Type = 0
                        },
                        new
                        {
                            LocationId = 6,
                            Description = "Experience the charm of country living in this beautiful rustic farmhouse. Surrounded by rolling hills and lush greenery, it's the perfect retreat for those seeking peace and tranquility.",
                            Features = 48,
                            LandlordId = 1,
                            NumberOfGuests = 5,
                            PricePerDay = 80f,
                            Rooms = 2,
                            SubTitle = "A taste of country living",
                            Title = "Rustic Farmhouse",
                            Type = 3
                        },
                        new
                        {
                            LocationId = 7,
                            Description = "Stay in the heart of the city in this cozy studio apartment. Enjoy easy access to restaurants, shops, and attractions, and experience the vibrant energy of the city.",
                            Features = 7,
                            LandlordId = 2,
                            NumberOfGuests = 2,
                            PricePerDay = 60f,
                            Rooms = 1,
                            SubTitle = "City center convenience",
                            Title = "Cozy Studio",
                            Type = 0
                        },
                        new
                        {
                            LocationId = 8,
                            Description = "Escape to this charming lakefront cottage and immerse yourself in the serenity of nature. Relax on the private dock, go fishing, or simply enjoy the breathtaking views of the tranquil lake.",
                            Features = 14,
                            LandlordId = 3,
                            NumberOfGuests = 6,
                            PricePerDay = 110f,
                            Rooms = 3,
                            SubTitle = "Unwind by the lake",
                            Title = "Lakefront Cottage",
                            Type = 5
                        },
                        new
                        {
                            LocationId = 9,
                            Description = "Step into this stylish and modern loft and be captivated by its industrial chic design. With its open floor plan, high ceilings, and state-of-the-art amenities, it's the perfect urban retreat.",
                            Features = 28,
                            LandlordId = 1,
                            NumberOfGuests = 4,
                            PricePerDay = 95f,
                            Rooms = 2,
                            SubTitle = "Industrial chic",
                            Title = "Modern Loft",
                            Type = 4
                        },
                        new
                        {
                            LocationId = 10,
                            Description = "Indulge in the lap of luxury in this breathtaking villa. With its lavish interiors, private pool, and impeccable service, it offers an unforgettable experience of pure elegance and opulence.",
                            Features = 44,
                            LandlordId = 2,
                            NumberOfGuests = 8,
                            PricePerDay = 250f,
                            Rooms = 3,
                            SubTitle = "Exquisite elegance",
                            Title = "Luxury Villa",
                            Type = 2
                        });
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("LocationId");

                    b.ToTable("Reservation");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            CustomerId = 1,
                            Discount = 0.1f,
                            EndDate = new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StartDate = new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReservationId = 2,
                            CustomerId = 2,
                            Discount = 0f,
                            EndDate = new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 2,
                            StartDate = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReservationId = 3,
                            CustomerId = 1,
                            Discount = 0.2f,
                            EndDate = new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StartDate = new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ReservationId = 4,
                            CustomerId = 2,
                            Discount = 0.15f,
                            EndDate = new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 1,
                            StartDate = new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Image", b =>
                {
                    b.HasOne("_2024_airbnb_herkansing.Models.Landlord", "Landlord")
                        .WithMany()
                        .HasForeignKey("LandlordId");

                    b.HasOne("_2024_airbnb_herkansing.Models.Location", "Location")
                        .WithMany("Images")
                        .HasForeignKey("LocationId");

                    b.Navigation("Landlord");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Landlord", b =>
                {
                    b.HasOne("_2024_airbnb_herkansing.Models.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Location", b =>
                {
                    b.HasOne("_2024_airbnb_herkansing.Models.Landlord", "Landlord")
                        .WithMany("Locations")
                        .HasForeignKey("LandlordId");

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Reservation", b =>
                {
                    b.HasOne("_2024_airbnb_herkansing.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("_2024_airbnb_herkansing.Models.Location", "Location")
                        .WithMany("Reservations")
                        .HasForeignKey("LocationId");

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Landlord", b =>
                {
                    b.Navigation("Locations");
                });

            modelBuilder.Entity("_2024_airbnb_herkansing.Models.Location", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
