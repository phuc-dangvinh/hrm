using System.Threading.Tasks;

namespace hrm.Data;

public interface IhrmDbSchemaMigrator
{
    Task MigrateAsync();
}
