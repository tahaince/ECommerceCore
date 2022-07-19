using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OrderSepet
    {
        [Key]
        public int OrderSepetId { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Number { get; set; }

        public int Total { get; set; }

    }
}
