using Emirates.API.Controllers;
using Emirates.API.Filters;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.Requests;
using Emirates.Core.Application.Services.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Edraak.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : BaseController, IRequestService
    {
        private readonly IRequestService _requestService;

        public RequestController(IRequestService requestService,
            ILocalizationService localizationService) : base(localizationService)
        {
            _requestService = requestService;
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
            return _requestService.ChangeStage(changeStageDto);
        }

        [HttpPost("ChangeStageAdmin")]
        [AuthorizeAdmin((int)SystemEnums.Roles.SystemAdmin, (int)SystemEnums.Roles.RequestReview, (int)SystemEnums.Roles.ShamelRequestReview)]
        public IApiResponse ChangeStageAdmin(RequestChangeStageDto changeStageDto)
        {
            return _requestService.ChangeStageAdmin(changeStageDto);
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

    }
}
