using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaDeAtencionAlCliente.Data;
using Volo.Abp.DependencyInjection;

namespace SistemaDeAtencionAlCliente.EntityFrameworkCore;

public class EntityFrameworkCoreSistemaDeAtencionAlClienteDbSchemaMigrator
    : ISistemaDeAtencionAlClienteDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSistemaDeAtencionAlClienteDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SistemaDeAtencionAlClienteDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SistemaDeAtencionAlClienteDbContext>()
            .Database
            .MigrateAsync();
    }
}
