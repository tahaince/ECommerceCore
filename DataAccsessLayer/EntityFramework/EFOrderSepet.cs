using DataAccsessLayer.Abstract;
using DataAccsessLayer.Content;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EFOrderSepet : GenericRepository<OrderSepet>, IOrderSepetDal
    {
        public List<OrderSepet> GetOrderSepetsWithProduct()
        {
            using (var c = new Context())
            {
                return c.OrderSepets.Include(x => x.Product).ToList();
            }
        }
    }
}
