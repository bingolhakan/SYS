using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface ICountryService
    {
        List<Country> GetAll();
        Country GetById(int id);
        void Add(Country country);
        void Update(Country country);
        void Delete(Country country);
    }
}
