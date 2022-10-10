using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfSaleOrder_PrivateGroupsDal : ISaleOrder_PrivateGroupsDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(SaleOrder_PrivateGroups saleorder_privategroups)
        {
            _context.saleorder_privategroups.Add(saleorder_privategroups);
            _context.SaveChanges();
        }

        public void Delete(SaleOrder_PrivateGroups saleorder_privategroups)
        {
            _context.saleorder_privategroups.Remove(saleorder_privategroups);
            _context.SaveChanges();
        }

        public List<SaleOrder_PrivateGroups> GetAll()
        {
            return _context.saleorder_privategroups.ToList();
        }

        public SaleOrder_PrivateGroups GetById(int id)
        {
            return _context.saleorder_privategroups.Find(id);
        }

        public void Update(SaleOrder_PrivateGroups saleorder_privategroups)
        {
            _context.saleorder_privategroups.Update(saleorder_privategroups);
            _context.SaveChanges();
        }
    }
}
