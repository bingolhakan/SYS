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
        public DbSet<Countries> countries { get; set; }
        public DbSet<Currencies> currencies { get; set; }
        public DbSet<Firm_PrivateGroups> firm_privategroups { get; set; }
        public DbSet<Firm_Types> firm_types { get; set; }
        public DbSet<Firms> firms { get; set; }
        public DbSet<PurchaseOrder_PrivateGroups> purchaseorder_privategroups { get; set; }
        public DbSet<PurchaseOrders> purchaseorders { get; set; }
        public DbSet<SaleOrder_PrivateGroups> saleorder_privategroups { get; set; }
        public DbSet<SaleOrders> SaleOrders { get; set; }
        public DbSet<Staffs> staffs { get; set; }
        public DbSet<Stock_PrivateGroups> stock_privategroups { get; set; }
        public DbSet<Stock_Units> Stock_Units { get; set; }
        public DbSet<Stocks> stocks { get; set; }
        public DbSet<Users> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HAKANBINGOL-NB\\SQLEXPRESS;Initial Catalog=SYS_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


    }
}
