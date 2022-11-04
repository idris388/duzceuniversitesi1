using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;
using Context = WebApplication6.Models.Context;

namespace WebApplication6.Controllers
{
    public class ArastirmaController : Controller
    {
        // GET: Arastirma
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ArastirmaMerkezi()
        {
            var degerler = c.arastirmas.Where(x => x.ID == 1).ToList();
            return View(degerler);
        }
        public ActionResult LaboratuvarEnvanteri()
        {
            var degerler = c.arastirmas.Where(x => x.ID== 2).ToList();
            return View(degerler);
        }
        public ActionResult YayinlarProjeler()
        {
            var degerler = c.arastirmas.Where(x => x.ID == 3).ToList();
            return View(degerler);
        }
        public ActionResult HakemliDergiler()
        {
            var degerler = c.arastirmas.Where(x => x.ID == 4).ToList();
            return View(degerler);
        }
        public ActionResult TeknolojiTransferOfisi()
        {
            var degerler = c.arastirmas.Where(x => x.ID == 5).ToList();
            return View(degerler);
        }
        public ActionResult Kurullar()
        {
            var degerler = c.arastirmas.Where(x => x.ID == 7).ToList();
            return View(degerler);
        }
    }
}