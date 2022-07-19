using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Service()
        {

            return PartialView();
        }
        public PartialViewResult SubscribePartial()
        {

            return PartialView();
        }
    }
}
