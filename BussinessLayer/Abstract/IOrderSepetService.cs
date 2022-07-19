﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IOrderSepetService:IGenericService<OrderSepet>
    {
        public List<OrderSepet> GetOrderSepetsWithProducts();
    }
}
