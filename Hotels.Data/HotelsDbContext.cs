using System;
using Hotels.Data.Configurations;
using Hotels.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Data
{
    public class HotelsDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        public HotelsDbContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
        }
    }
}
