using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace SistemaDeAtencionAlCliente.Entities;

public class Cliente : AuditedAggregateRoot<Guid>
{
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string Telefono { get; set; }

    public ICollection<Caso> Casos { get; set; }
    
}