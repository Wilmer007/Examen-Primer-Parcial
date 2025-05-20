using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace SistemaDeAtencionAlCliente.Entities;

public enum CasoTipo { Queja, Sugerencia, Solicitud }
public enum CasoEstado { Abierto, EnProceso, Cerrado }

public class Caso : AuditedAggregateRoot<Guid>
{
    public Guid ClienteId { get; set; }
    public CasoTipo Tipo { get; set; }
    public CasoEstado Estado { get; set; }
    public string Descripcion { get; set; }

    public Cliente Cliente { get; set; }
    public ICollection<Comentario> Comentarios { get; set; }
    
}