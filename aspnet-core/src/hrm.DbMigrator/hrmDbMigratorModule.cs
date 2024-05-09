using hrm.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace hrm.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(hrmEntityFrameworkCoreModule),
    typeof(hrmApplicationContractsModule)
    )]
public class hrmDbMigratorModule : AbpModule
{
}
