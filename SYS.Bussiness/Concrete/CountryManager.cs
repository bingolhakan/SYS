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
    public class CountryManager : ICountryService
    {
        EfCountryDal _countriesDal = new EfCountryDal();
        public void Add(Country countries)
        {
            _countriesDal.Add(countries);
        }

        public void Delete(Country countries)
        {
            _countriesDal.Delete(countries);
        }

        public List<Country> GetAll()
        {
            return _countriesDal.GetAll();
        }

        public Country GetById(int id)
        {
            return _countriesDal.GetById(id);
        }

        public void Update(Country countries)
        {
            _countriesDal.Update(countries);
        }
    }
}
