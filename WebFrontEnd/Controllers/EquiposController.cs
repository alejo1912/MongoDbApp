using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFrontEnd.Controllers
{
    public class EquiposController : Controller
    {
        public IActionResult GestionEquipos(string id)
        {
            ViewBag.idString = "";
            if (!string.IsNullOrWhiteSpace(id))
            {
                ViewBag.idString = id;
            }
            return View();
        }
        public IActionResult GetEquipos()
        {
            return View();
        }
    }
}
