using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Fullname { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Position { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }

    }
}
