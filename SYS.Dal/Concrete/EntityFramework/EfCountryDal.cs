using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfCountryDal : ICountryDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
        }

        public List<Country> GetAll()
        {
            return _context.Countries.Where(x=>x.IsDelete!=true).ToList();
        }

        public Country GetById(int id)
        {
            return _context.Countries.Find(id);
        }

        public void Delete(Country country)
        {
            _context.Countries.Update(country);
            _context.SaveChanges();
        }

        public void Update(Country country)
        {
            _context.Countries.Update(country);
            _context.SaveChanges();
        }
    }
}
