using System.Net;
using Application.Exceptions;

namespace Eventos.Core.Exceptions.Transacciones;

public class CuentaNoEncontradaException : CustomException
{
    public CuentaNoEncontradaException(int cuentaId) 
        : base($"No se encontró la cuenta con ID {cuentaId}", HttpStatusCode.NotFound)
    {
    }
}

