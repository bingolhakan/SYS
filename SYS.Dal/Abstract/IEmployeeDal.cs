using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IEmployeeDal
    {
        List<Employee> GetAll();
        Employee GetById(int id);
        void Add(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);
    }
}
