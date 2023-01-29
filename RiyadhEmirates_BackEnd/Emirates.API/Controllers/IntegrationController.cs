using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using System.Globalization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using static Emirates.Core.Application.Shared.SystemEnums;

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
            // Production
            SMS.RPSMSSoapClient smsClient = new SMS.RPSMSSoapClient(new SMS.RPSMSSoapClient.EndpointConfiguration());
            smsClient.SendSmsAsync(request.MobileNumber, request.SmsBody);

            //// Development
            //SMSReference.RPSMSSoapClient smsClient = new SMSReference.RPSMSSoapClient(new SMSReference.RPSMSSoapClient.EndpointConfiguration());
            //smsClient.SendSmsAsync(request.MobileNumber, request.SmsBody);

            return new ApiResponse { IsSuccess = true , Data = true};
        }
        [HttpPost("SendEmail")]
        public IApiResponse SendEmail(SendEmailRequest request)
        {
            // Production
            Email.emailSoapClient emailClient = new Email.emailSoapClient(new Email.emailSoapClient.EndpointConfiguration());
            emailClient.sendEmailAsync(request.EmailSubject, request.EmailBody, request.Email);

            //// Development
            //EmaiReference.emailSoapClient emailClient = new EmaiReference.emailSoapClient(new EmaiReference.emailSoapClient.EndpointConfiguration());
            //emailClient.sendEmailAsync(request.EmailSubject, request.EmailBody, request.Email);

            return new ApiResponse { IsSuccess = true, Data = true };
        }

        #region Letter Search
        [AllowAnonymous, HttpGet("GetExternalEntityAsync")]
        public async Task<IApiResponse> GetExternalEntityAsync()
        {
            InqueryReference.RPINQUERYSoapClient transaction = new InqueryReference.RPINQUERYSoapClient(new InqueryReference.RPINQUERYSoapClient.EndpointConfiguration());
            var response = await transaction.getExternalEntityAsync((int)Provices.EmirateCourt);
            if (response != null && response.Nodes.Count > 1)
            {
                var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
                var data = await ReadXMLString<ExternalEntityDto>(firstNode);
                return new ApiResponse { IsSuccess = true, Data = data.ExternalEntityTables };
            }
            return new ApiResponse { IsSuccess = false };
        }


        [AllowAnonymous, HttpGet("GetSubExternalEntityAsync/{externalEntity}")]
        public async Task<IApiResponse> GetSubExternalEntityAsync(string externalEntity)
        {
            InqueryReference.RPINQUERYSoapClient transaction = new InqueryReference.RPINQUERYSoapClient(new InqueryReference.RPINQUERYSoapClient.EndpointConfiguration());
            var response = await transaction.getSubExternalEntityAsync(externalEntity, (int)Provices.EmirateCourt);
            if(response != null && response.Nodes.Count > 1)
            {
                var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
                var data = await ReadXMLString<ExternalEntityDto>(firstNode);
                return new ApiResponse { IsSuccess = true, Data = data.ExternalEntityTables };
            }
            return new ApiResponse { IsSuccess = false };
        }


        [AllowAnonymous, HttpPost("GetSubSubExternalEntityAsync")]
        public async Task<IApiResponse> GetSubSubExternalEntityAsync(GetSubSubExternalEntityRequestDto request)
        {
            InqueryReference.RPINQUERYSoapClient transaction = new InqueryReference.RPINQUERYSoapClient(new InqueryReference.RPINQUERYSoapClient.EndpointConfiguration());
            var response = await transaction.getSubSubExternalEntityAsync((int)Provices.EmirateCourt, request.ExternalEntity.ToString(), request.SubExternalEntity.ToString());
            if (response != null && response.Nodes.Count > 1)
            {
                var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
                var data = await ReadXMLString<ExternalEntityDto>(firstNode);
                return new ApiResponse { IsSuccess = true, Data = data.ExternalEntityTables };
            }
            return new ApiResponse { IsSuccess = false };
        }



        [AllowAnonymous, HttpPost("GetLetterBySearchAsync")]
        public async Task<IApiResponse> GetLetterBySearchAsync(LetterAdvancedSearchRequedtDto request)
        {
            InqueryReference.RPINQUERYSoapClient transaction = new InqueryReference.RPINQUERYSoapClient(new InqueryReference.RPINQUERYSoapClient.EndpointConfiguration());
            var response = await transaction.getLetterBySearchAsync(request.ExternalEntity, request.SubExternalEntity, request.SubSubExternalEntity,
                                                                    request.SearchClass, request.IntYear, request.LetterNo, (int)Provices.EmirateCourt);
            if (response == null || response.Nodes.Count <= 1)
                throw new BusinessException("بيانات الطلب غير صحيحة");

            var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
            var data = await ReadXMLString<LetterAdvancedSearchResponseDto>(firstNode);
            await GetSubSubExternalEntity(transaction, 101, 106);
            return new ApiResponse { IsSuccess = true, Data = data.LetterAdvancedSearchResponses };
        }


        #endregion

        [AllowAnonymous, HttpGet("GetTransactionByNumberAsync/{transactionNumber}")]
        public async Task<IApiResponse> GetTransactionByNumberAsync(string transactionNumber)
        {
            await GetExternalEntityAsync();


            InqueryReference.RPINQUERYSoapClient transaction = new InqueryReference.RPINQUERYSoapClient(new InqueryReference.RPINQUERYSoapClient.EndpointConfiguration());
            var response = await transaction.getMoamalahAsync(TransactionTypes.Incoming, TransactionClasses.General, new HijriCalendar().GetYear(DateTime.UtcNow).ToString(), transactionNumber, (int)Provices.EmirateCourt);
            if(response == null || !response.Nodes.Any())
                return new ApiResponse { IsSuccess = false , Data = null };
            var firstNode = response.Nodes[1].Elements().FirstOrDefault().FirstNode.ToString();
            var data = ReadXML<GetTransactionResponseDto>(new StringReader(firstNode));
            if(data == default(GetTransactionResponseDto))
                return new ApiResponse { IsSuccess = false, Data = null };
            if(data.state != 13)
                return new ApiResponse { IsSuccess = false, Data = null };

            //var dddd = await transaction.getMoamalahByIdAsync(data.id.ToString(), (int)Provices.EmirateCourt);
            //var ddd = await transaction.getMoamlahUsingIDAsync("16098285", (int)Provices.EmirateCourt);
            //var dd = await transaction.getExternelOrgByIdAsync(2, 15, -1);


            return new ApiResponse { IsSuccess = true, Data = data };
        }


        [AllowAnonymous, HttpPost("GetExternelOrgById")]
        public async Task<IApiResponse> GetExternelOrgById()
        {
            InqueryReference.RPINQUERYSoapClient inq = new InqueryReference.RPINQUERYSoapClient(new InqueryReference.RPINQUERYSoapClient.EndpointConfiguration());
            //var xx = await inq.getExternelOrgByIdAsync();
            var xx101 = await inq.getMoamalahAsync("2","1","1444","123",101);
            var xx1 = await inq.getMoamalahAsync("2","1","1444","123",1);
            var xx2 = await inq.getMoamalahAsync("2","1","1444","123",2);
            var xx3 = await inq.getMoamalahAsync("2","1","1444","123",3);
            var xxx = await inq.getMoamalahAsync("","","","4",3);
            return new ApiResponse { IsSuccess = true, Data = true };
        }

        private TResponse ReadXML<TResponse>(StringReader input)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TResponse));
                return (TResponse)serializer.Deserialize(input);
            }
            catch (Exception ex)
            {
                return default(TResponse);
            }
        }


        private async Task<TResponse> ReadXMLString<TResponse>(string input)
        {
            try
            {
                var serializer = new XmlSerializer(typeof(TResponse));
                TResponse response;
                using (TextReader reader = new StringReader(input))
                {
                    response = (TResponse)serializer.Deserialize(reader);
                }
                return response;
            }
            catch (Exception ex)
            {
                return default(TResponse);
            }
        }
        private async Task GetSubSubExternalEntity(InqueryReference.RPINQUERYSoapClient transaction, int externalEntity, int subExternalEntity)
        {
            var response = await transaction.getAllExternelEntitiesAsync(externalEntity, subExternalEntity, -1);
        }
    }
}
