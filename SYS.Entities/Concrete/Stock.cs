using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Stock : IEntity
    {
        [Key]
        [Required]
        public int StockID { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public double VatRate { get; set; }
        public double DiscountRate { get; set; }
        public bool IsDelete { get; set; }

        public Stock_Unit stock_unit { get; set; }
        public int Stock_UnitID { get; set; }
        public Currency currency { get; set; }
        public int CurrencyID { get; set; }

        public IEnumerable<SaleOrder> Saleorders { get; set; }
        public IEnumerable<PurchaseOrder> Purchaseorders { get; set; }
    }
}
