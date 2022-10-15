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
    public class StocksManager : IStocksService
    {
        EfStocksDal _stocksdal = new EfStocksDal();
        public void Add(Stocks stocks)
        {
            _stocksdal.Add(stocks);
        }

        public void Delete(Stocks stocks)
        {
            _stocksdal.Delete(stocks);
        }

        public List<Stocks> GetAll()
        {
            return _stocksdal.GetAll();
        }

        public Stocks GetByID(int id)
        {
            return _stocksdal.GetById(id);
        }

        public void Update(Stocks stocks)
        {
            _stocksdal.Update(stocks);
        }
    }
}
