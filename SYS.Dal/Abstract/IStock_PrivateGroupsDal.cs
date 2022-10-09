using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IStock_PrivateGroupsDal
    {
        List<Stock_PrivateGroups> GetAll();
        Stock_PrivateGroups GetById(int id);
        void Add(Stock_PrivateGroups stock_privategroups);
        void Delete(int id);
        void Update(Stock_PrivateGroups stock_privategroups);
    }
}
