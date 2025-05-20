using System;
using SistemaDeAtencionAlCliente.Dtos;
using SistemaDeAtencionAlCliente.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SistemaDeAtencionAlCliente.Servicios;

public class ClienteAppService : CrudAppService<
Cliente, 
ClienteDto, 
Guid, 
PagedAndSortedResultRequestDto, 
CrearActualizarClienteDto,
CrearActualizarClienteDto>,
IClienteAppService
{
    public ClienteAppService(IRepository<Cliente, Guid> repository) : base(repository)
    {
        
    }
    
}