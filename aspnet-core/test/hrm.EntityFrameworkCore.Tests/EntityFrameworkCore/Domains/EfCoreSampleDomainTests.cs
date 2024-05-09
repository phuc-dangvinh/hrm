using hrm.Samples;
using Xunit;

namespace hrm.EntityFrameworkCore.Domains;

[Collection(hrmTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<hrmEntityFrameworkCoreTestModule>
{

}
