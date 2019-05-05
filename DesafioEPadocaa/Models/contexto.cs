using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace DesafioEPadocaa.Models
{
    public class contexto:DbContext
    {
        public DbSet<padaria> Padarias { get; set; }
    }
}