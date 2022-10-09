using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class PurchaseOrder_PrivateGroups : IEntity
    {
        public int PurchaseOrder_PrivateGroupsID { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }
    }
}
