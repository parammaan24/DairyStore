using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DairyStore.Models;

namespace DairyStore.Data
{
    public class DairyStoreContext : DbContext
    {
        public DairyStoreContext (DbContextOptions<DairyStoreContext> options)
            : base(options)
        {
        }

        public DbSet<DairyStore.Models.Owner> Owner { get; set; }

        public DbSet<DairyStore.Models.Product> Product { get; set; }

        public DbSet<DairyStore.Models.Suppliers> Suppliers { get; set; }

        public DbSet<DairyStore.Models.Order> Order { get; set; }
    }
}
