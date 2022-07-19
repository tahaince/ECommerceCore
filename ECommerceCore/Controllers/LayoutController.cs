using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult FooterPartial()
        {

            return PartialView();
        }
        public PartialViewResult JSPartial()
        {

            return PartialView();
        }

        public PartialViewResult HeadPartial()
        {

            return PartialView();
        }
    }
}
