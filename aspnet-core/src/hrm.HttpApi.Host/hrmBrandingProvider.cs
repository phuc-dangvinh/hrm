using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace hrm;

[Dependency(ReplaceServices = true)]
public class hrmBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "hrm";
}
