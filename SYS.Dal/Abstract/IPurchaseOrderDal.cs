using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IPurchaseOrderDal
    {
        List<PurchaseOrder> GetAll();
        PurchaseOrder GetById(int id);
        void Add(PurchaseOrder purchaseorder);
        void Delete(PurchaseOrder purchaseorder);
        void Update(PurchaseOrder purchaseorder);
    }
}
