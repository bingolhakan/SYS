using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IPurchaseOrderService
    {
        List<PurchaseOrder> GetAll();
        PurchaseOrder GetById(int id);
        void Add(PurchaseOrder purchaseorder);
        void update(PurchaseOrder purchaseorder);
        void delete(PurchaseOrder purchaseorder);

    }
}
