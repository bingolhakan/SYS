using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfStock_PrivateGroupsDal : IStock_PrivateGroupsDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Stock_PrivateGroups stock_privategroups)
        {
            _context.stock_privategroups.Add(stock_privategroups);
            _context.SaveChanges();
        }

        public void Delete(Stock_PrivateGroups stock_privategroups)
        {
            _context.stock_privategroups.Remove(stock_privategroups);
            _context.SaveChanges();
        }

        public List<Stock_PrivateGroups> GetAll()
        {
            return _context.stock_privategroups.ToList();
        }

        public Stock_PrivateGroups GetById(int id)
        {
            return _context.stock_privategroups.Find(id);
        }

        public void Update(Stock_PrivateGroups stock_privategroups)
        {
            _context.stock_privategroups.Update(stock_privategroups);
            _context.SaveChanges();
        }
    }
}
