using SistemaDeAtencionAlCliente.Localization;
using Volo.Abp.Application.Services;

namespace SistemaDeAtencionAlCliente;

/* Inherit your application services from this class.
 */
public abstract class SistemaDeAtencionAlClienteAppService : ApplicationService
{
    protected SistemaDeAtencionAlClienteAppService()
    {
        LocalizationResource = typeof(SistemaDeAtencionAlClienteResource);
    }
}
