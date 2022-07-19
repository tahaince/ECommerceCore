using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Default
{
    public class DefaultProduct:ViewComponent
    {
        ProductManager pm = new ProductManager(new EFProductDal());

        public IViewComponentResult Invoke()
        {
            var values = pm.GetCategoriesWithProduct();
            return View(values);
        }
    }
}
