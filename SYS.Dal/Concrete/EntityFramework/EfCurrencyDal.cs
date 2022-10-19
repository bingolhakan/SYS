using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfCurrencyDal : ICurrencyDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Currency currency)
        {
            _context.Currencies.Add(currency);
            _context.SaveChanges();
        }

        public void Delete(Currency currency)
        {
            _context.Currencies.Remove(currency);
            _context.SaveChanges();
        }

        public List<Currency> GetAll()
        {
            return _context.Currencies.ToList();
        }

        public Currency GetById(int id)
        {
            return _context.Currencies.Find(id);
        }

        public void Update(Currency currency)
        {
            _context.Currencies.Update(currency);
            _context.SaveChanges();
        }
    }
}
