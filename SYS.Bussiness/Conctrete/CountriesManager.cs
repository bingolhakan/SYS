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
    public class CountriesManager : ICountriesSERVICE
    {
        EfCountriesDal _countriesdal = new EfCountriesDal();
        public void Add(Countries countries)
        {
            _countriesdal.Add(countries);
        }

        public void Delete(Countries countries)
        {
            _countriesdal.Delete(countries);
        }

        public List<Countries> GetAll()
        {
            return _countriesdal.GetAll();
        }

        public Countries GetById(int id)
        {
            return _countriesdal.GetById(id);
        }

        public void Update(Countries countries)
        {
            _countriesdal.Update(countries);
        }
    }
}
