using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webprojekt_Niederhauser.Models;

namespace Webprojekt_Niederhauser.Controllers
{
    public class Shopcontroller : Controller
    {
        public IActionResult Index()
        {
            return View(DemoArtikel());
        }
        [HttpGet]
        public IActionResult ArtikelErstellen()
        {
            return View(new Artikel());
        }
        [HttpPost]
        public IActionResult ArtikelErstellen(Artikel neuerArtikel)
        {
            if (neuerArtikel == null)
            {
                return RedirectToAction("ArtikelErstellen");
            }
            ArtikelUeberpruefen(neuerArtikel);

            if (ModelState.IsValid)
            {

                return RedirectToAction("Index", "Home");
            }

            return View(neuerArtikel);
        }
        private void ArtikelUeberpruefen(Artikel a)
        {
            if (a == null)
            {
                return;
            }
            if (a.Bezeichnung == null || a.Bezeichnung.Length < 3)
            {
                ModelState.AddModelError(nameof(Artikel.Bezeichnung), "Die Bezeichnung muss mindestens 3 Zeichen lang sein!");
            }
            if (a.Preis < 0.0m)
            {
                ModelState.AddModelError(nameof(Artikel.Preis), "Der Preis muss positiv oder 0 sein!");
            }
            if ((a.Baujahr) == (new DateTime(1885, 01, 01)))
            {
                ModelState.AddModelError(nameof(Artikel.Baujahr), "Realistisches Datum eingeben!");

            }
            if ((a.Klasse) == Klasse.sonstiges)
            {
                ModelState.AddModelError(nameof(Artikel.Klasse), "Klasse eingeben!");

            }

        }
        private List<Artikel> DemoArtikel()
        {
            return new List<Artikel>()
            {
                new Artikel(1,"Rieju", "Mrt 50", new DateTime(2016,5,18), 3200.90m, Klasse.ccm50),
                new Artikel(2,"KTM", "Duke 125", new DateTime(2020,3,18), 4299.90m, Klasse.ccm125),

        };
        }

    }
}
