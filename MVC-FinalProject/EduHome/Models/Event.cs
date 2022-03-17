using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime HourStart { get; set; }
        [Required]
        public DateTime HourEnd { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Location { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }
    }
}
