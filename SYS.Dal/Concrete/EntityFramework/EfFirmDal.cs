using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfFirmDal : IFirmDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Firm firm)
        {
            _context.Firms.Add(firm);
            _context.SaveChanges();
        }

        public void Delete(Firm firm)
        {
            _context.Firms.Remove(firm);
            _context.SaveChanges();
        }

        public List<Firm> GetAll()
        {
            return _context.Firms.Where(x=>x.Isdelete!=true).ToList();
        }

        public Firm GetById(int id)
        {
            return _context.Firms.Find(id);
        }

        public void Update(Firm firm)
        {
            _context.Firms.Update(firm);
            _context.SaveChanges();
        }
    }
}
