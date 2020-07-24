using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Myweb.Controllers
{
    public class CoinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
