using AutoMapper;
using Eventos.Core.DTOs.Transacciones;
using Eventos.Core.Entities;
using Eventos.Core.Exceptions.Transacciones;
using Eventos.Core.Interfaces.IServices.Transacciones;

namespace Eventos.Core.Services.Transacciones;

public class TransaccionService : ITransaccionService
{
    private readonly IMapper _mapper;

    public TransaccionService(
        IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<TransaccionDto> ProcesarAbonoAsync(CrearAbonoDto crearAbonoDto)
    {
        // TODO: Implementar con conexión a Postgres
        throw new NotImplementedException("Este método necesita ser implementado con conexión a Postgres");
    }

    public async Task<TransaccionDto> ProcesarRetiroAsync(CrearRetiroDto crearRetiroDto)
    {
        // TODO: Implementar con conexión a Postgres
        throw new NotImplementedException("Este método necesita ser implementado con conexión a Postgres");
    }

    public async Task<TransaccionDto> ProcesarTransaccionAsync(CrearTransaccionDto crearTransaccionDto)
    {
        // TODO: Implementar con conexión a Postgres
        throw new NotImplementedException("Este método necesita ser implementado con conexión a Postgres");
    }

    public async Task<IEnumerable<TransaccionDto>> GetByCuentaIdAsync(int cuentaId)
    {
        // TODO: Implementar con conexión a Postgres
        throw new NotImplementedException("Este método necesita ser implementado con conexión a Postgres");
    }
}



