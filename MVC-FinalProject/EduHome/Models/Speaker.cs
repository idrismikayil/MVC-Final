using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public int Position { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }

    }
}
