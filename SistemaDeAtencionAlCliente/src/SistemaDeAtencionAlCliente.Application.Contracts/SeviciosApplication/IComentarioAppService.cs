using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaDeAtencionAlCliente.Dtos;
using Volo.Abp.Application.Services;

namespace SistemaDeAtencionAlCliente.SeviciosApplication;

public interface IComentarioAppService : IApplicationService
{
    Task<ComentarioDto> AgregarComentarioAsync(Guid casoId, CrearComentarioDto input);
    Task<List<ComentarioDto>> VerComentariosPorCasoAsync(Guid casoId);
}