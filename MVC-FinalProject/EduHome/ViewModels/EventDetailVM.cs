using EduHome.Models;
using System.Collections.Generic;

namespace EduHome.ViewModels
{
    public class EventDetailVM
    {
        public Event Event { get; set; }
        public List<Speaker> Speakers { get; set; }
    }
}
