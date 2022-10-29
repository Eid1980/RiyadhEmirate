using AutoMapper;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.AboutUs;
using Emirates.Core.Application.Dtos.MainPoints;
using Emirates.Core.Application.Dtos.Requests;
using Emirates.Core.Application.Dtos.WomanSection;
using Emirates.Core.Domain.Entities;

namespace Emirates.Core.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Auction
            CreateMap<CreateAuctionDto, Auction>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));
            CreateMap<UpdateAuctionDto, Auction>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));

            CreateMap<Auction, GetAuctionDetailsDto>();
            CreateMap<Auction, GetAuctionListDto>();
            #endregion

            #region CaseType
            CreateMap<CreateCaseTypeDto, CaseType>();
            CreateMap<UpdateCaseTypeDto, CaseType>();

            CreateMap<CaseType, GetCaseTypeDetailsDto>();
            CreateMap<CaseType, GetCaseTypeListDto>();
            #endregion

            #region FileManager
            CreateMap<CreateUploadedFileDto, UploadedFile>();
            CreateMap<UploadedFile, GetUploadedFileDto>();
            #endregion

            #region MainPagePoint
            CreateMap<MainPagePoints, GetMainPagePoints>();
            CreateMap<CreateMainPoints, MainPagePoints>().ReverseMap();
            CreateMap<UpdateMainPoint, MainPagePoints>().ReverseMap();
            #endregion

            #region EmiratesPrince
            CreateMap<CreateEmiratesPrinceDto, EmiratesPrince>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));
            CreateMap<UpdateEmiratesPrinceDto, EmiratesPrince>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));

            CreateMap<EmiratesPrince, GetEmiratesPrinceDetailsDto>()
                .ForMember(dest => dest.FromDate, src => src.MapFrom(m => m.FromDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.ToDate, src => src.MapFrom(m => m.ToDate == null? "حتى الان" : m.ToDate.Value.ToString("yyyy-MM-dd")));
            CreateMap<EmiratesPrince, GetEmiratesPrinceListDto>()
                .ForMember(dest => dest.FromDate, src => src.MapFrom(m => m.FromDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.ToDate, src => src.MapFrom(m => m.ToDate == null ? "حتى الان" : m.ToDate.Value.ToString("yyyy-MM-dd")));
            #endregion

            #region ContactUsMessage
            CreateMap<CreateContactUsMessageDto, ContactUsMessage>();

            CreateMap<ContactUsMessage, GetContactUsMessageDetailsDto>()
                .ForMember(dest => dest.ContactUsMessageTypeName, src => src.MapFrom(m => m.ContactUsMessageType.NameAr))
                .ForMember(dest => dest.CreatedDate, src => src.MapFrom(m => m.CreatedDate.ToString("yyyy-MM-dd")));
            CreateMap<ContactUsMessage, GetContactUsMessageListDto>()
                .ForMember(dest => dest.ContactUsMessageTypeName, src => src.MapFrom(m => m.ContactUsMessageType.NameAr));
            #endregion

            #region Governorate
            CreateMap<CreateGovernorateDto, Governorate>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));
            CreateMap<UpdateGovernorateDto, Governorate>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));

            CreateMap<Governorate, GetGovernorateDetailsDto>();
            CreateMap<Governorate, GetGovernorateListDto>();
            #endregion

            #region Home
            CreateMap<CreateDesignEvaluationDto, DesignEvaluation>();
            #endregion

            #region Nationality
            CreateMap<CreateNationalityDto, Nationality>();
            CreateMap<UpdateNationalityDto, Nationality>();

            CreateMap<Nationality, GetNationalityDetailsDto>();
            CreateMap<Nationality, GetNationalityListDto>();
            #endregion

            #region News
            CreateMap<CreateNewsDto, News>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));
            CreateMap<UpdateNewsDto, News>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));

            CreateMap<News, GetNewsDetailsDto>()
                .ForMember(dest => dest.NewsCategueryName, src => src.MapFrom(m => m.NewsCateguery.NameAr))
                .ForMember(dest => dest.NewsDate, src => src.MapFrom(m => m.Date.ToString("yyyy-MM-dd")));
            CreateMap<News, GetNewsListDto>()
                .ForMember(dest => dest.NewsCategueryName, src => src.MapFrom(m => m.NewsCateguery.NameAr));
            #endregion

            #region NewsCateguery
            CreateMap<CreateNewsCategueryDto, NewsCateguery>();
            CreateMap<UpdateNewsCategueryDto, NewsCateguery>();

            CreateMap<NewsCateguery, GetNewsCategueryDetailsDto>();
            CreateMap<NewsCateguery, GetNewsCategueryListDto>();
            #endregion

            #region NewsComment
            CreateMap<CreateNewsCommentDto, NewsComment>();

            CreateMap<NewsComment, GetNewsCommentDetailsDto>()
                .ForMember(dest => dest.NewsTitle, src => src.MapFrom(m => m.News.Title))
                .ForMember(dest => dest.CommentStageName, src => src.MapFrom(m => m.CommentStage.NameAr))
                .ForMember(dest => dest.CreatedDate, src => src.MapFrom(m => m.CreatedDate.ToString("yyyy-MM-dd")));
            CreateMap<NewsComment, GetNewsCommentListDto>()
                .ForMember(dest => dest.CommentStageName, src => src.MapFrom(m => m.CommentStage.NameAr))
                .ForMember(dest => dest.IsArabic, src => src.MapFrom(m => m.News.IsArabic))
                .ForMember(dest => dest.CreatedDate, src => src.MapFrom(m => m.CreatedDate.ToString("yyyy-MM-dd")));
            #endregion

            #region OpenDataCateguery
            CreateMap<CreateOpenDataCategueryDto, OpenDataCateguery>();
            CreateMap<UpdateOpenDataCategueryDto, OpenDataCateguery>();

            CreateMap<OpenDataCateguery, GetOpenDataCategueryDetailsDto>()
                .ForMember(dest => dest.OpenDataSubCategueryName, src => src.MapFrom(m => m.OpenDataSubCateguery.NameAr));
            CreateMap<OpenDataCateguery, GetOpenDataCategueryListDto>()
                .ForMember(dest => dest.OpenDataSubCategueryName, src => src.MapFrom(m => m.OpenDataSubCateguery.NameAr));
            #endregion

            #region OpenDataReport
            CreateMap<CreateOpenDataReportDto, OpenDataReport>();
            CreateMap<UpdateOpenDataReportDto, OpenDataReport>();

            CreateMap<OpenDataReport, GetOpenDataReportDetailsDto>()
                .ForMember(dest => dest.OpenDataCategueryName, src => src.MapFrom(m => m.OpenDataCateguery.NameAr));
            CreateMap<OpenDataReport, GetOpenDataReportListDto>()
                .ForMember(dest => dest.OpenDataCategueryName, src => src.MapFrom(m => m.OpenDataCateguery.NameAr));
            #endregion

            #region OpenDataRequest
            CreateMap<CreateOpenDataRequestDto, OpenDataRequest>();

            CreateMap<OpenDataRequest, GetOpenDataRequestDetailsDto>()
                .ForMember(dest => dest.CreatedDate, src => src.MapFrom(m => m.CreatedDate.ToString("yyyy-MM-dd"))); ;
            CreateMap<OpenDataRequest, GetOpenDataRequestListDto>();
            #endregion

            #region PageContent
            CreateMap<PageContent, GetAboutUsDto>()
                .ForPath(dest => dest.MainPoints, src => src.MapFrom(opt => opt.MainPagePoints));

            CreateMap<UpdateAboutUsDto, PageContent>().ReverseMap();

            CreateMap<PageContent, GetWomanSectionDto>()
            .ForPath(dest => dest.MainPoints, src => src.MapFrom(opt => opt.MainPagePoints));

            CreateMap<UpdateWomanSectionDto, PageContent>().ReverseMap();
            #endregion

            #region Poster
            CreateMap<CreatePosterDto, Poster>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));
            CreateMap<UpdatePosterDto, Poster>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));

            CreateMap<Poster, GetPosterDetailsDto>();
            CreateMap<Poster, GetPosterListDto>();
            #endregion

            #region Prison
            CreateMap<CreatePrisonDto, Prison>();
            CreateMap<UpdatePrisonDto, Prison>();

            CreateMap<Prison, GetPrisonDetailsDto>();
            CreateMap<Prison, GetPrisonListDto>();
            #endregion

            #region Account
            CreateMap<CreateUserDto, User>();
            CreateMap<User, GetUserDto>()
                .ForMember(dest => dest.NameAr, src => src.MapFrom(m => $"{m.FirstNameAr} {m.SecondNameAr} {m.ThirdNameAr} {m.LastNameAr}"))
                .ForMember(dest => dest.ShortNameAr, src => src.MapFrom(m => $"{m.FirstNameAr} {m.LastNameAr}"))
                .ForMember(dest => dest.NameEn, src => src.MapFrom(m => $"{m.FirstNameEn} {m.SecondNameEn} {m.ThirdNameEn} {m.LastNameEn}"))
                .ForMember(dest => dest.ShortNameEn, src => src.MapFrom(m => $"{m.FirstNameEn} {m.LastNameEn}"))
                .ForMember(dest => dest.GenderName, src => src.MapFrom(m => m.IsMale ? "ذكر" : "أنثى"))
                .ForMember(dest => dest.NationalityName, src => src.MapFrom(m => m.Nationality.NameAr));
            CreateMap<User, GetUserSessionDto>()
                .ForMember(dest => dest.ShortName, src => src.MapFrom(m => $"{m.FirstNameAr} {m.LastNameAr}"));
            CreateMap<User, GetUserDataDto>()
                .ForMember(dest => dest.Name, src => src.MapFrom(m => $"{m.FirstNameAr} {m.SecondNameAr} {m.ThirdNameAr} {m.LastNameAr}"))
                .ForMember(dest => dest.BirthDate, src => src.MapFrom(m => m.BirthDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.GenderName, src => src.MapFrom(m => m.IsMale ? "ذكر" : "أنثى"));
            #endregion

            #region Request
            CreateMap<Request, GetRequestDetailsDto>()
                .ForMember(dest => dest.CanEdit, src => src.MapFrom(m => m.Stage.CanEdit));

            CreateMap<Request, GetMyRequestListDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.Url, src => src.MapFrom(m => m.Service.ServiceStages.FirstOrDefault(x => x.StageId.Equals(m.StageId)).RequesterUrl));

            CreateMap<Request, GetInboxListDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.NationalId, src => src.MapFrom(m => m.CreatedUser.UserName))
                .ForMember(dest => dest.Url, src => src.MapFrom(m => m.Service.ServiceStages.FirstOrDefault(x => x.StageId.Equals(m.StageId)).AdminUrl));


            CreateMap<Request, GetElectronicConcilInboxDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.NationalId, src => src.MapFrom(m => m.CreatedUser.UserName))
                .ForMember(dest => dest.Url, src => src.MapFrom(m => m.Service.ServiceStages.FirstOrDefault(x => x.StageId.Equals(m.StageId)).RequesterUrl))
                .ForMember(dest => dest.RequestTitle, src => src.MapFrom(o => o.RequestElectronicBoard.RequestTitle))
                .ForMember(dest => dest.RequestContent, src => src.MapFrom(o => o.RequestElectronicBoard.RequestContent))
                .ForMember(dest => dest.StageName, src => src.MapFrom(o => o.Stage.NameAr))
                .ForMember(dest => dest.RequestTypeName, src => src.MapFrom(o => o.RequestElectronicBoard.RequestType.NameAr));


            #endregion

            #region RequestStageLog
            CreateMap<RequestStageLog, GetRequestStageLogsDto>()
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CreatedByName, src => src.MapFrom(m => $"{m.CreatedUser.FirstNameAr} {m.CreatedUser.LastNameAr}"))
                .ForMember(dest => dest.CreatedDate, src => src.MapFrom(m => m.CreatedDate.ToString("yyyy-MM-dd")));
            #endregion

            #region RequestElectronicBoards
            CreateMap<CreateRequestElectronicBoardDto, RequestElectronicBoard>();
            CreateMap<UpdateRequestElectronicBoardDto, RequestElectronicBoard>();

            CreateMap<Request, GetRequestElectronicBoardDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CanEdit, src => src.MapFrom(m => m.Stage.CanEdit))
                .ForMember(dest => dest.RequestTypeName, src => src.MapFrom(m => m.RequestElectronicBoard.RequestType.NameAr))
                .ForMember(dest => dest.RequestTitle, src => src.MapFrom(m => m.RequestElectronicBoard.RequestTitle))
                .ForMember(dest => dest.RequestContent, src => src.MapFrom(m => m.RequestElectronicBoard.RequestContent));
            CreateMap<RequestElectronicBoard, RequestElectronicBoardDto>();
            #endregion

            #region RequestElectronicSummons
            CreateMap<CreateRequestElectronicSummonDto, RequestElectronicSummon>();
            CreateMap<UpdateRequestElectronicSummonDto, RequestElectronicSummon>();

            CreateMap<Request, GetRequestElectronicSummonDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CanEdit, src => src.MapFrom(m => m.Stage.CanEdit))
                .ForMember(dest => dest.RequestTypeName, src => src.MapFrom(m => m.RequestElectronicSummon.RequestType.NameAr))
                .ForMember(dest => dest.RequestTitle, src => src.MapFrom(m => m.RequestElectronicSummon.RequestTitle))
                .ForMember(dest => dest.RequestContent, src => src.MapFrom(m => m.RequestElectronicSummon.RequestContent));
            CreateMap<RequestElectronicSummon, RequestElectronicSummonDto>();
            #endregion

            #region RequestForeignersRealtyOwners
            CreateMap<CreateRequestForeignersRealtyOwnerDto, RequestForeignersRealtyOwner>();
            CreateMap<UpdateRequestForeignersRealtyOwnerDto, RequestForeignersRealtyOwner>();

            CreateMap<Request, GetRequestForeignersRealtyOwnerDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CanEdit, src => src.MapFrom(m => m.Stage.CanEdit))
                .ForMember(dest => dest.BuildingTypeName, src => src.MapFrom(m => m.RequestForeignersRealtyOwner.BuildingType.NameAr))
                .ForMember(dest => dest.GovernorateName, src => src.MapFrom(m => m.RequestForeignersRealtyOwner.Governorate.NameAr))
                .ForMember(dest => dest.District, src => src.MapFrom(m => m.RequestForeignersRealtyOwner.District))
                .ForMember(dest => dest.ReligionName, src => src.MapFrom(m => m.RequestForeignersRealtyOwner.Religion.NameAr))
                .ForMember(dest => dest.Address, src => src.MapFrom(m => m.RequestForeignersRealtyOwner.Address));
            CreateMap<RequestForeignersRealtyOwner, RequestForeignersRealtyOwnerDto>();
            #endregion

            #region RequestJudgmentExecution
            CreateMap<CreateRequestJudgmentExecutionDto, RequestJudgmentExecution>();
            CreateMap<UpdateRequestJudgmentExecutionDto, RequestJudgmentExecution>();

            CreateMap<Request, GetRequestJudgmentExecutionDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CanEdit, src => src.MapFrom(m => m.Stage.CanEdit))
                .ForMember(dest => dest.RequesterTypeName, src => src.MapFrom(m => m.RequestJudgmentExecution.RequesterType == 1 ? "نفسه" : "الموكل"))
                .ForMember(dest => dest.RequesterName, src => src.MapFrom(m => m.RequestJudgmentExecution.RequesterName))
                .ForMember(dest => dest.RequesterNationalId, src => src.MapFrom(m => m.RequestJudgmentExecution.RequesterNationalId))
                .ForMember(dest => dest.DefendantTypeName, src => src.MapFrom(m => m.RequestJudgmentExecution.DefendantType.NameAr))
                .ForMember(dest => dest.LawsuitNumber, src => src.MapFrom(m => m.RequestJudgmentExecution.LawsuitNumber))
                .ForMember(dest => dest.LawsuitDate, src => src.MapFrom(m => m.RequestJudgmentExecution.LawsuitDate.ToString("yyyy-MM-dd")));
            CreateMap<RequestJudgmentExecution, RequestJudgmentExecutionDto>();
            #endregion

            #region RequestLandsInfringement
            CreateMap<CreateRequestLandsInfringementDto, RequestLandsInfringement>();
            CreateMap<UpdateRequestLandsInfringementDto, RequestLandsInfringement>();

            CreateMap<Request, GetRequestLandsInfringementDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CanEdit, src => src.MapFrom(m => m.Stage.CanEdit))
                .ForMember(dest => dest.RequestTypeName, src => src.MapFrom(m => m.RequestLandsInfringement.RequestType.NameAr))
                .ForMember(dest => dest.EstimatedSpace, src => src.MapFrom(m => m.RequestLandsInfringement.EstimatedSpace))
                .ForMember(dest => dest.GovernorateName, src => src.MapFrom(m => m.RequestLandsInfringement.Governorate.NameAr))
                .ForMember(dest => dest.Address, src => src.MapFrom(m => m.RequestLandsInfringement.Address))
                .ForMember(dest => dest.Longitude, src => src.MapFrom(m => m.RequestLandsInfringement.Longitude))
                .ForMember(dest => dest.Latitude, src => src.MapFrom(m => m.RequestLandsInfringement.Latitude))
                .ForMember(dest => dest.LocationLink, src => src.MapFrom(m => $"https://www.google.com/maps,{m.RequestLandsInfringement.Longitude},{m.RequestLandsInfringement.Latitude}"))
                .ForMember(dest => dest.InfringerDescription, src => src.MapFrom(m => m.RequestLandsInfringement.InfringerDescription));
            CreateMap<RequestLandsInfringement, RequestLandsInfringementDto>();
            #endregion

            #region RequestMarriageCertificate
            CreateMap<CreateRequestMarriageCertificateDto, RequestMarriageCertificate>();
            CreateMap<UpdateRequestMarriageCertificateDto, RequestMarriageCertificate>();

            CreateMap<Request, GetRequestMarriageCertificateDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CanEdit, src => src.MapFrom(m => m.Stage.CanEdit))
                .ForMember(dest => dest.RequestTypeName, src => src.MapFrom(m => m.RequestMarriageCertificate.RequestType.NameAr))
                .ForMember(dest => dest.EmployeeSide, src => src.MapFrom(m => m.RequestMarriageCertificate.EmployeeSide))
                .ForMember(dest => dest.JobOccupation, src => src.MapFrom(m => m.RequestMarriageCertificate.JobOccupation))
                .ForMember(dest => dest.MaritalStatusName, src => src.MapFrom(m => m.RequestMarriageCertificate.MaritalStatus.NameAr))
                .ForMember(dest => dest.ChildrenCount, src => src.MapFrom(m => m.RequestMarriageCertificate.ChildrenCount));
            CreateMap<RequestMarriageCertificate, RequestMarriageCertificateDto>();
            #endregion

            #region RequestPrisonersServices
            CreateMap<CreateRequestPrisonersServiceDto, RequestPrisonersService>();
            CreateMap<UpdateRequestPrisonersServiceDto, RequestPrisonersService>();

            CreateMap<Request, GetRequestPrisonersServiceDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CanEdit, src => src.MapFrom(m => m.Stage.CanEdit))
                .ForMember(dest => dest.RequestTypeName, src => src.MapFrom(m => m.RequestPrisonersService.RequestType.NameAr))
                .ForMember(dest => dest.CaseTypeName, src => src.MapFrom(m => m.RequestPrisonersService.CaseType.NameAr))
                .ForMember(dest => dest.PrisonName, src => src.MapFrom(m => m.RequestPrisonersService.Prison.NameAr));
            CreateMap<RequestPrisonersService, RequestPrisonersServiceDto>();
            #endregion

            #region RequestPrisonerTempReleases
            CreateMap<CreateRequestPrisonerTempReleaseDto, RequestPrisonerTempRelease>();
            CreateMap<UpdateRequestPrisonerTempReleaseDto, RequestPrisonerTempRelease>();

            CreateMap<Request, GetRequestPrisonerTempReleaseDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CanEdit, src => src.MapFrom(m => m.Stage.CanEdit))
                .ForMember(dest => dest.RequestTypeName, src => src.MapFrom(m => m.RequestPrisonerTempRelease.RequestType.NameAr))
                .ForMember(dest => dest.CaseTypeName, src => src.MapFrom(m => m.RequestPrisonerTempRelease.CaseType.NameAr))
                .ForMember(dest => dest.PrisonName, src => src.MapFrom(m => m.RequestPrisonerTempRelease.Prison.NameAr));
            CreateMap<RequestPrisonerTempRelease, RequestPrisonerTempReleaseDto>();
            #endregion

            #region RequestTreatmentRecommendation
            CreateMap<CreateRequestTreatmentRecommendationDto, RequestTreatmentRecommendation>();
            CreateMap<UpdateRequestTreatmentRecommendationDto, RequestTreatmentRecommendation>();

            CreateMap<Request, GetRequestTreatmentRecommendationDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.RequestDate, src => src.MapFrom(m => m.RequestDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CanEdit, src => src.MapFrom(m => m.Stage.CanEdit))
                .ForMember(dest => dest.RequestTypeName, src => src.MapFrom(m => m.RequestTreatmentRecommendation.RequestType.NameAr))
                .ForMember(dest => dest.PatientTypeName, src => src.MapFrom(m => m.RequestTreatmentRecommendation.PatientType == 1 ? "نفسه" : "أحد الأقارب"))
                .ForMember(dest => dest.PatientName, src => src.MapFrom(m => m.RequestTreatmentRecommendation.PatientName))
                .ForMember(dest => dest.PatientNationalId, src => src.MapFrom(m => m.RequestTreatmentRecommendation.PatientNationalId));
            CreateMap<RequestTreatmentRecommendation, RequestTreatmentRecommendationDto>();
            #endregion

            #region RequestAttachmentType
            CreateMap<CreateRequestAttachmentTypeDto, RequestAttachmentType>();
            CreateMap<UpdateRequestAttachmentTypeDto, RequestAttachmentType>();

            CreateMap<RequestAttachmentType, GetRequestAttachmentTypeDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr));
            CreateMap<RequestAttachmentType, GetRequestAttachmentTypeListDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr));
            #endregion

            #region RequestType
            CreateMap<CreateRequestTypeDto, RequestType>();
            CreateMap<UpdateRequestTypeDto, RequestType>();

            CreateMap<RequestType, GetRequestTypeDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr));
            CreateMap<RequestType, GetRequestTypeListDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr));
            #endregion

            #region Role
            CreateMap<CreateRoleDto, Role>();
            CreateMap<UpdateRoleDto, Role>();

            CreateMap<Role, GetRoleDetailsDto>();
            CreateMap<Role, GetRoleListDto>();
            #endregion

            #region Service
            CreateMap<CreateServiceDto, Service>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));
            CreateMap<UpdateServiceDto, Service>()
                .ForMember(dest => dest.ImageName, src => src.MapFrom(m => !string.IsNullOrEmpty(m.ImageName) ? $"{Guid.NewGuid()}_{m.ImageName}" : m.ImageName));

            CreateMap<Service, GetServiceDetailsDto>()
                .ForMember(dest => dest.ServiceCost, src => src.MapFrom(m => m.Cost));
            CreateMap<Service, GetServiceListDto>();
            CreateMap<Service, GetAllServiceListDto>()
                .ForMember(dest => dest.RequestCount, src => src.MapFrom(m => m.Requests.Count));
            #endregion

            #region ServiceAudience
            CreateMap<CreateServiceAudienceDto, ServiceAudience>();
            CreateMap<ServiceAudience, GetServiceAudienceListDto>()
                .ForMember(dest => dest.AudienceName, src => src.MapFrom(m => m.Audience.NameAr));
            #endregion

            #region ServiceCondition
            CreateMap<CreateServiceConditionDto, ServiceCondition>();
            CreateMap<UpdateServiceConditionDto, ServiceCondition>();

            CreateMap<ServiceCondition, GetServiceConditionDetailsDto>();
            CreateMap<ServiceCondition, GetServiceConditionListDto>();
            #endregion

            #region ServiceBenefit
            CreateMap<CreateServiceBenefitDto, ServiceBenefit>();
            #endregion

            #region ServiceRate
            CreateMap<CreateServiceRateDto, ServiceRate>();
            #endregion

            #region ServiceStage
            CreateMap<CreateServiceStageDto, ServiceStage>();
            CreateMap<UpdateServiceStageDto, ServiceStage>();

            CreateMap<ServiceStage, GetServiceStageDetailsDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr));
            CreateMap<ServiceStage, GetServiceStageListDto>()
                .ForMember(dest => dest.ServiceName, src => src.MapFrom(m => m.Service.NameAr))
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr));
            #endregion

            #region UserRole
            CreateMap<CreateUserRoleDto, UserRole>();

            CreateMap<UserRole, GetRolUsersDto>()
                .ForMember(dest => dest.UserFullName, src => src.MapFrom(m => $"{m.User.FirstNameAr} {m.User.SecondNameAr} {m.User.ThirdNameAr} {m.User.LastNameAr}"))
                .ForMember(dest => dest.UserNationalId, src => src.MapFrom(m => m.User.UserName))
                .ForMember(dest => dest.UserPhoneNumber, src => src.MapFrom(m => m.User.PhoneNumber));
            CreateMap<User, GetUserListDto>()
                .ForMember(dest => dest.FullName, src => src.MapFrom(m => $"{m.FirstNameAr} {m.SecondNameAr} {m.ThirdNameAr} {m.LastNameAr}"));

            CreateMap<UserRole, GetUserRoleListDto>()
                .ForMember(dest => dest.RoleNameAr, src => src.MapFrom(m => m.Role.NameAr))
                .ForMember(dest => dest.RoleNameEn, src => src.MapFrom(m => m.Role.NameEn));
            #endregion

        }
    }
}
