using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class PurchaseOrders : IEntity
    {
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

        public Firms firms { get; set; }
        public int FirmID { get; set; }
        public Employees employees { get; set; }
        public int EmployeeID { get; set; }
        public Stocks stocks { get; set; }
        public int StockID { get; set; }
        public Currencies currencies { get; set; }
        public int CurrencyID { get; set; }

    }
}
