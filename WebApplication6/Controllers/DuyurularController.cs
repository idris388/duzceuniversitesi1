using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using PagedList;
using PagedList.Mvc;
namespace WebApplication6.Controllers
{
    public class DuyurularController : Controller
    {
        // GET: Duyurular
        Context c = new Context();
        public ActionResult Index(int sayfa = 1)
        {
            var degerler = c.duyurulars.OrderByDescending(x=>x.DuyuruTarih).ToPagedList(sayfa, 5);
            return View(degerler);
        }
        public ActionResult DuyuruDetay(int id)
        {
            var detaybul = c.duyurulars.Where(x => x.ID == id).ToList();
            return View(detaybul);
        }
    }
}