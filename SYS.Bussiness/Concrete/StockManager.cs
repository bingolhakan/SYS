using SYS.Bussiness.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Concrete
{
    public class StockManager : IStockService
    {
        EfStockDal _stocksDal = new EfStockDal();
        public void Add(Stock stocks)
        {
            _stocksDal.Add(stocks);
        }

        public void Delete(Stock stocks)
        {
            _stocksDal.Delete(stocks);
        }

        public List<Stock> GetAll()
        {
            return _stocksDal.GetAll();
        }

        public Stock GetByID(int id)
        {
            return _stocksDal.GetById(id);
        }

        public void Update(Stock stocks)
        {
            _stocksDal.Update(stocks);
        }
    }
}
