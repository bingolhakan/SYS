using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfFirmsDal : IFirmsDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Firms firms)
        {
            _context.firms.Add(firms);
            _context.SaveChanges();
        }

        public void Delete(Firms firms)
        {
            _context.firms.Remove(firms);
            _context.SaveChanges();
        }

        public List<Firms> GetAll()
        {
            return _context.firms.ToList();
        }

        public Firms GetById(int id)
        {
            return _context.firms.Find(id);
        }

        public void Update(Firms firms)
        {
            _context.firms.Update(firms);
            _context.SaveChanges();
        }
    }
}
