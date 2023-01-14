using Emirates.API.Controllers;
using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Services.Requests;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Edraak.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : BaseController, IRequestService
    {
        private readonly IRequestService _requestService;
        private readonly IConfiguration _config;

        public RequestController(IRequestService requestService, IConfiguration config,
            ILocalizationService localizationService) : base(localizationService)
        {
            _requestService = requestService;
            _config = config;
        }


        [HttpGet("GetById/{id}")]
        public IApiResponse GetById(Guid id)
        {
            return _requestService.GetById(id);
        }

        [HttpPost("ChangeStage")]
        public IApiResponse ChangeStage(RequestChangeStageDto changeStageDto)
        {
            changeStageDto.UserId = UserId;
            changeStageDto.StageId = (int)SystemEnums.Stages.NewRequest;
            var response = _requestService.ChangeStage(changeStageDto);
            if (response.IsSuccess)
                HandleNotifications(changeStageDto.Id);
            return response;
        }

        [HttpPost("ChangeStageAdmin")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.RequestReview, (int)SystemEnums.Roles.ShamelRequestReview)]
        public IApiResponse ChangeStageAdmin(RequestChangeStageDto changeStageDto)
        {
            var response = _requestService.ChangeStageAdmin(changeStageDto);
            if (response.IsSuccess)
                HandleNotifications(changeStageDto.Id);
            return response;
        }


        [HttpGet("GetAttachments/{id}")]
        public IApiResponse GetAttachments(Guid id)
        {
            return _requestService.GetAttachments(id);
        }

        [HttpGet("GetRequestAttachments/{id}")]
        public IApiResponse GetRequestAttachments(Guid id)
        {
            return _requestService.GetRequestAttachments(id);
        }

        [HttpGet("GetRequestStageLogs/{id}")]
        public IApiResponse GetRequestStageLogs(Guid id)
        {
            return _requestService.GetRequestStageLogs(id);
        }


        [HttpPost("MyRequests")]
        public IApiResponse MyRequests(SearchModel searchModel)
        {
            searchModel.SearchFields.Add(new SearchField { FieldName = "CreatedBy", Operator = "Equal", Value = UserId.ToString() });
            return _requestService.MyRequests(searchModel);
        }
        [HttpPost("Inbox")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.RequestReview)]
        public IApiResponse Inbox(SearchModel searchModel)
        {
            return _requestService.Inbox(searchModel);
        }

        [HttpPost("electroniccouncil/inbox")]
        public IApiResponse GetElectronicCouncilRequests(SearchModel searchModel)
        {
            return _requestService.GetElectronicCouncilRequests(searchModel);
        }

        [HttpPost("InboxShamel")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.ShamelRequestReview)]
        public IApiResponse InboxShamel(SearchModel searchModel)
        {
            return _requestService.InboxShamel(searchModel);
        }

        [HttpPost("RequestSearch")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.RequestReview, (int)SystemEnums.Roles.ShamelRequestReview)]
        public IApiResponse RequestSearch(SearchModel searchModel)
        {
            return _requestService.RequestSearch(searchModel);
        }

        [HttpGet("GetRequestSmsData/{id}")]
        public IApiResponse GetRequestSmsData(Guid id)
        {
            return _requestService.GetRequestSmsData(id);
        }

        private void HandleNotifications(Guid requestId)
        {
            var request = (HandleSMSDto)_requestService.GetRequestSmsData(requestId).Data;
            if (request != null)
            {
                bool sendSMS = Convert.ToBoolean(_config.GetSection("AppSettings:SendSMS").Value);
                bool sendEmail = Convert.ToBoolean(_config.GetSection("AppSettings:SendEmail").Value);
                //switch (request.StageId)
                //{
                //    case (int)SystemEnums.Stages.NewRequest:
                //        messageBody = $"عزيزي المستفيد نفيدكم بتقديم طلبكم رقم ({request.RequestNumber}) بنجاح وسيتم اشعاركم في حالة الرد على الطلب.";
                //        break;
                //    case (int)SystemEnums.Stages.CompleteDataFromRequester:
                //        messageBody = $"عزيزي المستفيد نفيدكم بارجاع طلبكم رقم ({request.RequestNumber}) فضلا مراجعة الملاحظات واعادة ارسال الطلب.";
                //        break;
                //    case (int)SystemEnums.Stages.UnderProcessing:
                //        messageBody = $"عزيزي المستفيد نفيدكم بأن طلبكم رقم ({request.RequestNumber}) قيد المراجعة.";
                //        break;
                //    case (int)SystemEnums.Stages.RequestRejectedFromAdmin:
                //    case (int)SystemEnums.Stages.RequestRejected:
                //        messageBody = $"عزيزي المستفيد نفيدكم بأنه تم رفض طلبكم رقم ({request.RequestNumber}) ويمكنكم الاطلاع على سبب الرفض من شاشة طلباتي.";
                //        break;
                //    case (int)SystemEnums.Stages.RequestApproved:
                //        messageBody = $"عزيزي المستفيد نفيدكم بأنه تمت  الموافقة على طلبكم  ({request.RequestNumber}).";
                //        break;
                //    default:
                //        messageBody = "";
                //        break;
                //}

                var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                if (sendSMS && request.SendNotification && !string.IsNullOrEmpty(request.MobileNumber) && !string.IsNullOrEmpty(request.SmsMessage))
                {
                    if (environment == Environments.Production)
                    {
                        request.SmsMessage = request.SmsMessage.Replace("رقم الطلب", request.RequestNumber);
                        SMS.RPSMSSoapClient smsClient = new SMS.RPSMSSoapClient(new SMS.RPSMSSoapClient.EndpointConfiguration());
                        smsClient.SendSmsAsync(request.MobileNumber, request.SmsMessage);
                    }
                    else
                    {
                        request.SmsMessage = request.SmsMessage.Replace("رقم الطلب", request.RequestNumber);
                        SMSReference.RPSMSSoapClient smsClient = new SMSReference.RPSMSSoapClient(new SMSReference.RPSMSSoapClient.EndpointConfiguration());
                        smsClient.SendSmsAsync(request.MobileNumber, request.SmsMessage);
                    }
                }
                if (sendEmail && request.SendNotification && !string.IsNullOrEmpty(request.Email) && !string.IsNullOrEmpty(request.EmailMessage))
                {
                    if (environment == Environments.Production)
                    {
                        request.EmailMessage = request.EmailMessage.Replace("رقم الطلب", request.RequestNumber);
                        Email.emailSoapClient emailClient = new Email.emailSoapClient(new Email.emailSoapClient.EndpointConfiguration());
                        emailClient.sendEmailAsync("امارة منطقة الرياض - الطلبات", request.EmailMessage, request.Email);
                    }
                    else
                    {
                        request.EmailMessage = request.EmailMessage.Replace("رقم الطلب", request.RequestNumber);
                        EmaiReference.emailSoapClient emailClient = new EmaiReference.emailSoapClient(new EmaiReference.emailSoapClient.EndpointConfiguration());
                        emailClient.sendEmailAsync("امارة منطقة الرياض - الطلبات", request.EmailMessage, request.Email);
                    }
                }
            }
        }

    }
}
