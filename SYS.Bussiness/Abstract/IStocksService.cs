using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IStocksService
    {
        List<Stocks> GetAll();
        Stocks GetByID(int id); 
        void Add(Stocks stocks);
        void Update(Stocks stocks);
        void Delete(Stocks stocks);

    }
}
