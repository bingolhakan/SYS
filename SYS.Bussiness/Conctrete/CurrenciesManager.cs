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
    public class CurrenciesManager : ICurrenciesService
    {
        EfCurrenciesDal _currenciesDal = new EfCurrenciesDal();
        public void add(Currencies currencies)
        {
            _currenciesDal.Add(currencies);
        }

        public void delete(Currencies currencies)
        {
            _currenciesDal.Delete(currencies);
        }

        public List<Currencies> GetAll()
        {
            return _currenciesDal.GetAll();
        }

        public Currencies GetById(int id)
        {
            return _currenciesDal.GetById(id);
        }

        public void update(Currencies currencies)
        {
            _currenciesDal.Update(currencies);
        }
    }
}
