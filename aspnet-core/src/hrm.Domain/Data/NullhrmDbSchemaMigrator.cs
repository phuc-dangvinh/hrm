using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace hrm.Data;

/* This is used if database provider does't define
 * IhrmDbSchemaMigrator implementation.
 */
public class NullhrmDbSchemaMigrator : IhrmDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
