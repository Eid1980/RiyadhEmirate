using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationController : BaseController
    {
        public IntegrationController(ILocalizationService localizationService) : base(localizationService)
        {
        }

        [HttpPost("SendSMS")]
        public IApiResponse SendSMS(SendSMSRequest request)
        {
            if (IsProductionEnvironment())
            {
                SMS.RPSMSSoapClient smsClient = new SMS.RPSMSSoapClient(new SMS.RPSMSSoapClient.EndpointConfiguration());
                smsClient.SendSmsAsync(request.MobileNumber, request.SmsBody);
            }
            else
            {
                SMSReference.RPSMSSoapClient smsClient = new SMSReference.RPSMSSoapClient(new SMSReference.RPSMSSoapClient.EndpointConfiguration());
                smsClient.SendSmsAsync(request.MobileNumber, request.SmsBody);
            }

            return new ApiResponse { IsSuccess = true , Data = true};
        }
        [HttpPost("SendEmail")]
        public IApiResponse SendEmail(SendEmailRequest request)
        {
            if (IsProductionEnvironment())
            {
                Email.emailSoapClient emailClient = new Email.emailSoapClient(new Email.emailSoapClient.EndpointConfiguration());
                emailClient.sendEmailAsync(request.EmailSubject, request.EmailBody, request.Email);
            }
            else
            {
                EmaiReference.emailSoapClient emailClient = new EmaiReference.emailSoapClient(new EmaiReference.emailSoapClient.EndpointConfiguration());
                emailClient.sendEmailAsync(request.EmailSubject, request.EmailBody, request.Email);
            }
            return new ApiResponse { IsSuccess = true, Data = true };
        }

        private bool IsProductionEnvironment()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            return environment == Environments.Production;
        }
        
    }
}
