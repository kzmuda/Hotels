using System.ComponentModel.DataAnnotations;
using Hotels.Model.Country;

namespace Hotels.Model.Hotel
{
    public class HotelDto : CreateHotelDto
    {
        [Required]
        public int Id { get; set; }
        public CountryDto Country { get; set; }
    }
}
