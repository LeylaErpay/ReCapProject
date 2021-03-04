using Core.Entities;
using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.Concrete.Concrete;
using System.Collections.Generic;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Users user, List<OperationClaim> operationClaims);
    }
}
