using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfFirm_PriavteGroups : IFirm_PrivateGroupsDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Firm_PrivateGroups firm_privategroups)
        {
            _context.firm_privategroups.Add(firm_privategroups);
            _context.SaveChanges();
        }

        public void Delete(Firm_PrivateGroups firm_privategroups)
        {
            _context.firm_privategroups.Remove(firm_privategroups);
        }

        public List<Firm_PrivateGroups> GetAll()
        {
            return _context.firm_privategroups.ToList();
        }

        public Firm_PrivateGroups GetById(int id)
        {
           return _context.firm_privategroups.Find(id);
        }

        public void Update(Firm_PrivateGroups firm_privategroups)
        {
            _context.firm_privategroups.Update(firm_privategroups);
        }
    }
}
