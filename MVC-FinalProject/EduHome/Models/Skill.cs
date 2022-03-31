using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class Skill
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string SkillName { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public List<TeacherSkill> TeacherSkills { get; set; }
       
    }
}
