using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotable.Models;

namespace quotable.Controllers
{
    public class HomeController : Controller
    {
        private QuoteContext _context;
        public HomeController(QuoteContext context){
            _context=context;
        }
                public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterViewModel newUser)
        {
            if(ModelState.IsValid){
                user userQuery=_context.Users.SingleOrDefault(user=>user.Email==newUser.Email);
                if(userQuery!=null){
                    ViewBag.Exists="User already exists.";
                    return View("Index");
                }
                user addUser=new user{
                    FirstName = newUser.FirstName,
                    LastName = newUser.LastName,
                    Email = newUser.Email,
                    Password = newUser.Password,
                    // CreatedAt = DateTime.Now,
                    // UpdatedAt = DateTime.Now
                };
                _context.Users.Add(addUser);
                _context.SaveChanges();
                return RedirectToAction("Dashboard", "Dashboard");
            }
            return View("Index", newUser);
        }

        [HttpPost]
         [Route("login")]
        public IActionResult Login(string Password, string Email){
            user userQuery=_context.Users.SingleOrDefault(user=>user.Email==Email);
            if(userQuery==null){
                ViewBag.Error="User does not exist.";
                return View("Index");
            }
            if(userQuery.Password==Password){
                return RedirectToAction("Dashboard");
            }
            ViewBag.Error="Invalid password.";
            return View("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}