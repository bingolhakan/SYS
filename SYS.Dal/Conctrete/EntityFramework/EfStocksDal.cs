using Microsoft.EntityFrameworkCore;
using SYS.Dal.Abstract;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Conctrete.EntityFramework
{
    public class EfStocksDal : IStocksDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Stocks stocks)
        {
            _context.stocks.Add(stocks);
            _context.SaveChanges();
        }

        public void Delete(Stocks stocks)
        {
            _context.stocks.Remove(stocks);
            _context.SaveChanges();
        }

        public List<Stocks> GetAll()
        {
            return _context.stocks.ToList();
        }

        public Stocks GetById(int id)
        {
            return _context.stocks.Find(id);
        }

        public void Update(Stocks stocks)
        {
            _context.stocks.Update(stocks);
            _context.SaveChanges();
        }
    }
}
