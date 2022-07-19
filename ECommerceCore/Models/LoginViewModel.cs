using System.ComponentModel.DataAnnotations;

namespace ECommerceCore.Models
{
    public class LoginViewModel
    {
        [EmailAddress]
        [Display(Name = "Mail Adresi")]
        [Required]
        public string Mail { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre kısmını doldurunuz")]
        public string Password { get; set; }
        public bool Remember { get; set; }


    }
}
