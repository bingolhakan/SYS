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
    public class FirmManager : IFirmService
    {
        EfFirmDal _firmsDal = new EfFirmDal(); 
        public void Add(Firm firms)
        {
            _firmsDal.Add(firms);
        }

        public void Delete(Firm firms)
        {
            _firmsDal.Delete(firms);
        }

        public List<Firm> GetAll()
        {
            return _firmsDal.GetAll();
        }

        public Firm GetById(int id)
        {
            return _firmsDal.GetById(id);
        }

        public void Update(Firm firms)
        {
            _firmsDal.Update(firms);
        }
    }
}
