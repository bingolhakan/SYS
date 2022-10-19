using SYS.Bussiness.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Concrete
{
    public class PurchaseOrderManager : IPurchaseOrderService
    {
        EfPurchaseOrderDal _purchaseordersDal = new EfPurchaseOrderDal();
        public void Add(PurchaseOrder purchaseorders)
        {
            _purchaseordersDal.Add(purchaseorders);
        }

        public void delete(PurchaseOrder purchaseorders)
        {
            _purchaseordersDal.Delete(purchaseorders);
        }

        public List<PurchaseOrder> GetAll()
        {
            return _purchaseordersDal.GetAll();
        }

        public PurchaseOrder GetById(int id)
        {
            return _purchaseordersDal.GetById(id);
        }

        public void update(PurchaseOrder purchaseorders)
        {
            _purchaseordersDal.Update(purchaseorders);
        }
    }
}
