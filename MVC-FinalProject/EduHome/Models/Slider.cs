using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 300)]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 170)]
        public string TopTitle { get; set; }
        [Required]
        [StringLength(maximumLength: 300)]
        public string Description { get; set; }
        [Required]
        public byte Order { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
