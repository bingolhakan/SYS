using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Staffs : IEntity
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public Countries CountryID { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public Users Users { get; set; }
        public bool IsDelete { get; set; }
    }
}
