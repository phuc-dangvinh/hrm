using Volo.Abp.Modularity;

namespace hrm;

public abstract class hrmApplicationTestBase<TStartupModule> : hrmTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
