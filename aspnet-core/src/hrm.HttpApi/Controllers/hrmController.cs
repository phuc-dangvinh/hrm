using hrm.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace hrm.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class hrmController : AbpControllerBase
{
    protected hrmController()
    {
        LocalizationResource = typeof(hrmResource);
    }
}
