using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Currencies : IEntity
    {
        public int CurrencyID { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }

        public IEnumerable<Stocks> stocks { get; set; }
        public IEnumerable<SaleOrders> salesOrders { get; set; }
        public IEnumerable<PurchaseOrders> purchaseOrders { get; set; }
    }
}
