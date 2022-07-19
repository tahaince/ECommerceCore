using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Addres
    {
        public int AddresId { get; set; }
        public string Title { get; set; }
        public string Descritpion { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public List<Order> Orders { get; set; }
    }
}
