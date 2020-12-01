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
            return View(DemoUser());
        }
      
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        
        public IActionResult Registrierung()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Registrierung(User neuerUser)
        {
            if (neuerUser == null)
            {
                return RedirectToAction("Registrierung");
            }
            Ueberpruefen(neuerUser);
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(neuerUser);
        }
        private void Ueberpruefen(User u)
        {
            if (u == null)
            {
                return;
            }
            if (u.Vorname == null || u.Vorname.Length < 3)
            {
                ModelState.AddModelError(nameof(u.Vorname), "Der Vorname muss mindestens 3 Zeichen lang sein!");
            }
            if (u.Nachname == null || u.Nachname.Length < 3)
            {
                ModelState.AddModelError(nameof(u.Nachname), "Der Nachname muss mindestens 3 Zeichen lang sein!");
            }
            if ((u.Geburtsdatum) == (new DateTime(1900, 01, 01)))
            {
                ModelState.AddModelError(nameof(u.Geburtsdatum), "Realistisches Geburtsdatum eingeben!");

            }
            if ((u.geschlecht) == Geschlecht.notSpecified)
            {
                ModelState.AddModelError(nameof(u.geschlecht), "Geschlecht eingeben!");

            }
            if (u.Email == null || u.Email.Length < 10)
            {
                ModelState.AddModelError(nameof(u.Email), "Die Email muss mindestens 10 Zeichen lang sein!");
            }
            if (u.Passwort == null || u.Passwort.Length < 5)
            {
                ModelState.AddModelError(nameof(u.Passwort), "Das Passwort muss mindestens 5 Zeichen lang sein!");
            }

        }
        private List<User> DemoUser()
        {
            return new List<User>()
            {
                new User("Daniel","Niederhauser",Geschlecht.male,new DateTime(2003,4,30),"daniel.niederh@gmail.com", "passwort"),
                new User("Peter", "Mayer", Geschlecht.male, new DateTime(1990, 8, 2), "peter.m@gmail.com", "passwort123"),

        };
        }

    }
}
