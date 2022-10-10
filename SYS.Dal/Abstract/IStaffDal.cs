using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IStaffDal
    {
        List<Staffs> GetAll();
        Staffs GetById(int id);
        void Add(Staffs staffs);
        void Delete(Staffs staffs);
        void Update(Staffs staffs);
    }
}
