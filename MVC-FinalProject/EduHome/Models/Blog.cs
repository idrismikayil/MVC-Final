using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string AuthorName { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 10000)]
        public string Description { get; set; }
        
        [NotMapped]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
