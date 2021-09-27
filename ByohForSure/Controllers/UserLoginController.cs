using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ByohForSure.Models;
using ByohForSure.Services;
using Microsoft.AspNetCore.Mvc;

namespace ByohForSure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserLoginController : Controller
    {
        private IUserService _userService;

        public UserLoginController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
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