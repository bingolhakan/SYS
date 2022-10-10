using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IStocksDal
    {
        List<Stocks> GetAll();
        Stocks GetById(int id);
        void Add(Stocks stocks);
        void Delete(Stocks stocks);
        void Update(Stocks stocks);
    }
}
