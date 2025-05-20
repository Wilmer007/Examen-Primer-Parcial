using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaDeAtencionAlCliente.Dtos;
using SistemaDeAtencionAlCliente.Entities;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SistemaDeAtencionAlCliente.SeviciosApplication;

public interface ICasoAppService : IApplicationService
{
    Task<CasoDto> CreateAsync(CrearActualizarClienteDto input);
    Task<CasoDto> GetAsync(Guid id);
    Task<List<CasoDto>> GetListAsync(); 
    Task<List<CasoDto>> GetByClienteIdAsync(Guid clienteId); 
    Task<List<CasoDto>> GetFilteredAsync(CasoTipo? tipo, CasoEstado? estado); 
    Task<CasoDto> UpdateAsync(Guid id, CrearActualizarClienteDto input);
    Task DeleteAsync(Guid id);

    Task CambiarEstadoAsync(Guid id, CasoEstado nuevoEstado);
}
