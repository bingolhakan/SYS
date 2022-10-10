using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfSaleOrdersDal : ISaleOrdersDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(SaleOrders saleorders)
        {
            _context.saleorders.Add(saleorders);
            _context.SaveChanges();
        }

        public void Delete(SaleOrders saleorders)
        {
            _context.saleorders.Remove(saleorders);
            _context.SaveChanges();
        }

        public List<SaleOrders> GetAll()
        {
            return _context.saleorders.ToList();
        }

        public SaleOrders GetById(int id)
        {
            return _context.saleorders.Find(id);
        }

        public void Update(SaleOrders saleorders)
        {
            _context.saleorders.Update(saleorders);
            _context.SaveChanges();
        }
    }
}
