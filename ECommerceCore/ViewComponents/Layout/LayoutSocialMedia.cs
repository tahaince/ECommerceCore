using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Layout
{
    public class LayoutSocialMedia:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
