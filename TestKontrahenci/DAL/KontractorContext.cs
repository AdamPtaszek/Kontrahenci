using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestKontrahenci.Models;

namespace TestKontrahenci.DAL
{
    public class KontractorContext : DbContext
    {
        public KontractorContext() : base("conntectionString")
        {

        }

        public DbSet<Kontractor> Kontractor { get; set; }
    }
}