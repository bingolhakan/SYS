using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfCountriesDal : ICountriesDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Countries countries)
        {
            _context.countries.Add(countries);
            _context.SaveChanges();
        }

        public List<Countries> GetAll()
        {
            return _context.countries.ToList();
        }

        public Countries GetById(int id)
        {
            return _context.countries.Find(id);
        }

        public void Delete(Countries countries)
        {
            _context.countries.Remove(countries);
            _context.SaveChanges();
        }

        public void Update(Countries countries)
        {
            _context.countries.Update(countries);
            _context.SaveChanges();
        }
    }
}
