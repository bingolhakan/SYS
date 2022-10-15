using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IStock_UnitsService
    {
        List<Stock_Units> GetAll();
        Stock_Units GetById(int id);
        void Add(Stock_Units stock_unit);
        void update (Stock_Units stock_unit);
        void delete (Stock_Units stock_unit);
    }
}
