using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bt_Day1.Controllers
{
    public class TuDienDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult tudienDemo()
        {
            return View();
        }
    }
}