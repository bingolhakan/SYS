using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IEmployeesService
    {
        List<Employees> GetAll();
        Employees GetById(int id);
        void Add(Employees employee);
        void Update(Employees employee);
        void Delete(Employees employee);

    }
}
