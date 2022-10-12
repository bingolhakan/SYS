using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfEmployessDal : IEmployeesDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Employees staffs)
        {
            _context.staffs.Add(staffs);
            _context.SaveChanges();
        }

        public void Delete(Employees staffs)
        {
            _context.staffs.Remove(staffs);
            _context.SaveChanges();
        }

        public List<Employees> GetAll()
        {
            return _context.staffs.ToList();
        }

        public Employees GetById(int id)
        {
            return _context.staffs.Find(id);
        }

        public void Update(Employees staffs)
        {
            _context.staffs.Update(staffs);
            _context.SaveChanges();
        }
    }
}
