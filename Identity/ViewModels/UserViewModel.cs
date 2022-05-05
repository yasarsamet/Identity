using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name ="Tel No:")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage ="Email Adresi gerekli")]
        [Display(Name ="Email Adresiniz")]
        [EmailAddress(ErrorMessage ="Email adresiniz doğru formatta değil")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifreniz Gereklidir")]
        [Display(Name ="Şifreniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
