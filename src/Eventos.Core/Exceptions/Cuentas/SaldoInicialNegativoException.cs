using System.Net;
using Application.Exceptions;

namespace Eventos.Core.Exceptions.Cuentas;

public class SaldoInicialNegativoException : CustomException
{
    public SaldoInicialNegativoException() 
        : base("El saldo inicial no puede ser negativo. Debe ser mayor o igual a cero.", HttpStatusCode.BadRequest)
    {
    }
}




