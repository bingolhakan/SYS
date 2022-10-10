using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IPurchaseOrdersDal
    {
        List<PurchaseOrders> GetAll();
        PurchaseOrders GetById(int id);
        void Add(PurchaseOrders purchaseorders);
        void Delete(PurchaseOrders purchaseorders);
        void Update(PurchaseOrders purchaseorders);
    }
}
