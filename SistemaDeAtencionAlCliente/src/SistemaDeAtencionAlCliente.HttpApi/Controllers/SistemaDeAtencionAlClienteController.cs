using SistemaDeAtencionAlCliente.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SistemaDeAtencionAlCliente.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SistemaDeAtencionAlClienteController : AbpControllerBase
{
    protected SistemaDeAtencionAlClienteController()
    {
        LocalizationResource = typeof(SistemaDeAtencionAlClienteResource);
    }
}
