using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfFirm_TypesDal : IFirm_TypesDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Firm_Types firm_types)
        {
            _context.firm_types.Add(firm_types);
            _context.SaveChanges();
        }

        public void Delete(Firm_Types firm_types)
        {
            _context.firm_types.Remove(firm_types);
            _context.SaveChanges();
        }

        public List<Firm_Types> GetAll()
        {
            return _context.firm_types.ToList();
        }

        public Firm_Types GetById(int id)
        {
            return _context.firm_types.Find(id);
        }

        public void Update(Firm_Types firm_types)
        {
            _context.firm_types.Update(firm_types);
            _context.SaveChanges();
        }
    }
}
