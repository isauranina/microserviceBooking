using AutoMapper;
using Moq;
using Eventos.Core.Mappings;
using Eventos.Core.Services.Transacciones;
using Xunit;

namespace Eventos.Tests.Services;

public class TransaccionServiceTests
{
    private readonly TransaccionService _transaccionService;

    public TransaccionServiceTests()
    {
        // AutoMapper real para tests
        var mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<EventosMappingProfile>());
        var mapper = mapperConfig.CreateMapper();

        _transaccionService = new TransaccionService(mapper);
    }

    // TODO: Los tests necesitan ser reescritos cuando se implemente la conexión a Postgres
    // Los métodos del servicio ahora lanzan NotImplementedException
}

