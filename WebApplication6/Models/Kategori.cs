using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriId { get; set; }
        [AllowHtml]

        public string KategoriAd { get; set; }
        public ICollection<Duyurular> Duyurulars { get; set; }
    }
}