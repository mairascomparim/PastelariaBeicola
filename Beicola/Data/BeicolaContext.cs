using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Beicola.Models;

namespace Beicola.Data
{
    public class BeicolaContext : DbContext
    {
        public BeicolaContext (DbContextOptions<BeicolaContext> options)
            : base(options)
        {
        }

        public DbSet<Beicola.Models.Categorie>? Categorie { get; set; }

        public DbSet<Beicola.Models.Cities> Cities { get; set; }

        public DbSet<Beicola.Models.Products> Products { get; set; }
    }
}
