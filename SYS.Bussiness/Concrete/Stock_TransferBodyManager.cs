using SYS.Bussiness.Abstract;
using SYS.Dal.Concrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Concrete
{
    public class Stock_TransferBodyManager : IStock_TransferBodyService
    {
        EfStock_TransferBodyDal _stock_transferbodydal = new EfStock_TransferBodyDal();
        public void Add(Stock_TransferBody stock_transferbody)
        {
            _stock_transferbodydal.Add(stock_transferbody);
        }

        public void Delete(Stock_TransferBody stock_transferbody)
        {
            _stock_transferbodydal.Delete(stock_transferbody);
        }

        public List<Stock_TransferBody> GetAll()
        {
            return _stock_transferbodydal.GetAll();
        }

        public Stock_TransferBody GetById(int id)
        {
            return _stock_transferbodydal.GetById(id);
        }

        public void Update(Stock_TransferBody stock_transferbody)
        {
            _stock_transferbodydal.Update(stock_transferbody);
        }
    }
}
