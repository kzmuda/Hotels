using System.ComponentModel.DataAnnotations;

namespace Hotels.Model.Hotel
{
    public abstract class BaseHotelDto
    {
        [Required]
        [StringLength(maximumLength: 64, ErrorMessage = "Hotel name is too long!")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 64, ErrorMessage = "Hotel address it too long!")]
        public string Address { get; set; }
        [Required]
        [Range(1.0, 6.0)]
        public double Rating { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}