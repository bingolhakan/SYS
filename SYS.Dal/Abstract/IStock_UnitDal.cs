using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IStock_UnitDal
    {
        List<Stock_Unit> GetAll();
        Stock_Unit GetById(int id);
        void Add(Stock_Unit stock_unit);
        void Delete(Stock_Unit stock_unit);
        void Update(Stock_Unit stock_unit);
    }
}
