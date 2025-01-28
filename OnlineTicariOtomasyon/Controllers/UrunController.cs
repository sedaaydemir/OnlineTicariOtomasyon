using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTicariOtomasyon.Models.Siniflar;


namespace OnlineTicariOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        Context c= new Context();
        // GET: Urun
        public ActionResult Index()
        {
            var urunler = c.Uruns.ToList();
            return View(urunler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniUrun(Urun p)
        {
           c.Uruns.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}