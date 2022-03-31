using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Fullname { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Position { get; set; }
        [Required]
        [StringLength(maximumLength: 1000)]
        public string About { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Degree { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Experience { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Hobbies { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Faculty { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Image { get; set; }
        public List<TeacherSkill> TeacherSkills { get; set; }
        public TeacherContact TeacherContact  { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile { get; set; }
    }
}
