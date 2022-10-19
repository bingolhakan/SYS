using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfEmployesDal : IEmployeeDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.Where(x=>x.IsDelete!=true).ToList();
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }
    }
}
