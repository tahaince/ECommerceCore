using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        public List<Product> GetCategoriesWithProduct();
        public List<Product> GetCategoriesWithProductById(int id);

        public List<Product> GeBrandWithProduct();
        public List<Product> GetBrandWithProductById(int id);

    }
}
