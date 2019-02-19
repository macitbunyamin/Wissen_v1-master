using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Wissen.Models
{
    public class DenemeForm
    {
        [Display(Name ="Ad")]
        [Required(ErrorMessage ="{0} alanı gereklidir.")]
        [MaxLength(50,ErrorMessage ="{0} alanı en fazla {1} karakter uzunluğunda olabilir.")]
        public string FirstName { get; set; }
        [Display(Name = "Soyad")]
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Display(Name = "E-posta")]
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
        [Display(Name = "Telefon")]
        [Required]
        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}