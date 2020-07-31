using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Myweb.Ef_model;

namespace Myweb.Controllers
{
    public class RegisteredController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult False()
        {
            return View();
        }
        public IActionResult AddUser(IFormCollection fc) 
        {
            string name = fc["name"];
            string account = fc["account"];
            string password = fc["password"];
            BlockchainContext db = new BlockchainContext();
            User user = new User
            {
                Name = name,
                Account = account,
                Password = password,
            };
            db.User.Add(user);
            int number = db.SaveChanges();
            if (number == 1)
            {
                return RedirectToAction("Success");
            }
            else
            {
                return View("False");
            }


        }
    }
}
