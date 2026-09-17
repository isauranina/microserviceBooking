using System.Net;
using Application.Exceptions;

namespace Eventos.Core.Exceptions.Transacciones;

public class SaldoInsuficienteException : CustomException
{
    public SaldoInsuficienteException(decimal saldoDisponible, decimal montoSolicitado) 
        : base($"Saldo insuficiente. Saldo disponible: {saldoDisponible:C}, Monto solicitado: {montoSolicitado:C}", HttpStatusCode.BadRequest)
    {
    }
}




