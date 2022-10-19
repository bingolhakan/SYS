using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IUserService
    {
        List<Users> GetAll();
        Users GetByID(int id);
        void Add(Users user);
        void Update(Users user);
        void Delete(Users user);

    }
}
