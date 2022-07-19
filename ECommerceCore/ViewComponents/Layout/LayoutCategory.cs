using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Layout
{
    public class LayoutCategory:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EFCategoryDal());
        private readonly UserManager<AppUser> userManager;

        public LayoutCategory(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public IViewComponentResult Invoke()

        {
            var values = cm.GetList();
            ViewBag.name = User.Identity.Name;

            return View(values);
        }
    }
}
