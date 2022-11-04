using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
namespace WebApplication6.Controllers
{
    public class ÜniversitemizController : Controller
    {
        // GET: Üniversitemiz
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Duzce()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 1).ToList();
            return View(degerler);
        }
        public ActionResult Kurulus()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 2).ToList();
            return View(degerler);
        }
        public ActionResult Rektor()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 3).ToList();
            return View(degerler);
        }
        public ActionResult RektorYardimcilari()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 4).ToList();
            return View(degerler);
        }
        public ActionResult Senato()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 5).ToList();
            return View(degerler);
        }
        public ActionResult Yonetim()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 6).ToList();
            return View(degerler);
        }
        public ActionResult GenelSekreter()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 7).ToList();
            return View(degerler);
        }
        public ActionResult Rektörlerimiz()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 8).ToList();
            return View(degerler);
        }
        public ActionResult OgrenciSayilari()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 9).ToList();
            return View(degerler);
        }
        public ActionResult PersonelSayilari()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 10).ToList();
            return View(degerler);
        }
        public ActionResult ProjeSayilari()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 11).ToList();
            return View(degerler);
        }
        public ActionResult Derslik()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 12).ToList();
            return View(degerler);
        }
        public ActionResult KapalıAlan()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 13).ToList();
            return View(degerler);
        }
        public ActionResult İlkler()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 14).ToList();
            return View(degerler);
        }
        public ActionResult KurumsalStrateji()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 15).ToList();
            return View(degerler);
        }
        public ActionResult Yemeİcme()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 16).ToList();
            return View(degerler);
        }
        public ActionResult SporMerkezleri()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 17).ToList();
            return View(degerler);
        }
        public ActionResult Ulasim()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 18).ToList();
            return View(degerler);
        }
        public ActionResult Barinma()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 19).ToList();
            return View(degerler);
        }
        public ActionResult YönetmelikVeYönergeler()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 20).ToList();
            return View(degerler);
        }
        public ActionResult İsbirlikleri()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 21).ToList();
            return View(degerler);
        }
        public ActionResult BilgiGüvenligi()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 22).ToList();
            return View(degerler);
        }
        public ActionResult stratejikplan()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 23).ToList();
            return View(degerler);
        }
        public ActionResult kalitepolitikasi()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 24).ToList();
            return View(degerler);
        }
        public ActionResult iyilestirme()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 25).ToList();
            return View(degerler);
        }
        public ActionResult sürdürülebilirlik()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 26).ToList();
            return View(degerler);
        }
        public ActionResult ilkler()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 27).ToList();
            return View(degerler);
        }
        public ActionResult program()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 28).ToList();
            return View(degerler);
        }
        public ActionResult URAP()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 29).ToList();
            return View(degerler);
        }
        public ActionResult THE()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 30).ToList();
            return View(degerler);
        }
        public ActionResult GirisimcilikEndeks()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 31).ToList();
            return View(degerler);
        }
        public ActionResult GreenMetric()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 32).ToList();
            return View(degerler);
        }
        public ActionResult InovaLig()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 33).ToList();
            return View(degerler);
        }
        public ActionResult Teskilat()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 34).ToList();
            return View(degerler);
        }

        public ActionResult İdariBirimler()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 35).ToList();
            return View(degerler);
        }

        public ActionResult Butce()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 36).ToList();
            return View(degerler);
        }

        public ActionResult Mülkiyet()
        {
            var degerler = c.üniversitemizs.Where(x => x.id == 37).ToList();
            return View(degerler);
        }
    }
}