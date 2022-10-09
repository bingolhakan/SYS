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
        void Delete(int id);
        void Update(PurchaseOrders purchaseorders);
    }
}
