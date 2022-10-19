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
    public class Currency : IEntity
    {
        [Key]
        [Required]
        public int CurrencyID { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }

        public IEnumerable<Stock> Stocks { get; set; }
        public IEnumerable<SaleOrder> Salesorders { get; set; }
        public IEnumerable<PurchaseOrder> Purchaseorders { get; set; }
    }
}
