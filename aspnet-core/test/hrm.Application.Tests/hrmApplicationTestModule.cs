using Volo.Abp.Modularity;

namespace hrm;

[DependsOn(
    typeof(hrmApplicationModule),
    typeof(hrmDomainTestModule)
)]
public class hrmApplicationTestModule : AbpModule
{

}
