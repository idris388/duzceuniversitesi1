using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication6.Models
{
    public class Context:DbContext
    {
        public Context():base(nameOrConnectionString:"Context")     
        {

        }
        public DbSet<Admin> admins { get; set; }
        public DbSet<İhtisaslaşma>ihtisaslaşmas { get; set; }
        public DbSet<Üniversitemiz>üniversitemizs { get; set; }
        public DbSet<Arastirma>arastirmas { get; set; }
        public DbSet<Duyurular>duyurulars { get; set; }
        public DbSet<Kategori>kategoris { get; set; }
        public DbSet<Fakülte>fakültes { get; set; }
        public DbSet<FakülteGenelBilgi>fakülteGenelBilgis { get; set; }
    }
}