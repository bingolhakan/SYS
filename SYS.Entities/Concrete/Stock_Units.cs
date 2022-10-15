using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Stock_Units : IEntity
    {
        public int UnitID { get; set; }
        public string UnitDescription { get; set; }
        public bool IsDelete { get; set; }

        public IEnumerable<Stocks> stocks { get; set; }
    }
}
