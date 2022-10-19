using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface IFirm_TypeService
    {
        List<Firm_Type> GetAll();
        Firm_Type GetById(int İd);
        void Add(Firm_Type firm_type);
        void Update(Firm_Type firm_type);
        void Delete(Firm_Type firm_type);

    }
}
