using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listele()
        {
            var degerler = c.üniversitemizs.ToList();
            return View(degerler);
        }
        public ActionResult UniversiteBilgiGetir(int id)
        {
            var dpt = c.üniversitemizs.Find(id);
            return View("UniversiteBilgiGetir", dpt);
        }
        public ActionResult UniversiteBilgiGuncelle(Üniversitemiz d)
        {
            var dpt = c.üniversitemizs.Find(d.id);
            dpt.Baslik = d.Baslik;
            dpt.İcerik = d.İcerik;
            dpt.Resim = d.Resim;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult HakkimizdaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HakkimizdaEkle(Üniversitemiz k)
        {
            c.üniversitemizs.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ArastirmaListele()
        {
            var degerler = c.arastirmas.ToList();
            return View(degerler);
        }
        public ActionResult ArastirmaBilgiGetir(int id)
        {
            var dpt = c.arastirmas.Find(id);
            return View("ArastirmaBilgiGetir", dpt);
        }
        public ActionResult ArastirmaBilgiGuncelle(Arastirma d)
        {
            var dpt = c.arastirmas.Find(d.ID);
            dpt.Baslik = d.Baslik;
            dpt.İcerik = d.İcerik;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ArastirmaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ArastirmaEkle(Arastirma k)
        {
            c.arastirmas.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult İhtisaslasmaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult İhtisaslasmaEkle(İhtisaslaşma k)
        {
            c.ihtisaslaşmas.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult İhtisaslasmaListele()
        {
            var degerler = c.ihtisaslaşmas.ToList();
            return View(degerler);
        }
        public ActionResult İhtisaslasmaBilgiGetir(int id)
        {
            var dpt = c.ihtisaslaşmas.Find(id);
            return View("İhtisaslasmaBilgiGetir", dpt);
        }
        public ActionResult İhtisaslasmaBilgiGuncelle(İhtisaslaşma d)
        {
            var dpt = c.ihtisaslaşmas.Find(d.ID);
            dpt.Baslik = d.Baslik;
            dpt.İcerik = d.İcerik;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Kategori k)
        {
            c.kategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KategoriListele()
        {
            var degerler = c.kategoris.ToList();
            return View(degerler);
        }
        public ActionResult KategoriGetir(int id)
        {
            var dpt = c.kategoris.Find(id);
            return View("KategoriGetir", dpt);
        }
        public ActionResult KategoriGuncelle(Kategori d)
        {
            var dpt = c.kategoris.Find(d.KategoriId);
            dpt.KategoriAd = d.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DuyuruEkle()
        {
            List<SelectListItem> deger = (from x in c.kategoris.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.KategoriAd,
                                              Value = x.KategoriId.ToString()

                                          }).ToList();
            ViewBag.dgr1 = deger;
            return View();
        }
        [HttpPost]
        public ActionResult DuyuruEkle(Duyurular k)
        {
            c.duyurulars.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult FakülteEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FakülteEkle(Fakülte k)
        {
            c.fakültes.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FakülteListele()
        {
            var degerler = c.fakültes.ToList();
            return View(degerler);
        }

        public ActionResult FakülteBilgiGetir(int id)
        {
            var dpt = c.fakültes.Find(id);
            return View("FakülteBilgiGetir", dpt);
        }
        public ActionResult FakülteBilgiGuncelle(Fakülte d)
        {
            var dpt = c.fakültes.Find(d.FakülteID);
            dpt.FakülteAdi = d.FakülteAdi;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult FakülteBilgiEkle()
        {
            List<SelectListItem> deger = (from x in c.fakültes.ToList()
                                          select new SelectListItem
                                          {
                                              Text = x.FakülteAdi,
                                              Value = x.FakülteID.ToString()

                                          }).ToList();
            ViewBag.dgr1 = deger;
            return View();
        }
        [HttpPost]
        public ActionResult FakülteBilgiEkle(FakülteGenelBilgi k)
        {
            c.fakülteGenelBilgis.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult FakülteBilgiListele()
        {
            var degerler = c.fakülteGenelBilgis.ToList();
            return View(degerler);
        }
        public ActionResult FakulteBilgiGetir(int id)
        {
            var dpt = c.fakülteGenelBilgis.Find(id);
            return View("FakulteBilgiGetir", dpt);
        }
        public ActionResult FakulteBilgiGuncelle(FakülteGenelBilgi d)
        {
            var dpt = c.fakülteGenelBilgis.Find(d.ID);
            dpt.GenelBilgi = d.GenelBilgi;
            dpt.Personel = d.Personel;
            dpt.Ogrenci = d.Ogrenci;
            dpt.Yonetim = d.Yonetim;
            dpt.Fakültemiz = d.Fakültemiz;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}