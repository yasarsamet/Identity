using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Email Alanı Gereklidir")]
        [Display(Name ="Email Adresiniz")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password alanı Gereklidir")]
        [Display(Name = "Şifreniz")]
        [DataType(DataType.Password)]
        [MinLength(4,ErrorMessage ="Şifreniz en az  4 karakterli olmalıdır.")]
        public string Password { get; set; }
    }
}
