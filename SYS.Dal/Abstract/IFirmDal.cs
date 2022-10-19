using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IFirmDal
    {
        List<Firm> GetAll();
        Firm GetById(int id);
        void Add(Firm firm);
        void Delete(Firm firm);
        void Update(Firm firm);
    }
}
