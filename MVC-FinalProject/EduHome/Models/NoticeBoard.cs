using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Description { get; set; }

        [NotMapped]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
