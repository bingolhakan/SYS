using SYS.Bussiness.Abstract;
using SYS.Dal.Concrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Concrete
{
    public class Stock_TransferHeaderManager : IStock_TransferHeaderService
    {
        EfStock_TransferHeaderDal _stock_transferheaderdal=new EfStock_TransferHeaderDal();
        public void Add(Stock_TransferHeader stock_transferheader)
        {
            _stock_transferheaderdal.Add(stock_transferheader);
        }

        public void Delete(Stock_TransferHeader stock_transferheader)
        {
            _stock_transferheaderdal.Delete(stock_transferheader);
        }

        public List<Stock_TransferHeader> GetAll()
        {
            return _stock_transferheaderdal.GetAll();
        }

        public Stock_TransferHeader GetById(int id)
        {
            return _stock_transferheaderdal.GetById(id);
        }

        public void Update(Stock_TransferHeader stock_transferheader)
        {
            _stock_transferheaderdal.Update(stock_transferheader);
        }
    }
}
