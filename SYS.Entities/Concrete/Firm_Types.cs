using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Firm_Types : IEntity
    {
        public int Firm_TypeID { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }

        public IEnumerable<Firms> firms { get; set; }
    }
}
