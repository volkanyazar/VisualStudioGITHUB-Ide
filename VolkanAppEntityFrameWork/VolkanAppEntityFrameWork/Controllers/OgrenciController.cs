using Microsoft.AspNetCore.Mvc;

namespace nihat.Controllers
{
    public class OgrenciController : Controller
    {
        public ViewResult  Index()
        {
            ViewData["Okul"] = "Kazan Myo";
            ViewData["Bolum"] = "Bilgisayar";

            return View();
        }

        public string OgrenciBilgi(int id)
        {
            string ogrenci = "Id gelmedi";
            if (id == 1)
            {
                ogrenci = "Ali veli ";
            }
            else if (id == 2)
            {
                ogrenci = "osman ";
            }
            return ogrenci;
        }
    }
}
