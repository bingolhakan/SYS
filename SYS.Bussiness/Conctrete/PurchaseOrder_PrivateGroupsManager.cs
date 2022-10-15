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
    public class PurchaseOrder_PrivateGroupsManager : IPurchaseOrder_PrivateGroupsService
    {
        EfPurchaseOrder_PrivateGroupsDal _purchaseorder_privategroupsdal = new EfPurchaseOrder_PrivateGroupsDal();
        public void add(PurchaseOrder_PrivateGroups purchaseorder_privategroups)
        {
            _purchaseorder_privategroupsdal.Add(purchaseorder_privategroups);
        }

        public void delete(PurchaseOrder_PrivateGroups purchaseorder_privategroups)
        {
            _purchaseorder_privategroupsdal.Delete(purchaseorder_privategroups);
        }

        public List<PurchaseOrder_PrivateGroups> GetAll()
        {
            return _purchaseorder_privategroupsdal.GetAll();
        }

        public PurchaseOrder_PrivateGroups GetById(int id)
        {
            return _purchaseorder_privategroupsdal.GetById(id);
        }

        public void update(PurchaseOrder_PrivateGroups purchaseorder_privategroups)
        {
            _purchaseorder_privategroupsdal.Update(purchaseorder_privategroups);
        }
    }
}
