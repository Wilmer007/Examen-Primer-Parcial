using SistemaDeAtencionAlCliente.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SistemaDeAtencionAlCliente.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SistemaDeAtencionAlClienteEntityFrameworkCoreModule),
    typeof(SistemaDeAtencionAlClienteApplicationContractsModule)
)]
public class SistemaDeAtencionAlClienteDbMigratorModule : AbpModule
{
}
