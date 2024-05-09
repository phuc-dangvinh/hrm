using hrm.Samples;
using Xunit;

namespace hrm.EntityFrameworkCore.Applications;

[Collection(hrmTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<hrmEntityFrameworkCoreTestModule>
{

}
