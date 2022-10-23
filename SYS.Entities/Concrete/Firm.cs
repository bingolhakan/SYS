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
    public class Firm : IEntity
    {
        [Key]
        [Required]
        public int FirmID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public bool Isdelete { get; set; }

        public Country country { get; set; }
        public int CountryID { get; set; }
        public Firm_Type firm_type { get; set; }
        public int Firm_TypeID { get; set; }

        public IEnumerable<SaleOrder> Saleorders { get; set; }
        public IEnumerable<PurchaseOrder> Purchaseorders { get; set; }
        public IEnumerable<Stock_TransferHeader> Stock_TransferHeaders { get; set; }
    }
}
