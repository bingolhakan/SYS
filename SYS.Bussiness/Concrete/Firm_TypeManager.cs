using SYS.Bussiness.Abstract;
using SYS.Dal.Conctrete.EntityFramework;
using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Concrete
{
    public class Firm_TypeManager : IFirm_TypeService
    {
        EfFirm_TypeDal _firm_typesDal = new EfFirm_TypeDal();

        public void Add(Firm_Type firm_types)
        {
            _firm_typesDal.Add(firm_types);
        }

        public void Delete(Firm_Type firm_types)
        {
            _firm_typesDal.Delete(firm_types);
        }

        public List<Firm_Type> GetAll()
        {
            return _firm_typesDal.GetAll();
        }

        public Firm_Type GetById(int İd)
        {
            return _firm_typesDal.GetById(İd);
        }

        public void Update(Firm_Type firm_types)
        {
            _firm_typesDal.Update(firm_types);
        }
    }
}
