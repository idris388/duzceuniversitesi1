using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var deger = c.admins.FirstOrDefault(x => x.adminMail == p.adminMail && x.adminSifre == p.adminSifre);
            if (deger != null)
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }

        }
    }
}