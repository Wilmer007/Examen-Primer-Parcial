using Volo.Abp.Modularity;

namespace SistemaDeAtencionAlCliente;

[DependsOn(
    typeof(SistemaDeAtencionAlClienteApplicationModule),
    typeof(SistemaDeAtencionAlClienteDomainTestModule)
)]
public class SistemaDeAtencionAlClienteApplicationTestModule : AbpModule
{

}
