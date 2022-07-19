using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Default
{
    public class DefaultCategories:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        ProductManager pm = new ProductManager(new EFProductDal());

        public IViewComponentResult Invoke()
        {

            var values = cm.GetList();
            var product = pm.GetList();

            //Burası sadece ilk kategorinin verisini getiriyor düzeltme gerekli
            foreach(var item in values)
            {
                ViewBag.count = pm.GetList().Where(x => x.CategoryId == item.CategoryId).Count();

            }
            return View(values);
        }

    }
}
