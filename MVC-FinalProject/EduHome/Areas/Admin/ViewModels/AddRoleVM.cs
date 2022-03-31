using System.Collections.Generic;

namespace EduHome.Areas.Admin.ViewModels
{
    public class AddRoleVM
    {
        public string UserId { get; set; }
        public List<string> Roles { get; set; }
        public string RoleName { get; set; }
    }
}
