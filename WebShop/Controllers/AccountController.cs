using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webshop.Logic;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class AccountController : Controller
    {
        private UserManager _users;

        public AccountController(UserManager userManager)
        {
            _users = userManager;
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(UserModel SignInmodel)
        {
            ModelState.Remove("PasswordRepeat");

            if (ModelState.IsValid)
            {
                var user = _users.GetByEmailAndPass(SignInmodel.Email, SignInmodel.Password);

                if (user == null)
                {
                    ModelState.AddModelError("error", "Wrong pass or email!");
                }

                else
                {
                    HttpContext.Session.SetUserId(user.Id);
                    HttpContext.Session.SetUserEmail(user.Email);


                    TempData["message"] = "Account created";
                    return RedirectToAction("Index","Item");
                }
            }

            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if (ModelState.IsValid)
            {

                if (_users.GetByEmail(model.Email) !=null)
                {
                    ModelState.AddModelError("error", "Email already exists!");
                }

                else
                {
                   _users.Create(new Webshop.Logic.User()
                    {
                        Email = model.Email,
                        Password = model.Password,
                    });

                    TempData["message"] = "Account created";
                    return RedirectToAction("SignIn");
                }

            }

            return View();
        }

        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Item");
        }
    }
}