using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.Default
{
    public class DefaultSlider:ViewComponent
    {
        SliderManager sm = new SliderManager(new EFSliderDAL());
        public IViewComponentResult Invoke()
        {
            var values = sm.GetList();
            return View(values);
        }
    }
}
