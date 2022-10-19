using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface ISaleOrderService
    {
        List<SaleOrder> GetAll();
        SaleOrder GetById(int id);
        void Add(SaleOrder saleorder);
        void Update(SaleOrder saleorder);
        void Delete(SaleOrder saleorder);

    }
}
