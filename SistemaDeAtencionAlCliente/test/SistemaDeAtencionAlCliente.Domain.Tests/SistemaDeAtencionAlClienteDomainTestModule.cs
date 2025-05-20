using Volo.Abp.Modularity;

namespace SistemaDeAtencionAlCliente;

[DependsOn(
    typeof(SistemaDeAtencionAlClienteDomainModule),
    typeof(SistemaDeAtencionAlClienteTestBaseModule)
)]
public class SistemaDeAtencionAlClienteDomainTestModule : AbpModule
{

}
