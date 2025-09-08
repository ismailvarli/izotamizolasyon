using Microsoft.AspNetCore.Mvc;

namespace izotamizolasyon.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult blog()
        {
            return View();
        }
        public IActionResult isi_yalitiminda_yeni_nesil_malzemeler()
        {
            return View();
        }
        public IActionResult catilarda_su_yalitimi_dikkat_edilmesi_gerekenler()
        {
            return View();
        }
        public IActionResult eneri_tasarrufunda__izolasyonun_rolu()
        {
            return View();
        }
    }
}
