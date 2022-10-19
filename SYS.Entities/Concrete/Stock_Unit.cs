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
    public class Stock_Unit : IEntity
    {
        [Key]
        [Required]
        public int Stock_UnitID { get; set; }
        public string UnitDescription { get; set; }
        public bool IsDelete { get; set; }

        public IEnumerable<Stock> Stocks { get; set; }
    }
}
