using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfSaleOrderDal : ISaleOrderDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(SaleOrder saleorder)
        {
            _context.Saleorders.Add(saleorder);
            _context.SaveChanges();
        }

        public void Delete(SaleOrder saleorder)
        {
            _context.Saleorders.Remove(saleorder);
            _context.SaveChanges();
        }

        public List<SaleOrder> GetAll()
        {
            return _context.Saleorders.ToList();
        }

        public SaleOrder GetById(int id)
        {
            return _context.Saleorders.Find(id);
        }

        public void Update(SaleOrder saleorder)
        {
            _context.Saleorders.Update(saleorder);
            _context.SaveChanges();
        }
    }
}
