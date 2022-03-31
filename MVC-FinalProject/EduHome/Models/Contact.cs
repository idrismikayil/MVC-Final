using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EduHome.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string IconOne { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string IconTwo { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string IconThree { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string AddressOne { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string AddressTwo { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Number { get; set; }

        [NotMapped]
        [Required]
        public IFormFile ImageFile1 { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile2 { get; set; }
        [NotMapped]
        [Required]
        public IFormFile ImageFile3 { get; set; }
    }
}
