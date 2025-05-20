using SistemaDeAtencionAlCliente.Samples;
using Xunit;

namespace SistemaDeAtencionAlCliente.EntityFrameworkCore.Applications;

[Collection(SistemaDeAtencionAlClienteTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SistemaDeAtencionAlClienteEntityFrameworkCoreTestModule>
{

}
