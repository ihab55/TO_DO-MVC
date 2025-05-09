using System.Diagnostics;
using MvcToDoListApp.Models;
using Microsoft.AspNetCore.Mvc;
using MvcToDoListApp.ViewModels;

namespace MvcToDoListApp.Services
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            string? username = HttpContext.Session.GetString("Username");
            string? password = HttpContext.Session.GetString("Password");
            User user=new User() {Username=username,Password=password};
            if (username != null)
            {
                return Login(user);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            bool ValidLogin = LoginLogic.UserIsValidToLogin(user.Username, user.Password);
            if (ValidLogin)
            {
                HttpContext.Session.SetString("Username", user.Username);
                HttpContext.Session.SetString("Password",user.Password);
                return RedirectToAction("Index", "ToDoTask");
            }
            return RedirectToAction("Login", "Home");
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(SignUp signUp)
        {
            bool userIsValidToSignUp=SignUpLogic.UserIsValidThenSignUp(signUp.Username,signUp.Password,signUp.ConfirmPassword);
            if (userIsValidToSignUp)
            {
                return RedirectToAction("Login", "Home");
            }
            return View();
        }

    }
}
