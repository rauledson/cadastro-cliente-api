using System;
using System.Security.Principal;

namespace cadastroClientesAPI.Infrastructure.Services
{
    public interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
