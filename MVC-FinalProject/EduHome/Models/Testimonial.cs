using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 170)]
        public string MainImage { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Description { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Fullname { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Position { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
