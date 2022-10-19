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
    public class Stock_UnitManager : IStock_UnitService
    {
        EfStock_UnitDal _stock_unitsDal=new EfStock_UnitDal();

        public void Add(Stock_Unit stock_unit)
        {
            _stock_unitsDal.Add(stock_unit);
        }

        public void delete(Stock_Unit stock_unit)
        {
            _stock_unitsDal.Delete(stock_unit);
        }

        public List<Stock_Unit> GetAll()
        {
            return _stock_unitsDal.GetAll();
        }

        public Stock_Unit GetById(int id)
        {
            return _stock_unitsDal.GetById(id);
        }

        public void update(Stock_Unit stock_unit)
        {
            _stock_unitsDal.Update(stock_unit);
        }
    }
}
