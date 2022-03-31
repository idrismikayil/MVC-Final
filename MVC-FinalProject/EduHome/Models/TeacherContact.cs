using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class TeacherContact
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Mail { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string PhoneNumber { get; set; }
        [StringLength(maximumLength: 200)]
        public string Skype { get; set; }
        [StringLength(maximumLength: 200)]
        public string FirstSocialMediaLogo { get; set; }
        [StringLength(maximumLength: 200)]
        public string SecondSocialMediaLogo { get; set; }
        [StringLength(maximumLength: 200)]
        public string ThirdSocialMediaLogo { get; set; }
        [StringLength(maximumLength: 200)]
        public string FourthSocialMediaLogo { get; set; }
        [StringLength(maximumLength: 200)]
        public string FirstURL { get; set; }
        [StringLength(maximumLength: 200)]
        public string SecondURL { get; set; }
        [StringLength(maximumLength: 200)]
        public string ThirdURL { get; set; }
        [StringLength(maximumLength: 200)]
        public string FourthURL { get; set; }
        public Teacher Teacher { get; set; }
        [Required]
        public int TeacherId { get; set; }
    }
}
