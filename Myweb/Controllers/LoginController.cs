using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Myweb.Ef_model;

namespace Myweb.Controllers
{
    public class LoginController : Controller
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
        [HttpPost]
        public IActionResult LoginUser(IFormCollection fc)
        {
            string account = fc["account"];
            string password = fc["password"];
            BlockchainContext db = new BlockchainContext();
            var res = (from x in db.User where x.Account == account && x.Password == password select x).FirstOrDefault();
            if (res == null)
            {
                return RedirectToAction("False");
            }
            else
            {
                return View("Success");
            }
           
        }
    }
}
