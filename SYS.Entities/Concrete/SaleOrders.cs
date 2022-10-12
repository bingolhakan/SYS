using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class SaleOrders : IEntity
    {
        public int SaleOrderID { get; set; }
        public Firms FirmID { get; set; }
        public DateTime OrderDate { get; set; }
        public SaleOrder_PrivateGroups SaleOrder_PrivateGroupsID { get; set; }
        public Employees StaffID { get; set; }
        public Stocks StockID { get; set; }
        public Stocks Name { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public Currencies CurrencyID { get; set; }
        public Stocks VatRate { get; set; }
        public Stocks DiscountRate { get; set; }
        public double SubTotal { get; set; }
        public DateOnly DeliveryDate { get; set; }
        public DateOnly RevisedDeliveryDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
