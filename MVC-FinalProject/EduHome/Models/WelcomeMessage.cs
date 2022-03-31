using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.Models
{
    public class WelcomeMessage
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 2000)]
        public string Description { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Image { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
