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
    public class PurchaseOrder : IEntity
    {
        [Key]
        [Required]
        public int PurchaseOrderID { get; set; }    
        public DateTime OrderDate { get; set; }
        public string Name { get; set; }
        public double VatRate { get; set; }
        public double DiscountRate { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double SubTotal { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime RevisedDeliveryDate { get; set; }
        public bool IsDelete { get; set; }

        public Firm firm { get; set; }
        public int FirmID { get; set; }
        public Employee employee { get; set; }
        public int EmployeeID { get; set; }
        public Stock stock { get; set; }
        public int StockID { get; set; }
        public Currency currency { get; set; }
        public int CurrencyID { get; set; }
        public IEnumerable<Stock_TransferBody> Stock_TransferBodys { get; set; }
    }
}
