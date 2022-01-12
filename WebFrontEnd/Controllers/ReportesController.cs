using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFrontEnd.Controllers
{
    public class ReportesController : Controller
    {
        public IActionResult GetReportes()
        {
            return View();
        }
    }
}
