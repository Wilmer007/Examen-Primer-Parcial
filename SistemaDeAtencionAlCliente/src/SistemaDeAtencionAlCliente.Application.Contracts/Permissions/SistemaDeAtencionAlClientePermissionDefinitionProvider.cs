using SistemaDeAtencionAlCliente.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace SistemaDeAtencionAlCliente.Permissions;

public class SistemaDeAtencionAlClientePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SistemaDeAtencionAlClientePermissions.GroupName);

        var booksPermission = myGroup.AddPermission(SistemaDeAtencionAlClientePermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(SistemaDeAtencionAlClientePermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(SistemaDeAtencionAlClientePermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(SistemaDeAtencionAlClientePermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SistemaDeAtencionAlClientePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SistemaDeAtencionAlClienteResource>(name);
    }
}
