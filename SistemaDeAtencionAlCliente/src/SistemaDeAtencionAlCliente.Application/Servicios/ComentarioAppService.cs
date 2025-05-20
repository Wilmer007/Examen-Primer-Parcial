using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaDeAtencionAlCliente.Dtos;

namespace SistemaDeAtencionAlCliente.Servicios;

public class ComentarioAppService
{
    public async Task CrearComentarioAsync(Guid casoId, CrearComentarioDto input) {}
    
    public async Task<List<ComentarioDto>> VerComentariosDeCasoAsync(Guid casoId) {}
}