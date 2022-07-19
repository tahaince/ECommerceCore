using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Product
{
    public class ProductFilterNavBar:ViewComponent
    {
        ProductManager pm = new ProductManager(new EFProductDal());
        public IViewComponentResult Invoke()
        {
            var values = pm.GetList();
            return View(values);

        }
    }
}
