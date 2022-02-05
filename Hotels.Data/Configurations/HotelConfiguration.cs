using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotels.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotels.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel { Id = 1, CountryId = 1, Name = "Hotel Piast", Address = "Wrocław", Rating = 4.0 },
                new Hotel { Id = 2, CountryId = 1, Name = "Center Warsaw", Address = "Warszawa", Rating = 4.5 },
                new Hotel { Id = 3, CountryId = 2, Name = "Waldorf Astoria", Address = "Berlin", Rating = 5.0 }
            );
        }
    }
}
