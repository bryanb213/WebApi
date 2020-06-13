using System.ComponentModel.DataAnnotations;

namespace NetApi.Dtos
{
    public class UpdateCommandDto
    {
        [Required]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform { get; set; }
    }
}