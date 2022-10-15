﻿using SYS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Bussiness.Abstract
{
    public interface ISaleOrdersService
    {
        List<SaleOrders> GetAll();
        SaleOrders GetById(int id);
        void Add(SaleOrders saleorders);
        void Update(SaleOrders saleorders);
        void Delete(SaleOrders saleorders);

    }
}