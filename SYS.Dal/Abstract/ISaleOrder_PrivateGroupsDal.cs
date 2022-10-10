using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface ISaleOrder_PrivateGroupsDal
    {
        List<SaleOrder_PrivateGroups> GetAll();
        SaleOrder_PrivateGroups GetById(int id);
        void Add(SaleOrder_PrivateGroups saleorder_privategroups);
        void Delete(SaleOrder_PrivateGroups saleorder_privategroups);
        void Update(SaleOrder_PrivateGroups saleorder_privategroups);
    }
}
