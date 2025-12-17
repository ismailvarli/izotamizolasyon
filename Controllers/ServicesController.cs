using Microsoft.AspNetCore.Mvc;

namespace izotamizolasyon.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult hizmetlerimiz()
        {
            return View();
        }
        public IActionResult isi_yalitimi()
        {
            return View();
        }
        public IActionResult su_yalitimi()
        {
            return View();
        }
        public IActionResult ses_yalitimi()
        {
            return View();
        }
        public IActionResult yangin_yalitimi()
        {
            return View();
        }
        public IActionResult cati_izolasyonu()
        {
            return View();
        }
        public IActionResult dis_cephe_mantolama()
        {
            return View();
        }
        public IActionResult temel_ve_zemin_izolasyonu()
        {
            return View();
        }
        public IActionResult endustriyel_izolasyon()
        {
            return View();
        }
        public IActionResult bohcalamaizolasyon()
        {
            return View();
        }
        public IActionResult singilcati()
        {
            return View();
        }
        public IActionResult kiremitcati()
        {
            return View();
        }
        public IActionResult terasizolasyon()
        {
            return View();
        }
        public IActionResult membrancati()
        {
            return View();
        }
        public IActionResult poliuretansurmeizolasyon()
        {
            return View();
        }
        public IActionResult surmeizolasyon()
        {
            return View();
        }
        [Route("beton-silim")]
        public IActionResult betonsilim()
        {
            return View();
        }

    }
}
