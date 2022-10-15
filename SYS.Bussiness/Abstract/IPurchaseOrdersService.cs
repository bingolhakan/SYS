using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IPurchaseOrdersService
    {
        List<PurchaseOrders> GetAll();
        PurchaseOrders GetById(int id);
        void Add(PurchaseOrders purchaseorders);
        void update(PurchaseOrders purchaseorders);
        void delete(PurchaseOrders purchaseorders);

    }
}
