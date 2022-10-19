using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface ICurrencyService
    {
        List<Currency> GetAll();
        Currency GetById(int id);
        void add(Currency currency);
        void update(Currency currency);
        void delete(Currency currency);

    }
}
