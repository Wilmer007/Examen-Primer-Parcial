using SistemaDeAtencionAlCliente.Samples;
using Xunit;

namespace SistemaDeAtencionAlCliente.EntityFrameworkCore.Domains;

[Collection(SistemaDeAtencionAlClienteTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SistemaDeAtencionAlClienteEntityFrameworkCoreTestModule>
{

}
