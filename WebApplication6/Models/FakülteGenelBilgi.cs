using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Models
{
    public class FakülteGenelBilgi
    {
        public int ID { get; set; }
        [AllowHtml]
        public string GenelBilgi { get; set; }
        [AllowHtml]
        public string Yonetim { get; set; }
        [AllowHtml]
        public string Personel { get; set; }
        [AllowHtml]
        public string Ogrenci { get; set; }
        [AllowHtml]
        public string Fakültemiz { get; set; }
        [AllowHtml]
        public int FakülteID { get; set; }
        public virtual Fakülte Fakülte { get; set; }
    }
}