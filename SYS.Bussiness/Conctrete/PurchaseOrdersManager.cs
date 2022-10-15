using SYS.Bussiness.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Conctrete
{
    public class PurchaseOrdersManager : IPurchaseOrdersService
    {
        EfPurchaseOrdersDal _purchaseorders = new EfPurchaseOrdersDal();
        public void Add(PurchaseOrders purchaseorders)
        {
            _purchaseorders.Add(purchaseorders);
        }

        public void delete(PurchaseOrders purchaseorders)
        {
            _purchaseorders.Delete(purchaseorders);
        }

        public List<PurchaseOrders> GetAll()
        {
            return _purchaseorders.GetAll();
        }

        public PurchaseOrders GetById(int id)
        {
            return _purchaseorders.GetById(id);
        }

        public void update(PurchaseOrders purchaseorders)
        {
            _purchaseorders.Update(purchaseorders);
        }
    }
}
