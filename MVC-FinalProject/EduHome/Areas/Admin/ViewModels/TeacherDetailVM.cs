using EduHome.Models;
using System.Collections.Generic;

namespace EduHome.Areas.Admin.ViewModels
{
    public class TeacherDetailVM
    {
        public Teacher Teacher { get; set; }
        public TeacherContact TeacherContact { get; set; }
        //public List<Skill> Skills { get; set; }
        //public List<TeacherSkill> TeacherSkills { get; set; }
    }
}
