using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfUsersDal : IUsersDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Users users)
        {
            _context.users.Add(users);
            _context.SaveChanges();
        }

        public List<Users> GetAll()
        {
            return _context.users.ToList();
        }

        public Users GetById(int id)
        {
            return _context.users.Find(id);
        }

        public void Delete(Users users)
        {
            _context.users.Remove(users);
            _context.SaveChanges();
        }

        public void Update(Users users)
        {
            _context.users.Update(users);
            _context.SaveChanges();
        }
    }
}
