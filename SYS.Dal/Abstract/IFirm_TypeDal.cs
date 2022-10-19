using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IFirm_TypeDal
    {
        List<Firm_Type> GetAll();
        Firm_Type GetById(int id);
        void Add(Firm_Type firm_type);
        void Delete(Firm_Type firm_type);
        void Update(Firm_Type firm_type);
    }
}
