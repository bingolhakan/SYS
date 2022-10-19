using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface ICurrencyDal
    {
        List<Currency> GetAll();
        Currency GetById(int id);
        void Add(Currency currency);
        void Delete(Currency currency);
        void Update(Currency currency);
    }
}
