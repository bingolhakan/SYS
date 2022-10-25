using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Stock_TransferBody : IEntity
    {
        [Key]
        [Required]
        public int TransferBodyID { get; set; }
        public float Input { get; set; }
        public float Output { get; set; }
        public float UnitPrice { get; set; }
        public float DiscountRate { get; set; }
        public float DiscountAmount { get; set; }
        public float VatRate { get; set; }
        public float VatAmount { get; set; }
        public bool IsDelete { get; set; }

        public Stock_TransferHeader stock_transferheader { get; set; }
        public int TransferHeaderID { get; set; }
        public Stock stock { get; set; }
        public int StockID { get; set; }
        public PurchaseOrder purchaseorder { get; set; }
        public int PurchaseOrderID { get; set; }
        public SaleOrder saleorder { get; set; }
        public int SaleOrderID { get; set; }

        public IEnumerable<Stock_TransferHeader> stock_transferheaders { get; set; }

    }
}
