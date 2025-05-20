using System.Threading.Tasks;

namespace SistemaDeAtencionAlCliente.Data;

public interface ISistemaDeAtencionAlClienteDbSchemaMigrator
{
    Task MigrateAsync();
}
