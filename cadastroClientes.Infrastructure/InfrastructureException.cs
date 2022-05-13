using System;

namespace cadastroClientes.Infrastructure
{
    public class InfrastructureException : Exception
    {
        internal InfrastructureException(string businessMessage) : base(businessMessage)
        {
        }
    }
}
