using System.Net;
using Application.Exceptions;

namespace Eventos.Core.Exceptions.Cuentas;

public class NumeroCuentaDuplicadoException : CustomException
{
    public NumeroCuentaDuplicadoException(string numeroCuenta) 
        : base($"Ya existe una cuenta con el número {numeroCuenta}", HttpStatusCode.Conflict)
    {
    }
}

