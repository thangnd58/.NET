using BookStory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;

namespace BookStory.Controllers
{
    public class UserController : Controller
    {
        readonly StoryDBContext context = new();

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
        public IActionResult Login(string email, string password)
        {
            var isLogin = context.Users.SingleOrDefault(u => u.Email.Equals(email) && u.Password.Equals(password));
            if (isLogin != null)
            {
                HttpContext.Session.SetString("user", JsonConvert.SerializeObject(isLogin));
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Incorrect email address or password.";
                return View();
            }
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string name, string email, string pass, string re_pass)
        {
            var user = new User
            {
                Email = email,
                Password = pass,
                Name = name,
                Role = 2
            };
            bool isRegister = true;
            foreach (User u in context.Users)
            {
                if (u.Email.Equals(email))
                {
                    isRegister = false;
                }
            }
            if (!pass.Equals(re_pass))
            {
                ViewBag.Message = "Re-entered password is not the same, please re-enter.";
            }
            else if (isRegister == false)
            {
                ViewBag.Message = "Registration failed. Email already exists in the system.";
            }
            else
            {
                ViewBag.Message = "Sign up successfully. You can login to the system.";
                context.Add(user);
                context.SaveChanges();
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction("Index", "Home");
        }
    }
}