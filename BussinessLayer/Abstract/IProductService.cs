using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> GetCategoriesWithProduct();
        List<Product> GetCategoriesWithProductById(int id);
        List<Product> GetBrandWithProductById(int id);
        List<Product> GetBrandWithProduct();

    }
}
