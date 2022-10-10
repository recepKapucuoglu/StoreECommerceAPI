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
    public class EfUserDal : EfEntityRepositoryBase<User, StoreECommerceDbContext>,IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (StoreECommerceDbContext context = new())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}

