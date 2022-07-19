using System.ComponentModel.DataAnnotations;

namespace ECommerceCore.Models
{
    public class PasswordChangeViewModel
    {
        [Required]
        [Display(Name = "Eski Şifreniz")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        [Required]
        [DataType(DataType.Password)]

        [Display(Name = "Yeni Şifreniz")]
        public string NewPassword { get; set; }
        [Required]
        [DataType(DataType.Password)]

        [Display(Name = "Yeni Şifreniz")]
        public string PasswordCheck { get; set; }
    }
}
