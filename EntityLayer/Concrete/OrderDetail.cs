﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int Number { get; set; }
        public int Total { get; set; }
    }
}
