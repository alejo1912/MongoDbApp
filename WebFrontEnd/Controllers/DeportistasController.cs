using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFrontEnd.Controllers
{
    public class DeportistasController : Controller
    {
        public IActionResult GestionDeportistas()
        {
            return View();
        }    
        public IActionResult GetDeportistas()
        {
            return View();
        }
    }
}
