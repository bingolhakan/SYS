using SYS.Dal.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Concrete.EntityFramework
{
    public class EfStock_TransferBodyDal : IStock_TrasnferBodyDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Stock_TransferBody stock_transferbody)
        {
            _context.Stock_TransferBodies.Add(stock_transferbody);
            _context.SaveChanges();
        }

        public void Delete(Stock_TransferBody stock_transferbody)
        {
            _context.Stock_TransferBodies.Remove(stock_transferbody);
            _context.SaveChanges();
        }

        public List<Stock_TransferBody> GetAll()
        {
            return _context.Stock_TransferBodies.ToList();
        }

        public Stock_TransferBody GetById(int id)
        {
            return _context.Stock_TransferBodies.Find(id);
        }

        public void Update(Stock_TransferBody stock_transferbody)
        {
            _context.Stock_TransferBodies.Update(stock_transferbody);
            _context.SaveChanges();
        }
    }
}
