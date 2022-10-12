using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface ICountriesSERVICE
    {
        List<Countries> GetAll();
        Countries GetById(int id);
        void Add(Countries countries);
        void Update(Countries countries);
        void Delete(Countries countries);
    }
}
