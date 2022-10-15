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
    public class SaleOrder_PrivateGroupsManager : ISaleOrder_PrivateGroupsService
    {
        EfSaleOrder_PrivateGroupsDal _saleorder_privategroups=new EfSaleOrder_PrivateGroupsDal();
        public void Add(SaleOrder_PrivateGroups saleorder_privategroups)
        {
            _saleorder_privategroups.Add(saleorder_privategroups);
        }

        public void Delete(SaleOrder_PrivateGroups saleorder_privategroups)
        {
            _saleorder_privategroups.Delete(saleorder_privategroups);
        }

        public List<SaleOrder_PrivateGroups> GetAll()
        {
            return _saleorder_privategroups.GetAll();
        }

        public SaleOrder_PrivateGroups GetById(int id)
        {
            return _saleorder_privategroups.GetById(id);
        }

        public void Update(SaleOrder_PrivateGroups saleorder_privategroups)
        {
           _saleorder_privategroups.Update(saleorder_privategroups);
        }
    }
}
