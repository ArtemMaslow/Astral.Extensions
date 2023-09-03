using Astral.Extensions.EnumHelper.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astral.Extensions.EnumHelper.Tests.TestEnums
{
    public enum ApplicationInfoV1
    {
        [EnumNameAttribute("RegOffice.RegServices.Web")]
        RegService = 1,
        [EnumNameAttribute("Anonymous")]
        Anonymous = 2,
        [EnumNameAttribute("WebRegOfficeService")]
        WebRegOfficeService = 3,
        [EnumNameAttribute("RegOffice.LiteService.Host")]
        LiteServiceHost = 4,
        [EnumNameAttribute("RegOffice.CryptoService.Host")]
        CryptoServiceHost = 5,
        [EnumNameAttribute("RegOffice.CertService")]
        CertService = 6,
        [EnumNameAttribute("RegOffice.TransferService.Host")]
        TransferServiceHost = 7,
        [EnumNameAttribute("AstralReportRegService")]
        AstralReportRegService = 8,
        [EnumNameAttribute("AstralReportPackService")]
        AstralReportPackService = 9,
        //[EnumNameAttribute("AstralReportSignService")]
        AstralReportSignService = 10
    }
}
