using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByohForSure.Models;
using Microsoft.AspNetCore.Mvc;

namespace ByohForSure.Controllers
{
    public class UserLoginController : Controller
    {
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
        public IActionResult Login(string userName,string passWord)
        {
            if(!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord))
            {
                //call servide to register user
            }
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterModel registerUser)
        {
            if (ModelState.IsValid)
            {
                //call service to register
            }
            return RedirectToAction("Login");
        }
    }
}