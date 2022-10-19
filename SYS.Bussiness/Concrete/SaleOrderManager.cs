using SYS.Bussiness.Abstract;
using SYS.Dal.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Concrete
{
    public class SaleOrderManager : ISaleOrderService
    {
        EfSaleOrderDal _saleordersDal = new EfSaleOrderDal();
        public void Add(SaleOrder saleorders)
        {
            _saleordersDal.Add(saleorders);
        }

        public void Delete(SaleOrder saleorders)
        {
            _saleordersDal.Delete(saleorders);
        }

        public List<SaleOrder> GetAll()
        {
            return _saleordersDal.GetAll();
        }

        public SaleOrder GetById(int id)
        {
            return _saleordersDal.GetById(id);
        }

        public void Update(SaleOrder saleorders)
        {
            _saleordersDal.Update(saleorders);
        }
    }
}
