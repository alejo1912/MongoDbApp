using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFrontEnd.Controllers
{
    public class TemporadasController : Controller
    {
        public IActionResult GestionTemporadas(string id)
        {
            ViewBag.idString = "";
            if (!string.IsNullOrWhiteSpace(id))
            {
                ViewBag.idString = id;
            }
            return View();
        }
        public IActionResult GetTemporadas()
        {
            return View();
        }
    }
}
