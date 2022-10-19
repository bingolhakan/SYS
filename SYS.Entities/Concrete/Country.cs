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
    public class Country : IEntity
    {
        [Key]
        [Required]
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public bool IsDelete { get; set; }

        public IEnumerable<Employee> Employee { get; set; }
        public IEnumerable<Firm> Firm { get; set; }    
    }
}
