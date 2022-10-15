using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IPurchaseOrder_PrivateGroupsService
    {
        List<PurchaseOrder_PrivateGroups> GetAll();
        PurchaseOrder_PrivateGroups GetById(int id);
        void add (PurchaseOrder_PrivateGroups purchaseorder_privategroups);
        void delete (PurchaseOrder_PrivateGroups purchaseorder_privategroups);
        void update (PurchaseOrder_PrivateGroups purchaseorder_privategroups);

    }
}
