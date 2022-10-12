using SYS.Bussiness.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Conctrete
{
    public class UsersManager : IUsersService
    {
        EfUsersDal _usersdal = new EfUsersDal();
        public void Add(Users users)
        {
            _usersdal.Add(users);
        }

        public void Delete(Users users)
        {
            _usersdal.Delete(users);
        }

        public List<Users> GetAll()
        {
            return _usersdal.GetAll();
        }

        public Users GetByID(int id)
        {
            return _usersdal.GetById(id);
        }

        public void Update(Users users)
        {
            _usersdal.Update(users);
        }
    }
}
