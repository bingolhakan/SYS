using SYS.Bussiness.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Concrete
{
    public class UserManager : IUserService
    {
        EfUserDal _usersDal = new EfUserDal();
        public void Add(Users users)
        {
            _usersDal.Add(users);
        }

        public void Delete(Users users)
        {
            _usersDal.Delete(users);
        }

        public List<Users> GetAll()
        {
            return _usersDal.GetAll();
        }

        public Users GetByID(int id)
        {
            return _usersDal.GetById(id);
        }

        public void Update(Users users)
        {
            _usersDal.Update(users);
        }
    }
}
