using System;
using SistemaDeAtencionAlCliente.Entities;
using Volo.Abp.Application.Dtos;

namespace SistemaDeAtencionAlCliente.Dtos;

public class CasoDto : EntityDto<Guid>
{
    public Guid ClienteId { get; set; }
    public string Descripcion { get; set; }
    public CasoTipo Tipo { get; set; }
    public CasoEstado Estado { get; set; }

}