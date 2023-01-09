using EmaiReference;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSReference;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationController : ControllerBase//BaseController
    {
        public IntegrationController(ILocalizationService localizationService) //: base(localizationService)
        {
        }

        [HttpPost("SendSMS")]
        public IApiResponse SendSMS(SendSMSRequest request)
        {
            RPSMSSoapClient smsClient = new RPSMSSoapClient(new RPSMSSoapClient.EndpointConfiguration());
            //RPSMSSoapClientProd smsClient = new RPSMSSoapClientProd(new RPSMSSoapClientProd.EndpointConfiguration());
            smsClient.SendSmsAsync(request.MobileNumber, request.SmsBody);
            return new ApiResponse { IsSuccess = true , Data = true};
        }
        [HttpPost("SendEmail")]
        public IApiResponse SendEmail(SendEmailRequest request)
        {
            emailSoapClient emailClient = new emailSoapClient(new emailSoapClient.EndpointConfiguration());
            emailClient.sendEmailAsync(request.EmailSubject, request.EmailBody, request.Email);
            return new ApiResponse { IsSuccess = true, Data = true };
        }
        
    }
}
