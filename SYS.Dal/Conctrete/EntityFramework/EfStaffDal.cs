using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfStaffDal : IStaffDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Staffs staffs)
        {
            _context.staffs.Add(staffs);
            _context.SaveChanges();
        }

        public void Delete(Staffs staffs)
        {
            _context.staffs.Remove(staffs);
            _context.SaveChanges();
        }

        public List<Staffs> GetAll()
        {
            return _context.staffs.ToList();
        }

        public Staffs GetById(int id)
        {
            return _context.staffs.Find(id);
        }

        public void Update(Staffs staffs)
        {
            _context.staffs.Update(staffs);
            _context.SaveChanges();
        }
    }
}
