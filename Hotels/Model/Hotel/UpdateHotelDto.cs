using Hotels.Model.Country;

namespace Hotels.Model.Hotel
{
    public class UpdateHotelDto : CreateHotelDto
    {
        public CountryDto Country { get; set; }
    }
}