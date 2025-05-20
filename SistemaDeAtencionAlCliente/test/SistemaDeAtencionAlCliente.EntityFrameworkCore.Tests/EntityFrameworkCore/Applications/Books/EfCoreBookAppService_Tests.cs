using SistemaDeAtencionAlCliente.Books;
using Xunit;

namespace SistemaDeAtencionAlCliente.EntityFrameworkCore.Applications.Books;

[Collection(SistemaDeAtencionAlClienteTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<SistemaDeAtencionAlClienteEntityFrameworkCoreTestModule>
{

}