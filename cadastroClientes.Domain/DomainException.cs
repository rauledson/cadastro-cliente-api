using System;
namespace cadastroClientes.Domain
{
    public class DomainException : Exception
    {
        internal DomainException(string businessMessage) : base(businessMessage)
        {
        }
    }
}
