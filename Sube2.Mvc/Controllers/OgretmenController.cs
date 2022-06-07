using Microsoft.AspNetCore.Mvc;
using Sube2.Mvc.Models;
using System.Collections;
using System.Collections.Generic;

namespace Sube2.Mvc.Controllers
{
    public class OgretmenController : Controller
    {
        public IActionResult Index()
        {
            var ogr = new Ogretmen();
            ogr.Ad = "Ahmet";
            ogr.Soyad = "Mehmet";
            ogr.Tckimlik = 123;

            ViewData["ogretmen"] = ogr;
            ViewBag.ogrt = ogr;

            return View(ogr);
        }

        public ViewResult OgretmenListe()
        {
            
            List<Ogretmen> lst = new List<Ogretmen>
            {
                new Ogretmen{Ad="Ali",Soyad="Veli",Tckimlik=123 },
                new Ogretmen{Ad="Ahmet",Soyad="Mehmet",Tckimlik=456 },
                new Ogretmen{Ad="Hakan",Soyad="Yılmaz",Tckimlik=789 }
            };


            return View(lst);
        }
    }
}
