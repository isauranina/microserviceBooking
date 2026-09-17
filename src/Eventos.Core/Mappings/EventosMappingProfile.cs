using AutoMapper;
using Eventos.Core.DTOs.Transacciones;
using Eventos.Core.Entities;

namespace Eventos.Core.Mappings;

public class EventosMappingProfile : Profile
{
    public EventosMappingProfile()
    {
        // Mapeo Cuenta
        CreateMap<Cuenta, CuentaDto>();
        CreateMap<CuentaDto, Cuenta>()
            .ForMember(dest => dest.Transacciones, opt => opt.Ignore())
            .ForMember(dest => dest.RowVersion, opt => opt.Ignore());
        
        CreateMap<CrearCuentaDto, Cuenta>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Saldo, opt => opt.MapFrom(src => src.SaldoInicial))
            .ForMember(dest => dest.FechaCreacion, opt => opt.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.Activa, opt => opt.MapFrom(src => true))
            .ForMember(dest => dest.Transacciones, opt => opt.Ignore())
            .ForMember(dest => dest.RowVersion, opt => opt.Ignore());

        // Mapeo Transaccion
        CreateMap<Transaccion, TransaccionDto>();
        CreateMap<TransaccionDto, Transaccion>()
            .ForMember(dest => dest.Cuenta, opt => opt.Ignore());

        CreateMap<CrearTransaccionDto, Transaccion>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.FechaTransaccion, opt => opt.MapFrom(src => DateTime.UtcNow))
            .ForMember(dest => dest.SaldoAnterior, opt => opt.Ignore())
            .ForMember(dest => dest.SaldoNuevo, opt => opt.Ignore())
            .ForMember(dest => dest.Cuenta, opt => opt.Ignore());
    }
}

