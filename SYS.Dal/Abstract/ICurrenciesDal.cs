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
        void Remove(int id);
        void Update(Currencies currencies);
    }
}
