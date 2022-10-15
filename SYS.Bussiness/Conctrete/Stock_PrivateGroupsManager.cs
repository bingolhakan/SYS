using SYS.Bussiness.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Conctrete
{
    public class Stock_PrivateGroupsManager : IStock_PrivateGroupsService
    {
        EfStock_PrivateGroupsDal _stock_privategroups = new EfStock_PrivateGroupsDal();
        public void Add(Stock_PrivateGroups stock_privategroups)
        {
            _stock_privategroups.Add(stock_privategroups);
        }

        public void Delete(Stock_PrivateGroups stock_privategroups)
        {
            _stock_privategroups.Delete(stock_privategroups);
        }

        public List<Stock_PrivateGroups> GetAll()
        {
            return _stock_privategroups.GetAll();
        }

        public Stock_PrivateGroups GetById(int id)
        {
           return _stock_privategroups.GetById(id);
        }

        public void Update(Stock_PrivateGroups stock_privategroups)
        {
            _stock_privategroups.Update(stock_privategroups);
        }
    }
}
