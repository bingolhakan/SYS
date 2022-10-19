using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IUserDal
    {
        List<Users> GetAll();
        Users GetById(int id);
        void Add(Users user);
        void Delete(Users user);
        void Update(Users user);
    }
}
