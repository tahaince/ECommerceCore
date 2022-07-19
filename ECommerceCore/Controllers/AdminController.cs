using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using ECommerceCore.Models;
using EntityLayer.Concrete;
using MernisService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Controllers
{
    public class AdminController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentDal()); 

        private UserManager<AppUser> _userManager;

        public AdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
        //[HttpPost]
        //public async Task< IActionResult> Index()
        //{
        //    var user = await _userManager.FindByNameAsync(User.Identity.Name);
            

        //    var client = new MernisService.KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        //    var response = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.TCNO), user.Name, user.Surname, Convert.ToInt32( user.Date.Year));
        //    var result = response.Body.TCKimlikNoDogrulaResult;
        //    if(result==true)
        //    {
        //        return RedirectToAction("Index", "Default");
        //    }
        //    else

        //    return View();
        //}
    }
}
