using System;
using Volo.Abp.Application.Dtos;

namespace SistemaDeAtencionAlCliente.Dtos;

public class ComentarioDto : EntityDto<Guid>
{
    public Guid CasoId { get; set; }
    public string Contenido { get; set; }
    
}