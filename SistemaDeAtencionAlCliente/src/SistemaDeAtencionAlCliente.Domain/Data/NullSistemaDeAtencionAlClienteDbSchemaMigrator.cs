using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SistemaDeAtencionAlCliente.Data;

/* This is used if database provider does't define
 * ISistemaDeAtencionAlClienteDbSchemaMigrator implementation.
 */
public class NullSistemaDeAtencionAlClienteDbSchemaMigrator : ISistemaDeAtencionAlClienteDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
