using Microsoft.EntityFrameworkCore;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class AppDbContext :DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Firm_Type> Firm_types { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<PurchaseOrder> Purchaseorders { get; set; }
        public DbSet<SaleOrder> Saleorders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Stock_Unit> Stock_Units { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Stock_TransferBody> Stock_TransferBodies { get; set; }
        public DbSet<Stock_TransferHeader> Stock_TransferHeaders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HAKANBINGOL-NB\\SQLEXPRESS;Initial Catalog=SYS_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


    }
}
