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
    public class Firm_TypesManager : IFirm_TypesService
    {
        EfFirm_TypesDal _firm_typesdal = new EfFirm_TypesDal();

        public void Add(Firm_Types firm_types)
        {
            _firm_typesdal.Add(firm_types);
        }

        public void Delete(Firm_Types firm_types)
        {
            _firm_typesdal.Delete(firm_types);
        }

        public List<Firm_Types> GetAll()
        {
            return _firm_typesdal.GetAll();
        }

        public Firm_Types GetById(int İd)
        {
            return _firm_typesdal.GetById(İd);
        }

        public void Update(Firm_Types firm_types)
        {
            _firm_typesdal.Update(firm_types);
        }
    }
}
