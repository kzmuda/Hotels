using System.Collections.Generic;
using Hotels.Model.Hotel;

namespace Hotels.Model.Country
{
    public class UpdateCountryDto : BaseCountryDto
    {
        public IList<HotelDto> Hotels { get; set; }
    }
}