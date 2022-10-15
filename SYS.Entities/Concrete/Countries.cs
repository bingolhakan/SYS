using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Countries : IEntity
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public bool IsDelete { get; set; }

        public IEnumerable<Employees> employees { get; set; }
    }
}
