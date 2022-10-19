using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public List<Users> GetAll()
        {
            return _context.Users.Where(x=>x.IsDelete!=true).ToList();
        }

        public Users GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public void Delete(Users user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Update(Users user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
