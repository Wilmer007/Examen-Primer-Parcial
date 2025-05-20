using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using SistemaDeAtencionAlCliente.Dtos;
using SistemaDeAtencionAlCliente.Entities;
using SistemaDeAtencionAlCliente.SeviciosApplication;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace SistemaDeAtencionAlCliente.Servicios;

public class CasoAppService : ApplicationService, ICasoAppService
{
    private readonly IRepository<Caso, Guid> _casoRepository;
    private readonly IRepository<Cliente, Guid> _clienteRepository;
    private readonly IObjectMapper _objectMapper;

    public CasoAppService(
        IRepository<Caso, Guid> casoRepository,
        IRepository<Cliente, Guid> clienteRepository,
        IObjectMapper objectMapper)
    {
        _casoRepository = casoRepository;
        _clienteRepository = clienteRepository;
        _objectMapper = objectMapper;
    }
    
    public async Task<CasoDto> CreateAsync(CrearActualizarClienteDto input)
    {
        var caso = ObjectMapper.Map<CrearActualizarClienteDto, Caso>(input);
        caso.Estado = CasoEstado.Abierto;
        await _casoRepository.InsertAsync(caso , autoSave: true);
        return ObjectMapper.Map<Caso, CasoDto>(caso);
    }
    
    public async Task<CasoDto> GetAsync(Guid id)
    {
        var caso = await _casoRepository.GetAsync(id);
        var casoDto = ObjectMapper.Map<Caso, CasoDto>(caso);
        var clienteDto = await _clienteRepository.GetAsync(caso.ClienteId);
        return casoDto;
    }

    public async Task<List<CasoDto>> GetListAsync()
    {
        var casos = await _casoRepository.GetListAsync(includeDetails: true);
        var dtos = ObjectMapper.Map<List<Caso>, List<CasoDto>>(casos);
        foreach (var dto in dtos)
        {
            var clienteDto = await _clienteRepository.GetAsync(dto.ClienteId);
        }

        return dtos;
    }

    public async Task<List<CasoDto>> GetByClienteIdAsync(Guid clienteId)
        {
            var casos = await _casoRepository.GetListAsync(x => x.ClienteId == clienteId, includeDetails: true);
            return ObjectMapper.Map<List<Caso>, List<CasoDto>>(casos);
        }
    public async Task<List<CasoDto>> GetFilteredAsync(CasoTipo? tipo, CasoEstado? estado)
    {

        var query = await _casoRepository.GetQueryableAsync();
        if (tipo.HasValue)
            query = query.Where(x => x.Tipo == tipo.Value);
        if (estado.HasValue)
            query = query.Where(x => x.Estado == estado.Value);
        var casos = query.ToList();
        return ObjectMapper.Map<List<Caso>, List<CasoDto>>(casos);
    }
    public async Task<CasoDto> UpdateAsync(Guid id, CrearActualizarClienteDto input)
    {
        var caso = await _casoRepository.GetAsync(id);
        ObjectMapper.Map(input, caso);
        await _casoRepository.UpdateAsync(caso, autoSave: true);
        return ObjectMapper.Map<Caso, CasoDto>(caso);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _casoRepository.DeleteAsync(id);
    }

    public async Task CambiarEstadoAsync(Guid id, CasoEstado nuevoEstado)
    {
        var caso = await _casoRepository.GetAsync(id);
        caso.Estado = nuevoEstado;
        await _casoRepository.UpdateAsync(caso, autoSave: true);
    }

    
}