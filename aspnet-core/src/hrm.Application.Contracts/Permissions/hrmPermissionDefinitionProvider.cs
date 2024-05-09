using hrm.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace hrm.Permissions;

public class hrmPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(hrmPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(hrmPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<hrmResource>(name);
    }
}
