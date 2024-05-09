using Volo.Abp.Settings;

namespace hrm.Settings;

public class hrmSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(hrmSettings.MySetting1));
    }
}
