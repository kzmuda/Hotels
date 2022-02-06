using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Model
{
    public class CreateCountryDto : BaseCountryDto
    {
    }

    public class UpdateCountryDto : BaseCountryDto
    {
        public IList<HotelDto> Hotels { get; set; }
    }

    public class CountryDto : BaseCountryDto
    {
        [Required]
        public int Id { get; set; }
        public IList<HotelDto> Hotels { get; set; }
    }
}
