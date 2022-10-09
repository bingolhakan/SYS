using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface ICurrenciesDal
    {
        List<Currencies> GetAll();
        Currencies GetById(int id);
        void Add(Currencies currencies);
        void Delete(Countries countries);
        void Update(Currencies currencies);
    }
}
