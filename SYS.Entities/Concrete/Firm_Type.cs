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
    public class Firm_Type : IEntity
    {
        [Key]
        [Required]
        public int Firm_TypeID { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }

        public IEnumerable<Firm> Firms { get; set; }
    }
}
