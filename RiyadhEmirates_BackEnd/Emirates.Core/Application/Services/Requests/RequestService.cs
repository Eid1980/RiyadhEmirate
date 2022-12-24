using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Requests;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.FileManagers;
using Emirates.Core.Application.Shared;
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

        public RequestService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper, IFileManagerService fileManagerService)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
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
            if(request.CreatedBy != changeStageDto.UserId)
                throw new BusinessException("الطلب غير مضاف على نفس المستخدم الحالي برجاء استخدام الطلبات الخاصة بكم فقط");
            if (request.StageId == changeStageDto.StageId)
                throw new BusinessException("تم اتخاذ نفس الاجراء مسبقا");

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
            if (_emiratesUnitOfWork.Complete() > 0)
                return GetResponse(isSuccess: true, message: CustumMessages.SendRequestSuccess(), data: changeStageDto.Id);
                
            return GetResponse(isSuccess: false, message: CustumMessages.SendRequestFailed());

        }
        public IApiResponse ChangeStageAdmin(RequestChangeStageDto changeStageDto)
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
            if (_emiratesUnitOfWork.Complete() > 0)
                return GetResponse(isSuccess: true, message: CustumMessages.SendRequestSuccess(), data: changeStageDto.Id);
            
            return GetResponse(isSuccess: false, message: CustumMessages.SendRequestFailed());
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
                        };
            return GetResponse(data: query.ToList());
        }
        public IApiResponse GetRequestStageLogs(Guid id)
        {
            var requestLogs = _emiratesUnitOfWork.RequestStageLogs.Where(x => x.RequestId.Equals(id) && x.StageId != (int)SystemEnums.Stages.Draft).OrderBy(c => c.CreatedDate).Include(x => x.Stage).Include(x => x.CreatedUser).ToList();
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

        public IApiResponse RequestSearch(SearchModel searchModel)
        {
            var serchResult = DynamicSearch(_emiratesUnitOfWork.Requests.GetQueryable().ProjectTo<GetInboxListDto>(_mapConfig), searchModel)
                .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetInboxListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }

        public IApiResponse GetRequestSmsData(Guid id)
        {
            var request = _emiratesUnitOfWork.Requests.FirstOrDefault(l => l.Id.Equals(id), include => include.CreatedUser, include => include.Service);
            if (request == null)
                return GetResponse();

            var response = _mapper.Map<HandleSMSDto>(request);
            var smsMessage = _emiratesUnitOfWork.ServieNotifications.FirstOrDefault(x => x.ServiceId == request.ServiceId && x.StageId == request.StageId && x.IsActive && x.IsSMS, x => x.ServieNotificationLogs.Where(e => e.EndDate == null));
            if (smsMessage == null)
            {
                smsMessage = _emiratesUnitOfWork.ServieNotifications.FirstOrDefault(x => x.IsDefault && x.StageId == request.StageId && x.IsActive && x.IsSMS, x => x.ServieNotificationLogs.Where(e => e.EndDate == null));
                if (smsMessage != null)
                    response.SmsMessage = smsMessage.ServieNotificationLogs.FirstOrDefault()?.Message;
            }
            var emailMessage = _emiratesUnitOfWork.ServieNotifications.FirstOrDefault(x => x.ServiceId == request.ServiceId && x.StageId == request.StageId && x.IsActive && x.IsEmail, x => x.ServieNotificationLogs.Where(e => e.EndDate == null));
            if (emailMessage == null)
            {
                emailMessage = _emiratesUnitOfWork.ServieNotifications.FirstOrDefault(x => x.IsDefault && x.StageId == request.StageId && x.IsActive && x.IsEmail, x => x.ServieNotificationLogs.Where(e => e.EndDate == null));
                if (emailMessage != null)
                    response.EmailMessage = emailMessage.ServieNotificationLogs.FirstOrDefault()?.Message;
            }
            return GetResponse(data: response);
        }
    }
}
