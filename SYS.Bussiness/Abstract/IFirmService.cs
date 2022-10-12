using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IFirmService
    {
        List<Firms> GetAll();
        Firms GetById(int id);
        void Add(Firms firms);
        void Update(Firms firms);
        void Delete(Firms firms);
    }
}
