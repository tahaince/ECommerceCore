using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Default
{

    public class DefaultNewProduct:ViewComponent
    {
        ProductManager productManager = new ProductManager(new EFProductDal());

        public IViewComponentResult Invoke()
        {
            var values = productManager.GetList().TakeLast(4).ToList();
            return View(values);

        }

    }
}
