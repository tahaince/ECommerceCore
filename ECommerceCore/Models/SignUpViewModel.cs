using System.ComponentModel.DataAnnotations;

namespace ECommerceCore.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Gereklidir.")]
        [Display(Name = "Kullanıcı Adı")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Ad Gereklidir.")]
        [Display(Name = "Ad")]


        public string Name  { get; set; }
        [Required(ErrorMessage = "Soyadı Gereklidir.")]
        [Display(Name = "Soyadı")]


        public string Surname { get; set; }
        [Required(ErrorMessage = "TCNO Gereklidir.")]
        [Display(Name = "TCNO")]


        public string TCNO { get; set; }
        [Required(ErrorMessage = "Email Gereklidir.")]
        [Display(Name = "Email ")]


        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre Gereklidir.")]
        [Display(Name = "Şifre")]


        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrarı Gereklidir.")]
        [Display(Name = "Şifre Tekrarı")]


        public string PasswordConfirm { get; set; }
        [Required(ErrorMessage = "Tarih Gereklidir.")]
        [Display(Name = "Tarih")]


        public DateTime Date { get; set; }


        [Required(ErrorMessage = "Telefon Numarası Gereklidir.")]
        [Display(Name = "Telefon")]


        public string PhoneNumber { get; set; }






    }
}
