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
    public class FirmsManager : IFirmsService
    {
        EfFirmsDal _firmsdal = new EfFirmsDal(); 
        public void Add(Firms firms)
        {
            _firmsdal.Add(firms);
        }

        public void Delete(Firms firms)
        {
            _firmsdal.Delete(firms);
        }

        public List<Firms> GetAll()
        {
            return _firmsdal.GetAll();
        }

        public Firms GetById(int id)
        {
            return _firmsdal.GetById(id);
        }

        public void Update(Firms firms)
        {
            _firmsdal.Update(firms);
        }
    }
}
