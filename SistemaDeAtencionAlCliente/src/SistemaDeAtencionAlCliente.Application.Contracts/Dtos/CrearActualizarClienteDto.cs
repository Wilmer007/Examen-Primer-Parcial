using System;
using SistemaDeAtencionAlCliente.Entities;

namespace SistemaDeAtencionAlCliente.Dtos;

public class CrearActualizarClienteDto
{
    public Guid ClIenteId { get; set; }
    public string Descripcion { get; set; }
    public CasoTipo Tipo { get; set; }
}