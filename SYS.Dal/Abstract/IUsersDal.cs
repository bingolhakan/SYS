using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IUsersDal
    {
        List<Users> GetAll();
        Users GetById(int id);
        void Add(Users users);
        void Delete(Users users);
        void Update(Users users);
    }
}
