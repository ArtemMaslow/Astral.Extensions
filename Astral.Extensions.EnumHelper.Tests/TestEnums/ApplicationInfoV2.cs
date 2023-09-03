using Astral.Extensions.EnumHelper.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astral.Extensions.EnumHelper.Tests.TestEnums
{
    public enum ApplicationInfoV2
    {
        [EnumNameAttribute("RegOffice.ContainerService")]
        ContainerService = 11,
        [EnumNameAttribute("RegOffice.CertRequestService")]
        CertRequestService = 12,
        [EnumNameAttribute("RegOffice.RegCertService")]
        RegCertService = 13,
        [EnumNameAttribute("RegOffice.StorageService")]
        StorageService = 14,
        [EnumNameAttribute("ParseRegService")]
        ParseRegService = 15,
        [EnumNameAttribute("WebRegOfficeCertService")]
        WebRegOfficeCertService = 16,
        [EnumNameAttribute("WebRegOfficeLicService")]
        WebRegOfficeLicService = 18,
        [EnumNameAttribute("IrucService")]
        IrucService = 17,
        [EnumNameAttribute("RegOffice.SosService")]
        SosService = 20
    }
}
