using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IStockDal
    {
        List<Stock> GetAll();
        Stock GetById(int id);
        void Add(Stock stock);
        void Delete(Stock stock);
        void Update(Stock stock);
    }
}
