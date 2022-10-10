using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfPurchaseOrder_PrivateGroupsDal : IPurchaseOrder_PrivateGroupsDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(PurchaseOrder_PrivateGroups purchaseorder_privategroups)
        {
            _context.purchaseorder_privategroups.Add(purchaseorder_privategroups);
            _context.SaveChanges();
        }

        public void Delete(PurchaseOrder_PrivateGroups purchaseorder_privategroups)
        {
            _context.purchaseorder_privategroups.Remove(purchaseorder_privategroups);
            _context.SaveChanges();
        }

        public List<PurchaseOrder_PrivateGroups> GetAll()
        {
            return _context.purchaseorder_privategroups.ToList();
        }

        public PurchaseOrder_PrivateGroups GetById(int id)
        {
            return _context.purchaseorder_privategroups.Find(id);
        }

        public void Update(PurchaseOrder_PrivateGroups purchaseorder_privategorups)
        {
            _context.purchaseorder_privategroups.Update(purchaseorder_privategorups);
            _context.SaveChanges();
        }
    }
}
