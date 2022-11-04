using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Fakülte
    {
        [Key]
        public int FakülteID { get; set; }
        public string FakülteAdi { get; set; }
        public ICollection<FakülteGenelBilgi> fakülteGenelBilgis { get; set; }
    }
}