using SYS.Bussiness.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Conctrete
{
    public class Firm_PrivateGroupsManager : IFirm_PrivateGroupsService
    {
        EfFirm_PrivateGroups _firm_privategroups=new EfFirm_PrivateGroups();
        public void Add(Firm_PrivateGroups firm_privategroups)
        {
            _firm_privategroups.Add(firm_privategroups);
        }

        public void Delete(Firm_PrivateGroups firm_privategroups)
        {
            _firm_privategroups.Delete(firm_privategroups);
        }

        public List<Firm_PrivateGroups> GetAll()
        {
            return _firm_privategroups.GetAll();
        }

        public Firm_PrivateGroups GetById(int id)
        {
            return _firm_privategroups.GetById(id);
        }

        public void Update(Firm_PrivateGroups firm_privategroups)
        {
            _firm_privategroups.Update(firm_privategroups);
        }
    }
}
