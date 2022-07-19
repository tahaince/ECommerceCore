using ECommerceCore.Models;
using EntityLayer.Concrete;
using MernisService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signinmanager;
        private readonly RoleManager<AppRole> _roleManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signinmanager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signinmanager = signinmanager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                AppUser user = _userManager.FindByEmailAsync(p.Mail).Result;

                if (user != null)
                {
                    if (await _userManager.IsLockedOutAsync(user))
                    {
                        ModelState.AddModelError("", "Hesabınız geçici süre ile askıya alınmıştır.");
                        return View();
                    }
                    
                        Microsoft.AspNetCore.Identity.SignInResult result = await _signinmanager.PasswordSignInAsync(user, p.Password, p.Remember, false);

                        if (result.Succeeded)
                        {
                            TempData["User"] = user.Name;

                            await _userManager.ResetAccessFailedCountAsync(user);
                            return RedirectToAction("Index", "Admin");
                        }
                        else
                        {
                        await _userManager.AccessFailedAsync(user);
                        int fail = await _userManager.GetAccessFailedCountAsync(user);
                        ModelState.AddModelError("", $"{3 - fail} kere deneme hakınnız kaldı");
                        if(fail>3)
                        {
                            await _userManager.SetLockoutEndDateAsync(user, new System.DateTimeOffset(DateTime.Now.AddMinutes(5)));
                            ModelState.AddModelError("", "Hesabınız 5 dakika süre ile askıya alınmıştır");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Girilen bilgiler hatalı");
                            return View();
                        }

                            
                        }
                    

                }
                else
                {
                    ModelState.AddModelError("", "Bu mail adresi sistemde kayıtlı değil");
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(SignUpViewModel p)
        {
            if (ModelState.IsValid && p.Password == p.PasswordConfirm)
            {
                AppUser appUser = new AppUser();
                appUser.UserName = p.UserName;
                appUser.Name = p.Name;
                appUser.Surname = p.Surname;
                appUser.Email = p.Email;
                appUser.TCNO = p.TCNO;
                appUser.PhoneNumber = p.PhoneNumber;
                appUser.Date = p.Date;

                //BURASI TC KİMLİK NUMARASI DOĞRULAMA ALANIDIR.

                //var client = new MernisService.KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                //var response = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(p.TCNO), p.Name, p.Surname, Convert.ToInt32(p.Date.Year));
                //var tcresult = response.Body.TCKimlikNoDogrulaResult;
                //if (tcresult != true)
                //{
                //    ModelState.AddModelError("", "Girdiginiz bilgiler TÜRKİYE CUMHURİYETİ DEVLETİNE KAYITLI DEĞİLDİR !");
                //    ViewBag.result = "Girdiginiz bilgiler TÜRKİYE CUMHURİYETİ DEVLETİNE KAYITLI DEĞİLDİR !";
                //    return View();
                //}

                //BURASI BİTİŞİDİR.


                IdentityResult result = await _userManager.CreateAsync(appUser, p.Password);

                if (result.Succeeded)
                {
                     _userManager.AddToRoleAsync(appUser,"Customer").Wait();
                    ViewBag.message = "Kayıt Başarılı";
                    return RedirectToAction("Login");
                }

                else
                {
                    foreach (IdentityError item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            else if(p.Password !=p.PasswordConfirm)
            {
                ModelState.AddModelError("", "İlk şifre ile ikinci şifre uyuşmamaktadır");
            }

            return View();
        }

        public IActionResult LogOut()
        {
            _signinmanager.SignOutAsync();
            TempData.Remove("User");
            return RedirectToAction("Login","Login");
        }


        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateRole(AppRole p)
        {
            AppRole appRole = new AppRole();
            appRole.Name = p.Name;
            IdentityResult result = _roleManager.CreateAsync(appRole).Result;
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
