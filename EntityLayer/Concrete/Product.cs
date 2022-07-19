using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string? PictureUrl2 { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string PictureUrl { get; set; }

        public List<OrderSepet> OrderSepets { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Feature> Features { get; set; }
        public List<Comment> Comments { get; set; }




    }
}
