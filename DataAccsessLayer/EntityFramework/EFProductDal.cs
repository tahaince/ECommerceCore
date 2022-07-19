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
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GeBrandWithProduct()
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.Brand).ToList();

            }
        }

        public List<Product> GetBrandWithProductById(int id)
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.Brand).Where(x=>x.ProductId==id).ToList();

            }
        }

        public List<Product> GetCategoriesWithProduct()
        {
            using(var c = new Context())
            {
                return c.Products.Include(x => x.Category).ToList();

            }
        }

        public List<Product> GetCategoriesWithProductById(int id)
        {
            using (var c = new Context())
            {
                return c.Products.Include(x => x.Category).Where(x => x.ProductId == id).ToList();

            }
        }
    }
}
