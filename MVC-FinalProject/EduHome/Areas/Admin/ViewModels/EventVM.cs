using EduHome.Models;
using System.Collections.Generic;

namespace EduHome.Areas.Admin.ViewModels
{
    public class EventVM
    {
        public Event Event { get; set; }
        public List<Speaker> Speakers { get; set; }
        public List<int> SpeakerIds { get; set; }
    }
}
