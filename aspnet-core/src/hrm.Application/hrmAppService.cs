using System;
using System.Collections.Generic;
using System.Text;
using hrm.Localization;
using Volo.Abp.Application.Services;

namespace hrm;

/* Inherit your application services from this class.
 */
public abstract class hrmAppService : ApplicationService
{
    protected hrmAppService()
    {
        LocalizationResource = typeof(hrmResource);
    }
}
