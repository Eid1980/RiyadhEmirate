using AutoMapper;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Models.InternalPortal.Request.FileManager;
using Emirates.Core.Application.Models.InternalPortal.Response.FileManager;
using Emirates.Core.Application.Models.Response.Nationality;
using Emirates.Core.Domain.Entities;

namespace Emirates.Core.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region CaseType
            CreateMap<CreateCaseTypeDto, CaseType>();
            CreateMap<UpdateCaseTypeDto, CaseType>();

            CreateMap<CaseType, GetCaseTypeDetailsDto>();
            CreateMap<CaseType, GetCaseTypeListDto>();
            #endregion

            #region FileManager
            CreateMap<CreateUploadedFileModel, UploadedFile>();
            CreateMap<UploadedFile, GetUploadedFileModel>();
            #endregion

            #region Nationality
            CreateMap<Nationality, NationalityResponse>();
            #endregion

            #region News
            CreateMap<CreateNewsDto, News>();
            CreateMap<UpdateNewsDto, News>();

            CreateMap<News, GetNewsDetailsDto>();
            CreateMap<News, GetNewsListDto>();
            #endregion

            #region Account
            CreateMap<CreateUserDto, User>();
            CreateMap<User, GetUserDto>()
                .ForMember(dest => dest.NameAr, src => src.MapFrom(m => $"{m.FirstNameAr} {m.SecondNameAr} {m.ThirdNameAr} {m.LastNameAr}"))
                .ForMember(dest => dest.NameEn, src => src.MapFrom(m => $"{m.FirstNameEn} {m.SecondNameEn} {m.ThirdNameEn} {m.LastNameEn}"))
                .ForMember(dest => dest.MaritalStatusName, src => src.MapFrom(m => m.MaritalStatus.NameAr))
                .ForMember(dest => dest.NationalityName, src => src.MapFrom(m => m.Nationality.NameAr))
                .ForMember(dest => dest.GovernorateName, src => src.MapFrom(m => m.Governorate.NameAr));
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


            #endregion

            #region RequestStageLog
            CreateMap<RequestStageLog, GetRequestStageLogsDto>()
                .ForMember(dest => dest.StageName, src => src.MapFrom(m => m.Stage.NameAr))
                .ForMember(dest => dest.CreatedByName, src => src.MapFrom(m => $"{m.CreatedUser.FirstNameAr} {m.CreatedUser.LastNameAr}"))
                .ForMember(dest => dest.CreatedDate, src => src.MapFrom(m => m.CreatedDate.ToString("yyyy-MM-dd")));
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
                .ForMember(dest => dest.PresonName, src => src.MapFrom(m => m.RequestPrisonersService.PresonName));
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
                .ForMember(dest => dest.PresonName, src => src.MapFrom(m => m.RequestPrisonerTempRelease.PresonName));
            CreateMap<RequestPrisonerTempRelease, RequestPrisonerTempReleaseDto>();
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

            #region Service
            CreateMap<CreateServiceDto, Service>();
            CreateMap<UpdateServiceDto, Service>();

            CreateMap<Service, GetServiceDetailsDto>();
            CreateMap<Service, GetServiceListDto>();
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


        }
    }
}
