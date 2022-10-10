using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfPurchaseOrdersDal : IPurchaseOrdersDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(PurchaseOrders purchaseorders)
        {
            _context.purchaseorders.Add(purchaseorders);
            _context.SaveChanges();
        }

        public void Delete(PurchaseOrders purchaseorders)
        {
            _context.purchaseorders.Remove(purchaseorders);
            _context.SaveChanges();
        }

        public List<PurchaseOrders> GetAll()
        {
            return _context.purchaseorders.ToList();
        }

        public PurchaseOrders GetById(int id)
        {
            return _context.purchaseorders.Find(id);
        }

        public void Update(PurchaseOrders purchaseorders)
        {
            _context.purchaseorders.Update(purchaseorders);
            _context.SaveChanges();
        }
    }
}
