using System.Net;
using Application.Exceptions;

namespace Eventos.Core.Exceptions.Transacciones;

public class CuentaInactivaException : CustomException
{
    public CuentaInactivaException(string operacion) 
        : base($"La cuenta no está activa. No se puede realizar {operacion}.", HttpStatusCode.BadRequest)
    {
    }
}

