using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class Information
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 170)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 300)]
        public string Description { get; set; }
    }
}
