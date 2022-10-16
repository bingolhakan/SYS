using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Employees : IEntity
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public bool IsDelete { get; set; }

        public Countries countries { get; set; }

        public IEnumerable<Users> users { get; set; }
        public IEnumerable<SaleOrders> saleOrders { get; set; }
        public IEnumerable<PurchaseOrders> purchaseorders { get; set; }
    }
}
