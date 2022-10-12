using SYS.Dal.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Conctrete
{
    public class EmployeesManager : IEmployeesDal
    {
        EfEmployessDal _employees = new EfEmployessDal();
        public void Add(Employees employees)
        {
            _employees.Add(employees);
        }

        public void Delete(Employees employees)
        {
            _employees.Delete(employees);
        }

        public List<Employees> GetAll()
        {
            return _employees.GetAll();
        }

        public Employees GetById(int id)
        {
            return _employees.GetById(id);
        }

        public void Update(Employees employees)
        {
            _employees.Update(employees);
        }
    }
}
