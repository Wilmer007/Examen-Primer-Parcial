using Volo.Abp.Modularity;

namespace SistemaDeAtencionAlCliente;

/* Inherit from this class for your domain layer tests. */
public abstract class SistemaDeAtencionAlClienteDomainTestBase<TStartupModule> : SistemaDeAtencionAlClienteTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
