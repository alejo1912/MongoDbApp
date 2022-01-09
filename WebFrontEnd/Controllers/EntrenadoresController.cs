using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFrontEnd.Controllers
{
    public class EntrenadoresController : Controller
    {
        public IActionResult GestionEntrenadores(string id)
        {
            ViewBag.idString = "";
            if (!string.IsNullOrWhiteSpace(id))
            {
                ViewBag.idString = id;
            }
            return View();
        }
        public IActionResult GetEntrenadores()
        {
            return View();
        }
    }
}
