using AutoMapper;
using SistemaDeAtencionAlCliente.Books;
using SistemaDeAtencionAlCliente.Dtos;
using SistemaDeAtencionAlCliente.Entities;

namespace SistemaDeAtencionAlCliente;

public class SistemaDeAtencionAlClienteApplicationAutoMapperProfile : Profile
{
    public SistemaDeAtencionAlClienteApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        
        CreateMap<Cliente, ClienteDto>();
        CreateMap<CrearActualizarClienteDto, Cliente>();
        CreateMap<Caso, CasoDto>();
        CreateMap<CrearActualizarClienteDto, Caso>();
        CreateMap<Comentario, ComentarioDto>();

    }
}
