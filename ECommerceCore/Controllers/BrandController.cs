using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Controllers
{
    public class BrandController : Controller
    {
        BrandManager bm = new BrandManager(new EFBrandDal());

        public IActionResult Index()
        {
            var values = bm.GetList();
            return View(values);
        }
    }
}
