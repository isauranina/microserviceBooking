using AutoMapper;
using Eventos.Core.DTOs.Transacciones;
using Eventos.Core.Entities;
using Eventos.Core.Exceptions.Cuentas;
using Eventos.Core.Exceptions.Transacciones;
using Eventos.Core.Interfaces.IServices.Transacciones;

namespace Eventos.Core.Services.Transacciones;

public class CuentaService : ICuentaService
{
    private readonly IMapper _mapper;

    public CuentaService(
        IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<CuentaDto?> GetByIdAsync(int id)
    {
        // TODO: Implementar con conexión a Postgres
        throw new NotImplementedException("Este método necesita ser implementado con conexión a Postgres");
    }

    public async Task<CuentaDto?> GetByNumeroCuentaAsync(string numeroCuenta)
    {
        // TODO: Implementar con conexión a Postgres
        throw new NotImplementedException("Este método necesita ser implementado con conexión a Postgres");
    }

    public async Task<CuentaDto> CreateAsync(CrearCuentaDto crearCuentaDto)
    {
        // TODO: Implementar con conexión a Postgres
        throw new NotImplementedException("Este método necesita ser implementado con conexión a Postgres");
    }
}





