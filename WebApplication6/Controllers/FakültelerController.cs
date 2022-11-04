using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class FakültelerController : Controller
    {
        // GET: Fakülteler
        Context c = new Context();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AkcakocaSiyasal()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 1).ToList();
            return View(degerler);
        }
        public ActionResult Yönetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 1).ToList();
            return View(degerler);
        }
        public ActionResult Personel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 1).ToList();
            return View(degerler);
        }
        public ActionResult Fakültemiz()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 1).ToList();
            return View(degerler);
        }
        public ActionResult MFGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 2).ToList();
            return View(degerler);
        }
        public ActionResult MFYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 2).ToList();
            return View(degerler);
        }
        public ActionResult MFPersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 2).ToList();
            return View(degerler);
        }
        public ActionResult MFFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 2).ToList();
            return View(degerler);
        }



        public ActionResult EczacılıkGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 3).ToList();
            return View(degerler);
        }
        public ActionResult EczacılıkYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 3).ToList();
            return View(degerler);
        }
        public ActionResult EczacılıkPersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 3).ToList();
            return View(degerler);
        }
        public ActionResult EczacılıkFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 3).ToList();
            return View(degerler);
        }
        public ActionResult EczacılıkÖgrenci()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 3).ToList();
            return View(degerler);
        }




        public ActionResult TıpGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 4).ToList();
            return View(degerler);
        }
        public ActionResult TıpYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 4).ToList();
            return View(degerler);
        }
        public ActionResult TıpPersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 4).ToList();
            return View(degerler);
        }
        public ActionResult TıpFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 4).ToList();
            return View(degerler);
        }
        public ActionResult TıpÖgrenci()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 4).ToList();
            return View(degerler);
        }

        public ActionResult FenGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 5).ToList();
            return View(degerler);
        }
        public ActionResult FenYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 5).ToList();
            return View(degerler);
        }
        public ActionResult FenPersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 5).ToList();
            return View(degerler);
        }
        public ActionResult FenFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 5).ToList();
            return View(degerler);
        }
        public ActionResult FenÖgrenci()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 5).ToList();
            return View(degerler);
        }

        public ActionResult OrmanGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 6).ToList();
            return View(degerler);
        }
        public ActionResult OrmanYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 6).ToList();
            return View(degerler);
        }
        public ActionResult OrmanPersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 6).ToList();
            return View(degerler);
        }
        public ActionResult OrmanFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 6).ToList();
            return View(degerler);
        }
        public ActionResult OrmanÖgrenci()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 6).ToList();
            return View(degerler);
        }


        public ActionResult LisansÜstüGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 7).ToList();
            return View(degerler);
        }
        public ActionResult LisansÜstüYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 7).ToList();
            return View(degerler);
        }
        public ActionResult LisansÜstüPersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 7).ToList();
            return View(degerler);
        }
        public ActionResult LisansÜstüFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 7).ToList();
            return View(degerler);
        }
        public ActionResult LisansÜstüÖgrenci()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 7).ToList();
            return View(degerler);
        }

        public ActionResult AkcakocaYOGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 8).ToList();
            return View(degerler);
        }
        public ActionResult AkcakocaYOYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 8).ToList();
            return View(degerler);
        }
        public ActionResult AkcakocaYOPersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 8).ToList();
            return View(degerler);
        }
        public ActionResult AkcakocaYOFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 8).ToList();
            return View(degerler);
        }
        public ActionResult AkcakocaYOÖgrenci()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 8).ToList();
            return View(degerler);
        }

        public ActionResult HakimeErciyasGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 9).ToList();
            return View(degerler);
        }
        public ActionResult HakimeErciyasYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 9).ToList();
            return View(degerler);
        }
        public ActionResult HakimeErciyasPersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 9).ToList();
            return View(degerler);
        }
        public ActionResult HakimeErciyasFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 9).ToList();
            return View(degerler);
        }
        public ActionResult HakimeErciyasÖgrenci()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 9).ToList();
            return View(degerler);
        }

        public ActionResult CilimliGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 10).ToList();
            return View(degerler);
        }
        public ActionResult CilimliYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 10).ToList();
            return View(degerler);
        }
        public ActionResult CilimliPersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 10).ToList();
            return View(degerler);
        }
        public ActionResult CilimliFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 10).ToList();
            return View(degerler);
        }
        public ActionResult CilimliÖgrenci()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 10).ToList();
            return View(degerler);
        }

        public ActionResult DuzceGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 11).ToList();
            return View(degerler);
        }
        public ActionResult DuzceYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 11).ToList();
            return View(degerler);
        }
        public ActionResult DuzcePersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 11).ToList();
            return View(degerler);
        }
        public ActionResult DuzceFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 11).ToList();
            return View(degerler);
        }
        public ActionResult DuzceÖgrenci()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 11).ToList();
            return View(degerler);
        }

        public ActionResult GolyakaGenelBilgi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 12).ToList();
            return View(degerler);
        }
        public ActionResult GolyakaYonetim()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 12).ToList();
            return View(degerler);
        }
        public ActionResult GolyakaPersonel()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 12).ToList();
            return View(degerler);
        }
        public ActionResult GolyakaFakülte()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 12).ToList();
            return View(degerler);
        }
        public ActionResult GolyakaÖgrenci()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 12).ToList();
            return View(degerler);
        }
        public ActionResult EgitimFakültesi()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 13).ToList();
            return View(degerler);
        }

        public ActionResult SporBilimleri()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 14).ToList();
            return View(degerler);
        }
        public ActionResult İsletme()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 15).ToList();
            return View(degerler);
        }

        public ActionResult SanatVeTasarım()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 16).ToList();
            return View(degerler);
        }
        public ActionResult Ziraat()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 17).ToList();
            return View(degerler);
        }
        public ActionResult SaglikBilimleri()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 18).ToList();
            return View(degerler);
        }
        public ActionResult AtatürkVeTarih()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 19).ToList();
            return View(degerler);
        }
        public ActionResult TürkDili()
        {
            var degerler = c.fakülteGenelBilgis.Where(x => x.ID == 20).ToList();
            return View(degerler);
        }
    }
}