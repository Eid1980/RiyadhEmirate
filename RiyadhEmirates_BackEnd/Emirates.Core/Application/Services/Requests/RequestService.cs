using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Requests;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Helpers;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.InternalPortal.FileManager;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using X.PagedList;

namespace Emirates.Core.Application.Services.Requests
{
    public class RequestService : BaseService, IRequestService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;

        public RequestService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper, IFileManagerService fileManagerService)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _fileManagerService = fileManagerService;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(Guid id)
        {
            var request = _emiratesUnitOfWork.Requests.FirstOrDefault(l => l.Id.Equals(id), includes: include => include.Stage);
            if (request == null)
                throw new NotFoundException(typeof(Request).Name);
            return GetResponse(data: _mapper.Map<GetRequestDetailsDto>(request));
        }
        public IApiResponse ChangeStage(RequestChangeStageDto changeStageDto)
        {
            Request request = _emiratesUnitOfWork.Requests.FirstOrDefault(l => l.Id.Equals(changeStageDto.Id));
            if (request == null)
                throw new NotFoundException(typeof(Request).Name);
            if(request.StageId == changeStageDto.StageId)
                throw new BusinessException("تم اتخاذ نفس الاجراء مسبقا");

            string message = CustumMessages.SendRequestSuccess();
            switch (changeStageDto.StageId)
            {
                case (int)SystemEnums.Stages.NewRequest:
                    message = CustumMessages.SendRequestSuccess();
                    break;
                case (int)SystemEnums.Stages.UnderProcessing:
                    // Send Request To Shamel
                    message = CustumMessages.MsgSuccess("تم ارسال الطلب الى نظام شامل");
                    break;
                case (int)SystemEnums.Stages.RequestRejectedFromAdmin:
                    message = CustumMessages.MsgSuccess("تم رفض الطلب من قبل مدير النظام");
                    break;
                case (int)SystemEnums.Stages.CompleteDataFromRequester:
                    message = CustumMessages.MsgSuccess("تم ارجاع الطلب الى المستفيد");
                    break;
                case (int)SystemEnums.Stages.RequestApproved:
                    message = CustumMessages.MsgSuccess("تمت الموافقة على الطلب");
                    break;
                case (int)SystemEnums.Stages.RequestRejected:
                    message = CustumMessages.MsgSuccess("تم رفض الطلب");
                    break;
                default:
                    break;
            }

            request.StageId = changeStageDto.StageId;
            var requestStageLogOld = _emiratesUnitOfWork.RequestStageLogs.FirstOrDefault(x => x.RequestId.Equals(changeStageDto.Id) && x.EndDate == null);
            if (requestStageLogOld != null)
                requestStageLogOld.EndDate = DateTime.Now;

            RequestStageLog requestStageLog = new RequestStageLog
            {
                RequestId = request.Id,
                StageId = changeStageDto.StageId,
                Notes = changeStageDto.Notes
            };
            _emiratesUnitOfWork.RequestStageLogs.Add(requestStageLog);
            _emiratesUnitOfWork.Complete();

            // Send SMS, Email

            return GetResponse(message: message, data: changeStageDto.Id);
        }

        public IApiResponse GetAttachments(Guid id)
        {
            var request = _emiratesUnitOfWork.Requests.FirstOrDefault(l => l.Id.Equals(id), includes: include => include.Stage);
            if (request == null)
                throw new NotFoundException(typeof(Request).Name);
            if (!request.Stage.CanEdit)
                throw new BusinessException("لا يمكن التعديل علي مرفقات الطلب في الوقت الحالي");

            List<GetAttachmentsDto> requestAttachments = new List<GetAttachmentsDto>();
            var requestAttachmentTypes = _emiratesUnitOfWork.RequestAttachmentTypes.Where(x => x.IsActive && x.ServiceId.Equals(request.ServiceId)).ToList();
            if (requestAttachmentTypes.Any())
            {
                var uploadedFiles = _emiratesUnitOfWork.UploadedFiles.Where(x => x.EntityId.Equals(id.ToString())).ToList();
                requestAttachmentTypes.ForEach(item =>
                {
                    var addedItem = uploadedFiles.FirstOrDefault(x => x.SubEntityName.Equals(item.Id.ToString()));
                    if (addedItem == null)
                        requestAttachments.Add(new GetAttachmentsDto
                        {
                            AttachmentTypeId = item.Id,
                            AttachmentName = item.NameAr,
                            ExtentionAllowed = item.ExtentionAllowed,
                            MaxFileSize = item.MaxFileSize,
                            AttachmentIsRequired = item.IsRequired,
                            IsAdded = false
                        });
                    else
                        requestAttachments.Add(new GetAttachmentsDto
                        {
                            Id = addedItem.Id,
                            AttachmentTypeId = item.Id,
                            AttachmentName = item.NameAr,
                            ExtentionAllowed = item.ExtentionAllowed,
                            MaxFileSize = item.MaxFileSize,
                            AttachmentIsRequired = item.IsRequired,
                            FileDescription = addedItem.OriginalName,
                            IsAdded = true
                        });
                });
            }
            return GetResponse(data: requestAttachments);
        }
        public IApiResponse GetRequestAttachments(Guid id)
        {
            var uploadedFiles = _emiratesUnitOfWork.UploadedFiles.Where(x => x.EntityId.Equals(id.ToString()));
            var requestAttachmentTypes = _emiratesUnitOfWork.RequestAttachmentTypes.Where(x => x.IsActive);
            var query = from file in uploadedFiles
                        join type in requestAttachmentTypes on file.SubEntityName equals type.Id.ToString()
                        select new GetRequestAttachmentsDto
                        {
                            Id = file.Id,
                            AttachmentName = type.NameAr,
                            FileName = file.OriginalName,
                            //Image = _fileManagerService.GetBase64File(id, file.EntityName)
                        };
            return GetResponse(data: query.ToList());
        }
        public IApiResponse GetRequestStageLogs(Guid id)
        {
            var requestLogs = _emiratesUnitOfWork.RequestStageLogs.Where(x => x.RequestId.Equals(id)).OrderBy(c => c.CreatedDate).Include(x => x.Stage).Include(x => x.CreatedUser).ToList();
            return GetResponse(data: _mapper.Map<List<GetRequestStageLogsDto>>(requestLogs));
        }

        public IApiResponse MyRequests(SearchModel searchModel)
        {
            var serchResult = DynamicSearch(_emiratesUnitOfWork.Requests.GetQueryable().ProjectTo<GetMyRequestListDto>(_mapConfig), searchModel)
                .ToPagedList(searchModel.PageNumber, searchModel.PageSize);
            return GetResponse(data: new ListPageModel<GetMyRequestListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse Inbox(SearchModel searchModel)
        {
            searchModel.SearchFields.Add(new SearchField { FieldName = "StageId", Operator = "Equal", Value = ((int)SystemEnums.Stages.NewRequest).ToString() });
            var serchResult = DynamicSearch(_emiratesUnitOfWork.Requests.GetQueryable().ProjectTo<GetInboxListDto>(_mapConfig), searchModel)
                .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetInboxListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }

        public IApiResponse GetElectronicCouncilRequests(SearchModel searchModel)
        {
            var serchResult = DynamicSearch(_emiratesUnitOfWork.Requests
                .Include(r => r.Stage).Include(r => r.RequestElectronicBoard).Include(r=>r.RequestElectronicBoard.RequestType)
                .ProjectTo<GetElectronicConcilInboxDto>(_mapConfig), searchModel)
                .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetElectronicConcilInboxDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }

        public IApiResponse InboxShamel(SearchModel searchModel)
        {
            searchModel.SearchFields.Add(new SearchField { FieldName = "StageId", Operator = "Equal", Value = ((int)SystemEnums.Stages.UnderProcessing).ToString() });
            var serchResult = DynamicSearch(_emiratesUnitOfWork.Requests.GetQueryable().ProjectTo<GetInboxListDto>(_mapConfig), searchModel)
                .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetInboxListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
    }
}
