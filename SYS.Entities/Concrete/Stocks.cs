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
        public Stock_Units UnitID { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public Currencies CurrencyID { get; set; }
        public Stock_PrivateGroups GroupID { get; set; }
        public double VatRate { get; set; }
        public double DiscountRate { get; set; }
        public bool IsDelete { get; set; }
    }
}
