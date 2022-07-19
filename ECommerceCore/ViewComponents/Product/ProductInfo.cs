using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Product
{
    public class ProductInfo:ViewComponent
    {
        FeatureManager fm = new FeatureManager(new EFFeatureDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = fm.GetList().Where(x=>x.ProductId==id).ToList();
            return View(values);
        }
    }
}
