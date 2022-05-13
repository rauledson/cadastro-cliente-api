using System;
namespace cadastroClientes.Application
{
    public class ApplicationException : Exception
    {
        internal ApplicationException(string businessMessage) : base(businessMessage)
        {
        }
    }
}
