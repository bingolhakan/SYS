using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IUsersService
    {
        List<Users> GetAll();
        Users GetByID(int id);
        void Add(Users users);
        void Update(Users users);
        void Delete(Users users);

    }
}
