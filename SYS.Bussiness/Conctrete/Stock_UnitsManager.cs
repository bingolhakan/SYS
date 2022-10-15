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
    public class Stock_UnitsManager : IStock_UnitsService
    {
        EfStock_UnitsDal _stock_unitsdal=new EfStock_UnitsDal();

        public void Add(Stock_Units stock_unit)
        {
            _stock_unitsdal.Add(stock_unit);
        }

        public void delete(Stock_Units stock_unit)
        {
            _stock_unitsdal.Delete(stock_unit);
        }

        public List<Stock_Units> GetAll()
        {
            return _stock_unitsdal.GetAll();
        }

        public Stock_Units GetById(int id)
        {
            return _stock_unitsdal.GetById(id);
        }

        public void update(Stock_Units stock_unit)
        {
            _stock_unitsdal.Update(stock_unit);
        }
    }
}
