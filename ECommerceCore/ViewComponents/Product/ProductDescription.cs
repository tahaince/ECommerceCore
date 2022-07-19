using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Product
{
    public class ProductDescription:ViewComponent
    {
        ProductManager pm = new ProductManager(new EFProductDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = pm.GetById(id);

            return View(values);

        }
    }
}
