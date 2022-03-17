using System;
using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        public DateTime Starts { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Duration { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string CourseDuration { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string SkillLevel { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Language { get; set; }
        public int Students { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Assesments { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
