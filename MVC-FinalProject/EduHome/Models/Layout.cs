using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class Layout
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string NavLogo { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string FooterLogo { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string FirstSocialMediaLogo { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string SecondSocialMediaLogo { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string ThirdSocialMediaLogo { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string FourthSocialMediaLogo { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string FirstURL { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string SecondURL { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string ThirdURL { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string FourthURL { get; set; }
    }
}
