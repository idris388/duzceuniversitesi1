using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Models
{
    public class Duyurular
    {
        public int ID { get; set; }
        public string DuyuruBaslik { get; set; }
        [AllowHtml]
        public string DuyuruBaslikResim { get; set; }
        public DateTime DuyuruTarih { get; set; }
        [AllowHtml]
        public string İcerik { get; set; }
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}