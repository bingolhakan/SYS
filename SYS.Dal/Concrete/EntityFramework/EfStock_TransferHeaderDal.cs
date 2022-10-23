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
    public class EfStock_TransferHeaderDal : IStock_TransferHeaderDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Stock_TransferHeader stock_transferheader)
        {
            _context.Stock_TransferHeaders.Add(stock_transferheader);
            _context.SaveChanges();
        }

        public void Delete(Stock_TransferHeader stock_transferheader)
        {
            _context.Stock_TransferHeaders.Remove(stock_transferheader);
            _context.SaveChanges();
        }

        public List<Stock_TransferHeader> GetAll()
        {
            return _context.Stock_TransferHeaders.ToList();
        }

        public Stock_TransferHeader GetById(int id)
        {
            return _context.Stock_TransferHeaders.Find(id);
        }

        public void Update(Stock_TransferHeader stock_transferheader)
        {
            _context.Stock_TransferHeaders.Update(stock_transferheader);
            _context.SaveChanges();
        }
    }
}
