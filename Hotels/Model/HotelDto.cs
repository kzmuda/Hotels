using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Model
{
    public class UpdateHotelDto : CreateHotelDto
    {
        public CountryDto Country { get; set; }
    }

    public class HotelDto : CreateHotelDto
    {
        [Required]
        public int Id { get; set; }
        public CountryDto Country { get; set; }
    }
}
