using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IStock_TransferBodyService
    {
        List<Stock_TransferBody> GetAll();
        Stock_TransferBody GetById(int id);
        void Add(Stock_TransferBody stock_transferBody);
        void Update(Stock_TransferBody stock_transferBody);
        void Delete(Stock_TransferBody stock_transferBody);


    }
}
