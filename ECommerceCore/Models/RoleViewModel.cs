using System.ComponentModel.DataAnnotations;

namespace ECommerceCore.Models
{
    public class RoleViewModel
    {
        [Required]
        [Display(Name = "Rol Adı")]

        public string Name { get; set; }
    }
}
