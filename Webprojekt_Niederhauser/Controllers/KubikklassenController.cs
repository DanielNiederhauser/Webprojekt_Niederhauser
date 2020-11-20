using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Webprojekt_Niederhauser.Controllers
{
    public class KubikklassenController : Controller
    {
        public IActionResult Kubik50()
        {
            return View();
        }
        public IActionResult Kubik125()
        {
            return View();
        }
        public IActionResult KubikGroesser125()
        {
            return View();
        }
    }
}
