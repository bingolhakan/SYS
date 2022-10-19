using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IStock_UnitService
    {
        List<Stock_Unit> GetAll();
        Stock_Unit GetById(int id);
        void Add(Stock_Unit stock_unit);
        void update (Stock_Unit stock_unit);
        void delete (Stock_Unit stock_unit);
    }
}
