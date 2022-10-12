using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface ICurrenciesService
    {
        List<Currencies> GetAll();
        Currencies GetById(int id);
        void add(Currencies currencies);
        void update(Currencies currencies);
        void delete(Currencies currencies);

    }
}
