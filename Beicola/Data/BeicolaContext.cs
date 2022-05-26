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

        public DbSet<Beicola.Models.Categorie> Categories { get; set; }

        public DbSet<Beicola.Models.Cities> Cities { get; set; }

        public DbSet<Beicola.Models.Products> Products { get; set; }

        public DbSet<Beicola.Models.Settings> Settings { get; set; }

        public DbSet<Beicola.Models.SubCategories> SubCategories { get; set; }
    }
}
