using Microsoft.AspNetCore.Mvc;
using TRSApp.Models;
using System.Collections.Generic;

namespace TRSApp.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, Username = "admin", Email = "admin@trs.com", Role = "Admin" }
        };

        public IActionResult Index()
        {
            return View(users);  // Display a list of users
        }

        public IActionResult Create()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
            return RedirectToAction("Index");  
        }
    }
}
