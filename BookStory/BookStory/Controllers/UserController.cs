using BookStory.Common;
using BookStory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace BookStory.Controllers
{
    public class UserController : Controller
    {
        readonly StoryDBContext context = new();

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
                if (isLogin.Role == 2)
                {
                    HttpContext.Session.SetString("user", JsonConvert.SerializeObject(isLogin));
                    return RedirectToAction("Index", "Home");
                }
                else if (isLogin.Role == 1)
                {
                    HttpContext.Session.SetString("user", JsonConvert.SerializeObject(isLogin));
                    return RedirectToAction("ListStory", "Admin");
                }
                else
                {
                    ViewBag.Message = "Nhập sai email hoặc mật khẩu";
                    return View();
                }

            }
            else
            {
                ViewBag.Message = "Nhập sai email hoặc mật khẩu";
                return View();
            }
            return View();
        }
        [HttpGet]
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
            foreach (User u in context.Users.ToList())
            {
                if (u.Email.Equals(email))
                {
                    isRegister = false;
                }
            }
            if (!pass.Equals(re_pass))
            {
                ViewBag.Message = "Mật khẩu nhập lại không giống với mật khẩu cũ";
            }
            else if (isRegister == false)
            {
                ViewBag.Message = "Đăng ký thất bại, email đã tồn tại trong hệ thống";
            }
            else
            {
                Random generator = new Random();
                int r = generator.Next(100000, 1000000);
                new MailHelper().SendMail("testdata05082001@gmail.com", "Xác minh từ hệ thống BookStory", $"Mã xác minh của bạn là {r}");
                HttpContext.Session.SetInt32("code", r);
                HttpContext.Session.SetString("register-user", JsonConvert.SerializeObject(user));
                return RedirectToAction("Verify", "User");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Verify(string code)
        {
            int? sessioncode = HttpContext.Session.GetInt32("code");
            if (sessioncode != null)
            {
                if (code.Equals(sessioncode.ToString()))
                {
                    string json = HttpContext.Session.GetString("register-user");
                    var user = JsonConvert.DeserializeObject<User>(json);
                    context.Add<User>(user);
                    context.SaveChanges();
                    HttpContext.Session.Remove("register-user");
                    HttpContext.Session.Remove("code");
                }
                else
                {
                    ViewBag.Message = "Nhập sai mã xác minh vui lòng nhập lại";
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Verify()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(string opassword, string npassword, string cpassword)
        {
            User u = null;
            string json = HttpContext.Session.GetString("user");
            if (json != null) u = JsonConvert.DeserializeObject<User>(json);
            string message = "";
            var entity = context.Users.FirstOrDefault(s => s.Uid == u.Uid);
            if (!entity.Password.Equals(opassword))
            {
                message = "Mật khẩu cũ không đúng. Vui lòng nhập lại";
            }
            else if (entity.Password == npassword)
            {
                message = "Mật khẩu mới giống với mật khẩu cũ. Vui lòng nhập lại";
            }
            else if (!npassword.Equals(cpassword))
            {
                message = "Mật khẩu nhập lại không khớp với mật khẩu cũ";
            }
            else
            {

                entity.Password = npassword;
                context.Entry(entity).CurrentValues.SetValues(entity);
                context.SaveChanges();
                message = "Đổi mật khẩu thành công";
            }
            ViewBag.Message = message;
            return View();
        }
    }
}