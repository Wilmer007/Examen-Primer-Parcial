using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaDeAtencionAlCliente.Dtos;
using SistemaDeAtencionAlCliente.Entities;
using SistemaDeAtencionAlCliente.SeviciosApplication;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SistemaDeAtencionAlCliente.Servicios;

public class ComentarioAppService : ApplicationService, IComentarioAppService
{
    private readonly IRepository<Comentario, Guid> _comentarioRepository;
    private readonly IRepository<Caso, Guid> _casoRepository;

    public ComentarioAppService(
        IRepository<Comentario, Guid> comentarioRepository,
        IRepository<Caso, Guid> casoRepository)
    {
        _comentarioRepository = comentarioRepository;
        _casoRepository = casoRepository;
    }

    public async Task<ComentarioDto> AgregarComentarioAsync(Guid casoId, CrearComentarioDto input)
    {
        var caso = await _casoRepository.GetAsync(casoId);
        var comentario = new Comentario
        {
            CasoId = casoId,
            Contenido = input.Contenido
        };
        await _comentarioRepository.InsertAsync(comentario, autoSave: true);
        return ObjectMapper.Map<Comentario, ComentarioDto>(comentario);
    }

    public async Task<List<ComentarioDto>> VerComentariosPorCasoAsync(Guid casoId)
    {
        var comentarios = await _comentarioRepository.GetListAsync(x => x.CasoId == casoId);
        return ObjectMapper.Map<List<Comentario>, List<ComentarioDto>>(comentarios);
    }
}