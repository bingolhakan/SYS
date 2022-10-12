using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IEmployeesDal
    {
        List<Employees> GetAll();
        Employees GetById(int id);
        void Add(Employees staffs);
        void Delete(Employees staffs);
        void Update(Employees staffs);
    }
}
