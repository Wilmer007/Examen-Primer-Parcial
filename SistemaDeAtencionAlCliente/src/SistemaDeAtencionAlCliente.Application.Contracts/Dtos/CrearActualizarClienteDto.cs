using System.ComponentModel.DataAnnotations;

namespace SistemaDeAtencionAlCliente.Dtos;

public class CrearActualizarClienteDto
{
    [Required]
    public string Nombre { get; set; }
    
    [Required]
    [EmailAddress]
    public string Correo { get; set; }
    
    public string Telefono { get; set; }
}