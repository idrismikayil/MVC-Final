using System.ComponentModel.DataAnnotations;

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
    }
}
