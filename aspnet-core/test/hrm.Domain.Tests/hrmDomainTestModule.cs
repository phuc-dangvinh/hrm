using Volo.Abp.Modularity;

namespace hrm;

[DependsOn(
    typeof(hrmDomainModule),
    typeof(hrmTestBaseModule)
)]
public class hrmDomainTestModule : AbpModule
{

}
