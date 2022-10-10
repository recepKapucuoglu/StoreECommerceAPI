﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, StoreECommerceDbContext>,IOrderDal
    {
    }
}
