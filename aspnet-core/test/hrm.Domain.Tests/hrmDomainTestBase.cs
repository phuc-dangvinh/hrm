using Volo.Abp.Modularity;

namespace hrm;

/* Inherit from this class for your domain layer tests. */
public abstract class hrmDomainTestBase<TStartupModule> : hrmTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
