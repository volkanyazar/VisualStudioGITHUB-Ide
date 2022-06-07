using Microsoft.AspNetCore.Mvc;
using Sube2.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sube2.Mvc.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OgrenciEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OgrenciEkle(Ogrenci ogr)
        {
            if (ogr != null)
            {
                try
                {
                    using (var ctx = new OkulDbContext())
                    {
                        ctx.Ogrenciler.Add(ogr);
                        ctx.SaveChanges();
                        
                    }
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return RedirectToAction("OgrenciListe");

        }

        public IActionResult OgrenciListe()
        {
            List<Ogrenci> lst = null;
            using (var ctx = new OkulDbContext())
            {
                lst = ctx.Ogrenciler.ToList();
            }
            return View(lst);
        }


        public IActionResult OgrenciSil(int? id)
        {

            using (var ctx = new OkulDbContext())
            {
                ctx.Remove(ctx.Ogrenciler.Find(id));
                ctx.SaveChanges();
            }
            return RedirectToAction("OgrenciListe");
        }

        public IActionResult OgrenciDuzenle(int? id)
        {
            using (var ctx = new OkulDbContext())
            {
                var lst = ctx.Ogrenciler.Find(id);

                return View(lst);
            }
                
        }
        [HttpPost]
        public IActionResult OgrenciDuzenle(Ogrenci ogrenci)
        {
            using (var ctx = new OkulDbContext())
            {
                ctx.Entry(ogrenci).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("OgrenciListe");
            }

        }

    }

    }

