using SYS.Bussiness.Abstract;
using SYS.Dal.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Conctrete
{
    public class SaleOrdersManager : ISaleOrdersService
    {
        EfSaleOrdersDal _saleorders = new EfSaleOrdersDal();
        public void Add(SaleOrders saleorders)
        {
            _saleorders.Add(saleorders);
        }

        public void Delete(SaleOrders saleorders)
        {
            _saleorders.Delete(saleorders);
        }

        public List<SaleOrders> GetAll()
        {
            return _saleorders.GetAll();
        }

        public SaleOrders GetById(int id)
        {
            return _saleorders.GetById(id);
        }

        public void Update(SaleOrders saleorders)
        {
            _saleorders.Update(saleorders);
        }
    }
}
