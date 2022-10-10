using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfStock_UnitsDal : IStock_UnitsDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Stock_Units stock_units)
        {
            _context.stock_units.Add(stock_units);
            _context.SaveChanges();
        }

        public void Delete(Stock_Units stock_units)
        {
            _context.stock_units.Remove(stock_units);
        }

        public List<Stock_Units> GetAll()
        {
            throw new NotImplementedException();
        }

        public Stock_Units GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Stock_Units stocks_units)
        {
            throw new NotImplementedException();
        }
    }
}
