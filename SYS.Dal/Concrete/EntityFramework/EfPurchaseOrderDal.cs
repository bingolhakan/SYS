using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfPurchaseOrderDal : IPurchaseOrderDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(PurchaseOrder purchaseorder)
        {
            _context.Purchaseorders.Add(purchaseorder);
            _context.SaveChanges();
        }

        public void Delete(PurchaseOrder purchaseorder)
        {
            _context.Purchaseorders.Remove(purchaseorder);
            _context.SaveChanges();
        }

        public List<PurchaseOrder> GetAll()
        {
            return _context.Purchaseorders.ToList();
        }

        public PurchaseOrder GetById(int id)
        {
            return _context.Purchaseorders.Find(id);
        }

        public void Update(PurchaseOrder purchaseorder)
        {
            _context.Purchaseorders.Update(purchaseorder);
            _context.SaveChanges();
        }
    }
}
