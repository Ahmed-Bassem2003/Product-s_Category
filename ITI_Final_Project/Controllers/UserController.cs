using ITI_Final_Project.Context;
using ITI_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ITI_Final_Project.Controllers
{
    public class UserController : Controller
    {
        CompanyContext db = new CompanyContext();
        // GET: /User/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(User user)
        {
            var exEmail = db.Users.FirstOrDefault(u => u.Email == user.Email);
            if (exEmail != null)
            {
                ModelState.AddModelError("", "Email already exists");
                return View(user);
            }

            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View(user);
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = db.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                return RedirectToAction("Index", "Product");
            }

            ViewBag.Error = "Invalid email or password";
            return View();
        }

    }
}


