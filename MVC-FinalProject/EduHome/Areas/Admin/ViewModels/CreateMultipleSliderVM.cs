using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.Areas.Admin.ViewModels
{
    public class CreateMultipleSliderVM
    {
        [Required]
        [StringLength(maximumLength: 300)]
        public string Desc { get; set; }
        [Required]
        [StringLength(maximumLength: 170)]
        public string Title { get; set; }

        [NotMapped]
        [Required]
        public IFormFile[] Images { get; set; }
    }
}
