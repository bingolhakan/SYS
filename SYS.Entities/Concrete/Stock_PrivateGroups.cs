using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Stock_PrivateGroups : IEntity
    {
        public int GroupID { get; set; }
        public string GroupDescription { get; set; }
        public bool IsDelete { get; set; }
    }
}
