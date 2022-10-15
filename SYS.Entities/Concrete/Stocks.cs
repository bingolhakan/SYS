using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Stocks : IEntity
    {
        public int StockID { get; set; }
        public string StockName { get; set; }
        public string StockName2 { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public double VatRate { get; set; }
        public double DiscountRate { get; set; }
        public bool IsDelete { get; set; }

        public Stock_Units stock_units { get; set; }
        public int UnitID { get; set; }
        public Currencies currencies { get; set; }
        public int CurrenyID { get; set; }

        public IEnumerable<SaleOrders> saleOrders { get; set; }
        public IEnumerable<PurchaseOrders> purchaseOrders { get; set; }
    }
}
