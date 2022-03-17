using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class WhyUs
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 300)]
        public string Description { get; set; }
        //[Required]
        //[StringLength(maximumLength: 200)]
        //public string BackgroundImage { get; set; }
        //[Required]
        //[StringLength(maximumLength: 200)]
        //public string MainImage { get; set; }
    }
}
