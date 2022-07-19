
using BussinessLayer.Concrete;
using DataAccsessLayer.Content;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ECommerceCore.Controllers
{
    public class CartController : Controller
    {
        OrderSepetManager osm = new OrderSepetManager(new EFOrderSepet());
        ProductManager pm = new ProductManager(new EFProductDal());
        OrderDetailManager odm = new OrderDetailManager(new EFOrderDetail());


        private readonly UserManager<AppUser> _usermanager;

        public CartController(UserManager<AppUser> usermanager)
        {
            _usermanager = usermanager;
        }

    

        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCart(OrderSepet p)
        {
            AppUser user = _usermanager.FindByNameAsync(User.Identity.Name).Result;
            p.AppUserId = user.Id;
            var product = pm.GetById(p.ProductId);
            int pprice = product.Price;
            p.Total = (p.Number) * pprice;
            
            
            osm.TAdd(p);
            return RedirectToAction("Index","Default");
        }

        public async Task<IActionResult> CartList()
        {
            AppUser user = _usermanager.FindByNameAsync(User.Identity.Name).Result;
            var values = osm.GetOrderSepetsWithProducts().Where(x => x.AppUserId == user.Id).ToList();
            var ttotal = osm.GetOrderSepetsWithProducts().Where(x=>x.AppUserId==user.Id).Sum(z=>z.Total);
            ViewBag.ttotal = ttotal;
            return View(values);
        }

        public async Task<IActionResult> AddOrderDetails(OrderDetail p)
        {
            AppUser user = _usermanager.FindByNameAsync(User.Identity.Name).Result;
            var cartlist = osm.GetList().Where(x=>x.AppUserId==user.Id).ToList();

            Context c = new Context();

            foreach (var item in cartlist)
            {
                p.OrderId = 1;
                p.Number = item.Number;
                p.Total = item.Total;
                p.ProductId = item.ProductId;
                c.OrderDetails.AddAsync(p);
                //odm.TAdd(p);

            }
            c.SaveChangesAsync();

            return RedirectToAction("Index","Default");
        }

    }
}
