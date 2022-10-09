using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Firm_PrivateGroups : IEntity
    {
        public int Firm_PrivateGroupID { get; set; }
        public int Description { get; set; }
        public bool IsDelete { get; set; }
    }
}
