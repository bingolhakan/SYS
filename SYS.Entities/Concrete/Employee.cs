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
    public class Employee : IEntity
    {
        [Key]
        [Required]
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

        public Country country { get; set; }
        public int CountryID { get; set; }

        public IEnumerable<Users> Users { get; set; }
        public IEnumerable<SaleOrder> Saleorders { get; set; }
        public IEnumerable<PurchaseOrder> Purchaseorders { get; set; }
    }
}
