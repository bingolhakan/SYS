using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IStockService
    {
        List<Stock> GetAll();
        Stock GetByID(int id); 
        void Add(Stock stock);
        void Update(Stock stock);
        void Delete(Stock stock);

    }
}
