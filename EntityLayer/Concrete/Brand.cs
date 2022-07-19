﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Brand
    {
        [Key]
        public int BrandId{ get; set; }
        public string BrandName { get; set; }
        public string PictureUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}
