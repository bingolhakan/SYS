using SYS.Dal.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Concrete
{
    public class EmployeeManager : IEmployeeDal
    {
        EfEmployesDal _employeesDal = new EfEmployesDal();
        public void Add(Employee employees)
        {
            _employeesDal.Add(employees);
        }

        public void Delete(Employee employees)
        {
            _employeesDal.Delete(employees);
        }

        public List<Employee> GetAll()
        {
            return _employeesDal.GetAll();
        }

        public Employee GetById(int id)
        {
            return _employeesDal.GetById(id);
        }

        public void Update(Employee employees)
        {
            _employeesDal.Update(employees);
        }
    }
}
