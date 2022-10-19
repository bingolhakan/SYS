using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfStock_UnitDal : IStock_UnitDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Stock_Unit stock_unit)
        {
            _context.Stock_Units.Add(stock_unit);
            _context.SaveChanges();
        }

        public void Delete(Stock_Unit stock_unit)
        {
            _context.Stock_Units.Remove(stock_unit);
        }

        public List<Stock_Unit> GetAll()
        {
            return _context.Stock_Units.ToList();
        }

        public Stock_Unit GetById(int id)
        {
            return _context.Stock_Units.Find(id);
        }

        public void Update(Stock_Unit stock_unit)
        {
            _context.Stock_Units.Update(stock_unit);
            _context.SaveChanges();
        }
    }
}
