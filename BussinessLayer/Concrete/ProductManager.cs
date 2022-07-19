using BussinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productdal;

        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
        }

        public List<Product> GetBrandWithProduct()
        {
            return _productdal.GeBrandWithProduct();
        }

        public List<Product> GetBrandWithProductById(int id)
        {
            return _productdal.GetBrandWithProductById(id);
        }

        public Product GetById(int id)
        {
            return _productdal.GetByID(id);
        }

        public List<Product> GetCategoriesWithProduct()
        {
          return  _productdal.GetCategoriesWithProduct();
        }

        public List<Product> GetCategoriesWithProductById(int id)
        {
            return _productdal.GetCategoriesWithProductById(id);
        }

        public List<Product> GetList()
        {
            return _productdal.GetList();
        }

        public void TAdd(Product t)
        {
            _productdal.Insert(t);
        }

        public void TDelete(Product t)
        {
            _productdal.Delete(t);
        }

        public List<Product> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product t)
        {
            _productdal.Update(t);
        }
    }
}
