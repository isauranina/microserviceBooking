using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Eventos.Core.Interfaces.IServices.Transacciones;
using Eventos.Core.Services.Transacciones;

namespace Eventos.API.Ioc;

public static class IocEventos
{
    public static void AddEventosDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        // Registrar Servicios
        services.AddScoped<ICuentaService, CuentaService>();
        services.AddScoped<ITransaccionService, TransaccionService>();
    }
}


