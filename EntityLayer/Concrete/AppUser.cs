using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string TCNO { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public List<OrderSepet> OrderSepets{ get; set; }
        //public List<AppUser> AppUsers{ get; set; }

        public List<Addres> Address { get; set; }
        public List<Comment> Comments{ get; set; }


    }
}
