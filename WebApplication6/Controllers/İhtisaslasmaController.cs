using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class İhtisaslasmaController : Controller
    {
        // GET: İhtisaslasma
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProgramKapsami()
        {
            var degerler = c.ihtisaslaşmas.Where(x => x.ID == 1).ToList();
            return View(degerler);
        }
        public ActionResult tibbiBitki()
        {
            var degerler = c.ihtisaslaşmas.Where(x => x.ID == 2).ToList();
            return View(degerler);
        }
        public ActionResult ürünVeMarkalar()
        {
            var degerler = c.ihtisaslaşmas.Where(x => x.ID == 3).ToList();
            return View(degerler);
        }
        public ActionResult gelenekselTip()
        {
            var degerler = c.ihtisaslaşmas.Where(x => x.ID == 4).ToList();
            return View(degerler);
        }
        public ActionResult TarimsalAtiklar()
        {
            var degerler = c.ihtisaslaşmas.Where(x => x.ID == 5).ToList();
            return View(degerler);
        }
        public ActionResult ArıcılıkVeAri()
        {
            var degerler = c.ihtisaslaşmas.Where(x => x.ID == 6).ToList();
            return View(degerler);
        }
        public ActionResult BilimselYayinlar()
        {
            var degerler = c.ihtisaslaşmas.Where(x => x.ID == 7).ToList();
            return View(degerler);
        }
        public ActionResult İsbirlikleri()
        {
            var degerler = c.ihtisaslaşmas.Where(x => x.ID == 8).ToList();
            return View(degerler);
        }
        public ActionResult Etkinlikler()
        {
            var degerler = c.ihtisaslaşmas.Where(x => x.ID == 9).ToList();
            return View(degerler);
        }
        public ActionResult üretimMerkezi()
        {
            var degerler = c.ihtisaslaşmas.Where(x => x.ID == 10).ToList();
            return View(degerler);
        }

    }
}