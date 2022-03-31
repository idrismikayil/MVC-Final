using Microsoft.AspNetCore.Identity;

namespace EduHome.Models
{
    public class User : IdentityUser
    {
        public string Fullname { get; set; }
        public bool isActive { get; set; } = true;
    }
}
