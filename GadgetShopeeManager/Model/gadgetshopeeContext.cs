using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetShopeeManager.Model
{
    internal class gadgetshopeeContext : DbContext
    {
        public virtual DbSet<Gadget> Gadgets { get; set; }
        public virtual DbSet<Licit> Licits { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\GadgetShopee\\GadgetShopeeManager\\Database\\GadgetShopeeDB.mdf;Integrated Security=True");
        }
    }
}
