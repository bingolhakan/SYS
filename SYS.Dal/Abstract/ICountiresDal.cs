using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface ICountiresDal
    {
        List<ICountiresDal> GetAll();
        Countries GetById(int id);
        void Add(Countries countries);
        void Delete(Countries countries);
        void Update(Countries countries);

    }
}
