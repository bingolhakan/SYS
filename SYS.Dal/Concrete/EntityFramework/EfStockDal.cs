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
    public class EfStockDal : IStockDal
    {
        AppDbContext _context = new AppDbContext();
        public void Add(Stock stock)
        {
            _context.Stocks.Add(stock);
            _context.SaveChanges();
        }

        public void Delete(Stock stock)
        {
            _context.Stocks.Remove(stock);
            _context.SaveChanges();
        }

        public List<Stock> GetAll()
        {
            return _context.Stocks.Where(x=>x.IsDelete!=true).ToList();
        }

        public Stock GetById(int id)
        {
            return _context.Stocks.Find(id);
        }

        public void Update(Stock stock)
        {
            _context.Stocks.Update(stock);
            _context.SaveChanges();
        }
    }
}
