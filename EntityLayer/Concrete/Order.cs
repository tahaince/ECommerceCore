using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int AdressId { get; set; }
        public Addres Addres { get; set; }

        //public int AppUserId { get; set; }
        //public AppUser  AppUser{ get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

    }
}
