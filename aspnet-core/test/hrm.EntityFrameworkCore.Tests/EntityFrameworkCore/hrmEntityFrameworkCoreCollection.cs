using Xunit;

namespace hrm.EntityFrameworkCore;

[CollectionDefinition(hrmTestConsts.CollectionDefinitionName)]
public class hrmEntityFrameworkCoreCollection : ICollectionFixture<hrmEntityFrameworkCoreFixture>
{

}
