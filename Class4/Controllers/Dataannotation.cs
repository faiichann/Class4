using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Class4.Models;

namespace Class4.Controllers
{
    public class Dataannotation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult index(newuser user)
        {
            if (ModelState.IsValid)
            {
                return View("Complete", user);
            }
            return View(user);
        }
    }
}
