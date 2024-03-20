using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2024_airbnb_herkansing.Models;

namespace _2024_airbnb_herkansing.Data
{
    public class _2024_airbnb_herkansingContext : DbContext
    {
        public _2024_airbnb_herkansingContext (DbContextOptions<_2024_airbnb_herkansingContext> options)
            : base(options)
        {
        }

        public DbSet<_2024_airbnb_herkansing.Models.Landlord> Landlord { get; set; } = default!;
        public DbSet<_2024_airbnb_herkansing.Models.Location> Location { get; set; } = default!;
    }
}
