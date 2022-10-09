﻿using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Dal.Abstract
{
    public interface IFirm_TypesDal
    {
        List<Firm_Types> GetAll();
        Firm_Types GetById(int id);
        void Add(Firm_Types firm_types);
        void Remove(int id);
        void Update(Firm_Types firm_types);
    }
}