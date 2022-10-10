using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IFirmsDal
    {
        List<Firms> GetAll();
        Firms GetById(int id);
        void Add(Firms firms);
        void Delete(Firms firms);
        void Update(Firms firms);
    }
}
