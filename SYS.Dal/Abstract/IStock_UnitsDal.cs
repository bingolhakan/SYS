using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IStock_UnitsDal
    {
        List<Stock_Units> GetAll();
        Stock_Units GetById(int id);
        void Add(Stock_Units stock_units);
        void Delete(Stock_Units stock_units);
        void Update(Stock_Units stocks_units);
    }
}
