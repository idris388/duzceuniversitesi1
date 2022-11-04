using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [AllowHtml]
        public string adminAd { get; set; }
        [AllowHtml]
        public string adminMail { get; set; }
        [AllowHtml]
        public string adminSifre { get; set; } 
    }
}