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
    public class CurrencyManager : ICurrencyService
    {
        EfCurrencyDal _currenciesDal = new EfCurrencyDal();
        public void add(Currency currencies)
        {
            _currenciesDal.Add(currencies);
        }

        public void delete(Currency currencies)
        {
            _currenciesDal.Delete(currencies);
        }

        public List<Currency> GetAll()
        {
            return _currenciesDal.GetAll();
        }

        public Currency GetById(int id)
        {
            return _currenciesDal.GetById(id);
        }

        public void update(Currency currencies)
        {
            _currenciesDal.Update(currencies);
        }
    }
}
