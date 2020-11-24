using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webprojekt_Niederhauser.Controllers
{
    public class MotorradController : Controller
    {
        public IActionResult Rieju()
        {
            return View();
        }
        public IActionResult Kawasaki125()
        {
            return View();
        }
        public IActionResult KTM125()
        {
            return View();
        }
        public IActionResult Honda125()
        {
            return View();
        }

        public IActionResult KTMgroesser125()
        {
            return View();
        }
    }
}
