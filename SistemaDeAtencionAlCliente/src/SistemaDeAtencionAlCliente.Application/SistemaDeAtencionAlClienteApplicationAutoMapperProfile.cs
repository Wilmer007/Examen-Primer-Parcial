using AutoMapper;
using SistemaDeAtencionAlCliente.Books;

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
    }
}
