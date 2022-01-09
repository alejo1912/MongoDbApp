using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFrontEnd.Controllers
{
    public class ArbitrosController : Controller
    {
        public IActionResult GestionArbitros(string id)
        {
            ViewBag.idString = "";
            if (!string.IsNullOrWhiteSpace(id))
            {
                ViewBag.idString = id;
            }
            return View();
        }
        public IActionResult GetArbitros()
        {
            return View();
        }
    }
}
