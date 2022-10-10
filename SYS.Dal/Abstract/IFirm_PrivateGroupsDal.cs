using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IFirm_PrivateGroupsDal
    {
        List<Firm_PrivateGroups> GetAll();
        Firm_PrivateGroups GetById(int id);
        void Add(Firm_PrivateGroups firm_privategroups);
        void Delete(Firm_PrivateGroups firm_privategroups);
        void Update(Firm_PrivateGroups firm_privategroups);
    }
}
