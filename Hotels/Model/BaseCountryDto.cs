using System.ComponentModel.DataAnnotations;

namespace Hotels.Model
{
    public class BaseCountryDto
    {
        [Required]
        [StringLength(maximumLength: 32, ErrorMessage = "Country name too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, MinimumLength = 2, ErrorMessage = "Country code should consists of two characters!")]
        public string Code { get; set; }
    }
}