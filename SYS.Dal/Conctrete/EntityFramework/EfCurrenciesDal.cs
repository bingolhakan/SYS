using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfCurrenciesDal : ICurrenciesDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Currencies currencies)
        {
            _context.currencies.Add(currencies);
            _context.SaveChanges();
        }

        public void Delete(Currencies currencies)
        {
            _context.currencies.Remove(currencies);
            _context.SaveChanges();
        }

        public List<Currencies> GetAll()
        {
            throw new NotImplementedException();
        }

        public Currencies GetById(int id)
        {
            return _context.currencies.Find(id);
        }

        public void Update(Currencies currencies)
        {
            _context.currencies.Update(currencies);
            _context.SaveChanges();
        }
    }
}
