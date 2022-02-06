using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Hotels.Model.Hotel;

namespace Hotels.Model.Country
{
    public class CountryDto : BaseCountryDto
    {
        [Required]
        public int Id { get; set; }
        public IList<HotelDto> Hotels { get; set; }
    }
}
