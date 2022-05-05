using Identity.Models;
using Identity.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private UserManager<AppUser> _userManager { get; }

        public AdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> SignUp(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber                    
                };
                IdentityResult identityResult =  await _userManager.CreateAsync(appUser,model.Password);

                if (identityResult.Succeeded)
                {
                    return RedirectToAction("Login","Home");
                }else
                {
                    foreach (IdentityError item in identityResult.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
            }
            return View(model);
        }
    }
}
