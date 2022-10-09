using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IPurchaseOrder_PrivateGroups
    {
        List<PurchaseOrder_PrivateGroups> GetAll();
        PurchaseOrder_PrivateGroups GetById(int id);
        void Add(PurchaseOrder_PrivateGroups purchaseorder_privategroups);
        void Remove(int id);
        void Update(PurchaseOrder_PrivateGroups purchaseorder_privategorups);
    }
}
