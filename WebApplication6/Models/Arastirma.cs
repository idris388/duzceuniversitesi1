using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Models
{
    public class Arastirma
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        [AllowHtml]

        public string İcerik { get; set; }
    }
}