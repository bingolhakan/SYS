using SYS.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Entities.Concrete
{
    public class Stock_TransferHeader : IEntity
    {
        [Key]
        [Required]
        public int TransferHeaderID { get; set; }
        public DateTime Date { get; set; }
        public string Transfer_Type { get; set; }
        public bool IsDelete { get; set; }

        public Firm firms { get; set; }
        public int FirmID { get; set; }
    }
}
