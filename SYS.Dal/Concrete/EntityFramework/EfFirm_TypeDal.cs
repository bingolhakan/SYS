using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfFirm_TypeDal : IFirm_TypeDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Firm_Type firm_type)
        {
            _context.Firm_types.Add(firm_type);
            _context.SaveChanges();
        }

        public void Delete(Firm_Type firm_type)
        {
            _context.Firm_types.Remove(firm_type);
            _context.SaveChanges();
        }

        public List<Firm_Type> GetAll()
        {
            return _context.Firm_types.ToList();
        }

        public Firm_Type GetById(int id)
        {
            return _context.Firm_types.Find(id);
        }

        public void Update(Firm_Type firm_type)
        {
            _context.Firm_types.Update(firm_type);
            _context.SaveChanges();
        }
    }
}
