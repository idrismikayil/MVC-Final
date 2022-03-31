using EduHome.Models;
using System.Collections.Generic;

namespace EduHome.ViewModels
{
    public class AboutVM
    {
        public WelcomeMessage WelcomeMessage { get; set; }
        public List<NoticeBoard> NoticeBoard { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
