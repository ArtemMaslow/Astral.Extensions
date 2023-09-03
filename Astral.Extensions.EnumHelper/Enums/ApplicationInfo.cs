using Astral.Extensions.EnumHelper.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Astral.Extensions.EnumHelper.Enums
{
    public enum ApplicationInfo
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
        [EnumNameAttribute("AstralReportSignService")]
        AstralReportSignService = 10,
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
        SosService = 20,
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
        ActivationService = 30,
        [EnumNameAttribute("PfrService")]
        PfrService = 31,
        [EnumNameAttribute("BalanceService")]
        BalanceService = 32,
        [EnumNameAttribute("RegOffice.UpdateService")]
        UpdateService = 33,
        [EnumNameAttribute("RegOffice.LazyCertRequestService")]
        LazyCertRequestService = 34,
        [EnumNameAttribute("ServiceCopyConnectInMonth")]
        ServiceCopyConnectInMonth = 35,
        [EnumNameAttribute("DistributionService")]
        DistributionService = 36,
        [EnumNameAttribute("RegOffice.BillingService")]
        BillingService = 37,
        [EnumNameAttribute("InvoiceService")]
        InvoiceService = 38,
        [EnumNameAttribute("RegOffice.PkiService")]
        PkiService = 39,
        [EnumNameAttribute("RegOffice.RegInfoService.Host")]
        RegInfoServiceHost = 40,
        [EnumNameAttribute("RegOffice.AcfService")]
        AcfService = 41,
        [EnumNameAttribute("RegOffice.MailRegistrationService")]
        MailRegistrationService = 42,
        [EnumNameAttribute("RegOffice.LazyAcfService")]
        LazyAcfService = 43,
        [EnumNameAttribute("RegOffice.AutoRegRequestService")]
        AutoRegRequestService = 44,
        [EnumNameAttribute("RegOffice.AutoRegSendingService")]
        AutoRegSendingService = 45,
        [EnumNameAttribute("RegOffice.AutoRegReceivingService")]
        AutoRegReceivingService = 46,
        [EnumNameAttribute("RegOffice.Testervice")]
        TestFlcService = 47,
        [EnumNameAttribute("RegOffice.ReflexService")]
        ReflexService = 48,
        [EnumNameAttribute("RegOffice.WorkflowService")]
        WorkflowService = 49,
        [EnumNameAttribute("RegOffice.CrlService")]
        CrlService = 50,
        [EnumNameAttribute("RegOffice.EmailNoticeService")]
        EmailNoticeService = 51,
        [EnumNameAttribute("AccountInformService")]
        AccountInformService = 52,
        [EnumNameAttribute("RegOffice.EsiaService")]
        [Obsolete]
        EsiaService = 53,
        [EnumNameAttribute("ProxyServiceHost")]
        ProxyServiceHost = 54,
        [EnumNameAttribute("RegOffice.CompleteService")]
        CompleteService = 55,
        [EnumNameAttribute("RegOffice.SkrinService")]
        SkrinService = 56,
        [EnumNameAttribute("RegOffice.BalanceRegistrationService")]
        BalanceRegistrationService = 58,
        [EnumNameAttribute("RegOffice.SkrinProxy.Host")]
        SkrinProxyHost = 59,
        [EnumNameAttribute("RegOffice.FileService.Host")]
        FileServiceHost = 60,
        [EnumNameAttribute("RegOffice.ArchivingService")]
        ArchivingService = 61,
        [EnumNameAttribute("RegOffice.DynamicRewardService")]
        DynamicRewardService = 62,
        [EnumNameAttribute("RegOffice.DynamicRewardReportService")]
        DynamicRewardReportService = 63,
        [EnumNameAttribute("RegOffice.ProlongationService")]
        ProlongationService = 64,
        [EnumNameAttribute("RegOffice.CompanyGroupService")]
        CompanyGroupService = 65,
        [EnumNameAttribute("RegOffice.FnsPortalService.Host")]
        FnsPortalServiceHost = 66,
        [EnumNameAttribute("RegOffice.LoadCertService")]
        LoadCertService = 67,
        [EnumNameAttribute("RegOffice.UnregisterService")]
        UnregisterService = 68,
        [EnumNameAttribute("RegOffice.NotificationRequest.Host")]
        NotificationRequestHost = 70,
        [EnumNameAttribute("RegOffice.NotificationCreateService")]
        NotificationCreateService = 71,
        [EnumNameAttribute("RegOffice.EGRULAutoAttachment")]
        EgrulAutoAttachment = 72,
        [EnumNameAttribute("RegOffice.NotificationSendService")]
        NotificationSendService = 73,
        [EnumNameAttribute("RegOffice.CertificateReportService")]
        CertificateReportService = 74,
        [EnumNameAttribute("RegOffice.MercuryBalanceService")]
        MercuryBalanceService = 75,
        [EnumNameAttribute("RegOffice.TenderConsultingRegistrationService")]
        TenderConsultingRegistrationService = 76,
        [EnumNameAttribute("RegOffice.SmsIdentificationCheckService")]
        SmsIdentificationCheckService = 77,
        [EnumNameAttribute("RegOffice.HubRegistrationService")]
        HubRegistrationService = 78,
        [EnumNameAttribute("RegOffice.SmevService")]
        [Obsolete]
        SmevService = 79,
        [EnumNameAttribute("RegOffice.CryptoProRequestService")]
        CryptoProRequestService = 80,
        [EnumNameAttribute("RegOffice.EsiaServices.Host")]
        [Obsolete]
        EsiaServicesHost = 81,
        [EnumNameAttribute("RegOffice.OfdService")]
        OfdService = 90,
        [EnumNameAttribute("RegOffice.FiasUpdateService")]
        FiasUpdateService = 92,
        [EnumNameAttribute("RegOffice.AutoRejectService")]
        AutoRejectService = 93,
        [EnumNameAttribute("RegOffice.OfdRegRequestService")]
        OfdRegRequestService = 95,
        [EnumNameAttribute("RegOffice.OfdRegSendingService")]
        OfdRegSendingService = 96,
        [EnumNameAttribute("RegOffice.OfdRegReceivingService")]
        OfdRegReceivingService = 97,
        [EnumNameAttribute("RegOffice.WorkflowOperationService")]
        WorkflowOperationService = 98,
        [EnumNameAttribute("RegOffice.CallbackService")]
        CallbackService = 99,
        [EnumNameAttribute("RegOffice.ScheduledReportService")]
        ScheduledReportService = 100,
        [EnumNameAttribute("RegOffice.ReportService")]
        ReportService = 102,
        [EnumNameAttribute("RegOfficeWebForms.SkrinManager")]
        SkrinManager = 103,
        [EnumNameAttribute("RegOffice.DataCheckingService")]
        DataCheckingService = 104,
        [EnumNameAttribute("RegOffice.AutomaticProcessingService")]
        AutomaticProcessingService = 105,
        [EnumNameAttribute("RegOffice.LazyCheckingService")]
        LazyCheckingService = 106,
        [EnumNameAttribute("RegOffice.RdlUpdaterService")]
        RdlUpdaterService = 107,
        [EnumNameAttribute("RegOffice.AbonentCountService")]
        AbonentCountService = 108,
        [EnumNameAttribute("RegOffice.VipNetRequestService")]
        VipNetRequestService = 110,
        [EnumNameAttribute("RegOffice.StatRegCertService")]
        StatRegCertService = 111,
        [EnumNameAttribute("RegOffice.Option1CUpdaterService")]
        Option1CUpdaterService = 112,
        [EnumNameAttribute("RegOffice.Smev3Request.Host")]
        Smev3RequestHost = 114,
        [EnumNameAttribute("RegOffice.Smev3ResponseService")]
        Smev3ResponseService = 115,
        [EnumNameAttribute("RegOffice.Smev3CertRegService")]
        Smev3CertRegService = 116,
        [EnumNameAttribute("RegOffice.DocumentCheckingService")]
        DocumentCheckingService = 118,
        [EnumNameAttribute("RegOffice.AstralDssApi.Rest")]
        AstralDssApiRest = 119,
        [EnumNameAttribute("RegOffice.DssCertificateService")]
        DssCertificateService = 120,
        [EnumNameAttribute("RegOffice.DssCallback.Host")]
        DssCallbackHost = 121,
        [EnumNameAttribute("RegOffice.DssSendService")]
        DssSendService = 122,
        [EnumNameAttribute("RegOffice.AstralMercuryRegService")]
        AstralMercuryRegService = 123,
        [EnumNameAttribute("RegOffice.AbonentTariff1CSyncService")]
        AbonentTariff1CSyncService = 124,
        [EnumNameAttribute("RegOffice.Smev3CheckService")]
        Smev3CheckService = 127,
        [EnumNameAttribute("RegOffice.ItsSyncService")]
        ItsSyncService = 128,
        [EnumNameAttribute("RegOffice.MetricsExportService")]
        MetricsExportService = 129,
        [EnumNameAttribute("RegOffice.MigrationService")]
        MigrationService = 130,
        [EnumNameAttribute("RegOffice.RoseltorgSendCertificateRequestService")]
        RoseltorgSendCertificateRequestService = 131,
        [EnumNameAttribute("RegOffice.RoseltorgLoadCertificateService")]
        RoseltorgLoadCertificateService = 132,
        [EnumNameAttribute("RegOffice.RoseltorgRegisterCertificateService")]
        RoseltorgRegisterCertificateService = 133,
        [EnumNameAttribute("RegOffice.DssUnregisterService")]
        DssUnregisterService = 135,
        [EnumNameAttribute("RegOffice.OsnovanieSendCertificateRequestService")]
        OsnovanieSendCertificateRequestService = 136,
        [EnumNameAttribute("RegOffice.OsnovanieLoadCertificateService")]
        OsnovanieLoadCertificateService = 137,
        [EnumNameAttribute("RegOffice.OsnovanieRegisterCertificateService")]
        OsnovanieRegisterCertificateService = 138,
        [EnumName("RegOffice.BlockRequisitesService")]
        BlockRequisitesService = 139,
        [EnumName("RegOffice.TradingPlatformRegistrationService")]
        TradingPlatformRegistrationService = 140,
        [EnumName("RegOffice.AutoAttachRequestService")]
        AutoAttachRequestService = 142,
        [EnumName("RegOffice.BulkUploadLicensesService")]
        BulkUploadLicensesService = 141,
        [EnumName("RegOffice.StorageExhaustionNotificationService")]
        StorageExhaustionNotificationService = 144,
        [EnumName("RegOffice.FnsCaRequestService")]
        FnsCaRequestService = 145,
        [EnumName("RegOffice.FnsCaResponseService")]
        FnsCaResponseService = 146,
        [EnumName("RegOffice.DssCallbackTarget")]
        DssCallbackTarget = 147,
        [EnumNameAttribute("RegOffice.ReflexServiceHost")]
        ReflexServiceHost = 148,
        [EnumName("RegOffice.WorkflowBlockTrackingService")]
        WorkflowBlockTrackingService = 150,
        [EnumName("RegOffice.TradingPlatformRegistrationRequestService")]
        TradingPlatformRegistrationRequestService = 151,
        [EnumName("RegOffice.OneSPartnersRatingReportService")]
        OneSPartnersRatingReportService = 152,
        [EnumName("RegOffice.DssCreateUserService")]
        DssCreateUserService = 153,
        [EnumName("RegOffice.OneSSalesReportService")]
        OneSSalesReportService = 154
    }
}
