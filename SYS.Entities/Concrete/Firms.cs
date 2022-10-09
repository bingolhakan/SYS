using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Firms : IEntity
    {
        public int FirmID { get; set; }
        public Firm_Types Firm_TypeID { get; set; }
        public int Name { get; set; }
        public Firm_PrivateGroups Firm_PrivateGroupID { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public bool Isdelete { get; set; }

    }
}
