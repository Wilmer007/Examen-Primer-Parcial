using Microsoft.Extensions.Localization;
using SistemaDeAtencionAlCliente.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SistemaDeAtencionAlCliente;

[Dependency(ReplaceServices = true)]
public class SistemaDeAtencionAlClienteBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<SistemaDeAtencionAlClienteResource> _localizer;

    public SistemaDeAtencionAlClienteBrandingProvider(IStringLocalizer<SistemaDeAtencionAlClienteResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
