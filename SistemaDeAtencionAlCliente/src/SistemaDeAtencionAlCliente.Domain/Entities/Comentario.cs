using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace SistemaDeAtencionAlCliente.Entities;

public class Comentario : AuditedEntity<Guid>
{
    public string Contenido { get; set; }
    public Guid CasoId { get; set; }
    
    public Caso Caso { get; set; }
}