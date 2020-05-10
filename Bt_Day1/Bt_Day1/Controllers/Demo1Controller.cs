using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bt_Day1.Controllers
{
    public class Demo1Controller : Controller
    {
        // Link local:port/Demo1/Chuoi hoac So:
        public string Chuoi()
        {
            return "Hello";
        }

        public int So()
        {
            return new Random().Next(1000, 10000);
        }


        // Hàm code xem Views:
        public IActionResult demo1_1()
        {
            return View();
        }

        public IActionResult demo1()
        {
            return View();
        }
    }
}