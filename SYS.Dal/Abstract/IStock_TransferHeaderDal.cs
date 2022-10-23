using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IStock_TransferHeaderDal
    {
        List<Stock_TransferHeader> GetAll();
        Stock_TransferHeader GetById(int id);
        void Add(Stock_TransferHeader stock_transferheader);
        void Delete(Stock_TransferHeader stock_transferheader);
        void Update(Stock_TransferHeader stock_transferheader);
    }
}
