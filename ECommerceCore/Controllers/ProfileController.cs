using BussinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using ECommerceCore.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Controllers
{
    //[Authorize(Roles = "Customer")]

    public class ProfileController : Controller
    {
        AdressManager adm = new AdressManager(new EFAdresDal());
        OrderSepetManager sm = new OrderSepetManager(new EFOrderSepet());

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public ProfileController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }



        public async Task<IActionResult> Index()
        {
            AppUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            SignUpViewModel viewModel = new SignUpViewModel();

            viewModel.Name = user.Name;
            viewModel.Surname = user.Surname;
            viewModel.UserName = user.UserName;
            viewModel.Date = user.Date;
            viewModel.Email = user.Email;
            viewModel.PhoneNumber = user.PhoneNumber;
            viewModel.TCNO = user.TCNO;



            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(SignUpViewModel viewModel)
        {
            AppUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            user.UserName = viewModel.UserName;
            user.Name = viewModel.Name;
            user.Surname = viewModel.Surname;
            user.Email = viewModel.Email;
            user.PhoneNumber = viewModel.PhoneNumber;
            user.Date = viewModel.Date;
            user.TCNO = viewModel.TCNO;

            IdentityResult result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                await _signInManager.SignOutAsync();




                return RedirectToAction("Login", "Login");
            }
            else
            {
                foreach (IdentityError item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }

        }


        public IActionResult Adress()
        {
            AppUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            var values = adm.GetList().Where(x => x.AppUserId == user.Id).ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AdressEdit(int id)
        {
            var values = adm.GetById(id);

            return View(values);
        }


        [HttpPost]
        public async Task<IActionResult> AdressEdit(Addres p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p.AppUserId = user.Id;
            adm.TUpdate(p);


            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAdress(int id)
        {
            var values = adm.GetById(id);
            adm.TDelete(values);


            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> AddAdress()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAdress(Addres p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p.AppUserId = user.Id;

            adm.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(PasswordChangeViewModel p)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            IdentityResult result = _userManager.ChangePasswordAsync(user, p.OldPassword, p.NewPassword).Result;

            if(result.Succeeded)
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Login","Login");
            }

            return View();
        }


    }
}
