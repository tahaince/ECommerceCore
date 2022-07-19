using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Product
{
    public class ProductOtherProduct:ViewComponent
    {
        ProductManager productManager = new ProductManager(new EFProductDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = productManager.GetBrandWithProduct().Where(x=>x.BrandId==id).ToList();

            return View(values);
        }

    }
}
