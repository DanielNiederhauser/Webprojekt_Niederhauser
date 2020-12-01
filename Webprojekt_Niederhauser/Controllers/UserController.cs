using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webprojekt_Niederhauser.Models;

namespace Webprojekt_Niederhauser.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registrierung()
        {
            return View();
        }
        private void Ueberpruefen(User u)
        {
            if (u == null)
            {
                return;
            }
            if (u.Vorname == null || u.Vorname.Length < 3)
            {
                ModelState.AddModelError(nameof(Artikel.Bezeichnung), "Der Vorname muss mindestens 3 Zeichen lang sein!");
            }
            if (u.Nachname == null || u.Nachname.Length < 3)
            {
                ModelState.AddModelError(nameof(Artikel.Bezeichnung), "Der Nachname muss mindestens 3 Zeichen lang sein!");
            }
            if ((u.Geburtsdatum) == (new DateTime(1900, 01, 01)))
            {
                ModelState.AddModelError(nameof(Artikel.Baujahr), "Realistisches Geburtsdatum eingeben!");

            }
            if ((u.geschlecht) == Models.User.Geschlecht.notSpecified)
            {
                ModelState.AddModelError(nameof(Artikel.Klasse), "Geschlecht eingeben!");

            }
            if (u.Email == null || u.Email.Length < 10)
            {
                ModelState.AddModelError(nameof(Artikel.Bezeichnung), "Der Nachname muss mindestens 10 Zeichen lang sein!");
            }
            if (u.Passwort == null || u.Passwort.Length < 5)
            {
                ModelState.AddModelError(nameof(Artikel.Bezeichnung), "Das Passwort muss mindestens 5 Zeichen lang sein!");
            }

        }

    }
}
