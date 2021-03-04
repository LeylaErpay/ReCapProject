using Core.DataAccess;
using Core.Entities;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.Concrete.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<Users>
    {
        List<OperationClaim> GetClaims(Users user);
    }
}
