using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaDeAtencionAlCliente.Dtos;
using SistemaDeAtencionAlCliente.Entities;

namespace SistemaDeAtencionAlCliente.Servicios;

public class CasoAppService
{
    public async Task<List<CasoDto>> GetCasosPorClienteAsync(Guid clienteId)
    {
        
    }

    public async Task CambiarEstadoDeCasoAsync(Guid casoId, CasoEstado nuevoEstado)
    {
        
    }

    public async Task<List<CasoDto>> FiltrarCasoAsync(CasoTipo? tipo, CasoEstado? estado)
    {
        
    }
    
}