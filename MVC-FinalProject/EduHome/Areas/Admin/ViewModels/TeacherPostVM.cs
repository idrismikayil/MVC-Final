using EduHome.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduHome.Areas.Admin.ViewModels
{
    public class TeacherPostVM
    {
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
        public List<int> SkillIds { get; set; }
        public int TeacherContactId { get; set; }
        public IFormFile ImageFile { get; set; }

        public TeacherContact TeacherContact { get; set; }
        public List<Skill> Skills { get; set; }

    }
}
