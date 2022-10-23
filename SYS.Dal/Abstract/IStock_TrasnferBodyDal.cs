using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IStock_TrasnferBodyDal
    {
        List<Stock_TransferBody> GetAll();
        Stock_TransferBody GetById(int id);
        void Add(Stock_TransferBody stock_transferbody);
        void Delete(Stock_TransferBody stock_transferbody);
        void Update(Stock_TransferBody stock_transferbody);


    }
}
