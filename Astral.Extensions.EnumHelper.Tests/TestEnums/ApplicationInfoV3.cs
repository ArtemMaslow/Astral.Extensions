using Astral.Extensions.EnumHelper.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astral.Extensions.EnumHelper.Tests.TestEnums
{
    public enum ApplicationInfoV3
    {
        [EnumNameAttribute("unknown")]
        UserService = 21,
        [EnumNameAttribute("RegOffice.RegService.Host")]
        RegServiceHost = 22,
        [EnumNameAttribute("RegOffice.CertificateRequestService")]
        CertificateRequestService = 23,
        [EnumNameAttribute("RegOffice.RandomNumberGenerator")]
        RngService = 24,
        [EnumNameAttribute("RegOffice.RegFileLoaderService")]
        RegFileLoaderService = 25,
        [EnumNameAttribute("RegOffice.ITSCheckService")]
        ItsCheckService = 28,
        [EnumNameAttribute("RegOffice.LazyRegService")]
        LazyRegService = 29,
        [EnumNameAttribute("RegOffice.ActivationService")]
        ActivationService = 30
    }
}
