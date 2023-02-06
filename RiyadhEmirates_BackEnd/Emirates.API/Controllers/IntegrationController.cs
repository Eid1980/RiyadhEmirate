using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Services.Shared;
using Emirates.Core.Application.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System.Data;
using System.Globalization;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using X.PagedList;
using static Emirates.Core.Application.Shared.SystemEnums;

namespace Emirates.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationController : BaseController
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IConfiguration _config;

        public IntegrationController(IMemoryCache memoryCache, IConfiguration config, ILocalizationService localizationService) : base(localizationService)
        {
            _memoryCache = memoryCache;
            _config = config;
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
            string cacheName = "ExternalEntities";
            List<EntityTableDto> externalEntities = null;
            if (!_memoryCache.TryGetValue(cacheName, out externalEntities))
            {
                InqueryReference.RPINQUERYSoapClient transaction = new InqueryReference.RPINQUERYSoapClient(new InqueryReference.RPINQUERYSoapClient.EndpointConfiguration());
                var response = await transaction.getExternalEntityAsync((int)Provices.EmirateCourt);
                if (response != null && response.Nodes.Count > 1)
                {
                    var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
                    var data = await ReadXMLString<ExternalEntityDto>(firstNode);
                    if(data != null && data.ExternalEntityTables.Any())
                    {
                        externalEntities = data.ExternalEntityTables;
                        int cacheMinutes = 0;
                        int.TryParse(_config.GetSection("AppSettings:CacheMinutes").Value, out cacheMinutes);
                        var options = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(cacheMinutes));
                        _memoryCache.Set(cacheName, externalEntities, options);
                    }
                }
            }
            return new ApiResponse { IsSuccess = true, Data = externalEntities };
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
            var responseData = new List<LetterAdvancedSearchResponse>();
            foreach (var item in data.LetterAdvancedSearchResponses)
            {
                item.SubExternalEntityName = await GetIncomingEntityNameFull(transaction, item.ExternalEntity, item.SubExternalEntity, item.SubSubExternalEntity);
                responseData.Add(item);
            }
            return new ApiResponse { IsSuccess = true, Data = responseData };
        }

        [AllowAnonymous, HttpGet("GetTransactionByIdAsync/{id}")]
        public async Task<IApiResponse> GetTransactionByIdAsync(string id)
        {
            InqueryReference.RPINQUERYSoapClient transaction = new InqueryReference.RPINQUERYSoapClient(new InqueryReference.RPINQUERYSoapClient.EndpointConfiguration());
            var response = await GetTransactionById(transaction, id);
            var responseData = new GetTransactionResponseDto {
                IncomingNumber = response.IntNumber,
                IncomingDate = response.StartDate
            };
            if (response.State == 13)
            {
                responseData.StateName = "صدرت";
                var transactionData = await GetTransactionByRefId(transaction, response.Id);
                if(transactionData != null)
                {
                    responseData.OutgoingNumber = transactionData.IntNumber;
                    responseData.OutgoingDate = transactionData.StartDate;
                    responseData.OutgoingEntityName = await GetIncomingEntityName(transaction, transactionData.ExternalEntity, transactionData.SubExternalEntity, transactionData.SubSubExternalEntity);
                }
                else
                    responseData.IncomingEntityName = await GetIncomingEntityName(transaction, response.ExternalEntity, response.SubExternalEntity, response.SubSubExternalEntity);
            }
            else if (response.State == 14)
            {
                responseData.StateName = "تم حفظ المعاملة";
                responseData.IncomingEntityName = await GetIncomingEntityName(transaction, response.ExternalEntity, response.SubExternalEntity, response.SubSubExternalEntity);
            }
            else
            {
                responseData.StateName = "تحت الإجراء";
                responseData.IncomingEntityName = await GetIncomingEntityName(transaction, response.ExternalEntity, response.SubExternalEntity, response.SubSubExternalEntity);
            }
            return new ApiResponse { IsSuccess = true, Data = responseData };
        }
        #endregion


        [AllowAnonymous, HttpPost("GetTransactionAsync")]
        public async Task<IApiResponse> GetTransactionAsync(TransactionRequedtDto request)
        {
            InqueryReference.RPINQUERYSoapClient transaction = new InqueryReference.RPINQUERYSoapClient(new InqueryReference.RPINQUERYSoapClient.EndpointConfiguration());
            var response = await transaction.getMoamalahAsync(request.TransactionType, request.TransactionClass, request.IntYear,
                                                              request.IntNumber, (int)Provices.EmirateCourt);
            if (response == null || response.Nodes.Count <= 1)
                throw new BusinessException("بيانات الطلب غير صحيحة");

            var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
            var data = (await ReadXMLString<TransactionResponseDto>(firstNode)).TransactionResponses.FirstOrDefault();
            if (data == null)
                throw new BusinessException("بيانات الطلب غير صحيحة");

            var responseData = new GetTransactionResponseDto();
            if (data.State == 13)
            {
                responseData.StateName = "صدرت";
                if (request.TransactionType == SystemEnums.TransactionTypes.Incoming)
                {
                    var transactionData = await GetTransactionByRefId(transaction, data.Id);
                    responseData.IncomingNumber = data.IntNumber;
                    responseData.IncomingDate = data.StartDate;
                    responseData.OutgoingNumber = transactionData.IntNumber;
                    responseData.OutgoingDate = transactionData.StartDate;
                    responseData.IncomingEntityName = await GetIncomingEntityName(transaction, transactionData.ExternalEntity, transactionData.SubExternalEntity, transactionData.SubSubExternalEntity);
                }
                else
                {
                    responseData.OutgoingNumber = data.IntNumber;
                    responseData.OutgoingDate = data.StartDate;
                    responseData.OutgoingEntityName = await GetIncomingEntityName(transaction, data.ExternalEntity, data.SubExternalEntity, data.SubSubExternalEntity);
                }
            }
            else if (data.State == 14)
            {
                responseData.StateName = "تم حفظ المعاملة";
                if (request.TransactionType == SystemEnums.TransactionTypes.Incoming)
                {
                    responseData.CanFeedback = true;
                    responseData.IncomingNumber = data.IntNumber;
                    responseData.IncomingDate = data.StartDate;
                    responseData.IncomingEntityName = await GetIncomingEntityName(transaction, data.ExternalEntity, data.SubExternalEntity, data.SubSubExternalEntity);
                }
                else
                {
                    responseData.OutgoingNumber = data.IntNumber;
                    responseData.OutgoingDate = data.StartDate;
                    responseData.OutgoingEntityName = await GetIncomingEntityName(transaction, data.ExternalEntity, data.SubExternalEntity, data.SubSubExternalEntity);
                }
                if (!string.IsNullOrEmpty(data.LetterNo))
                {
                    responseData.LetterNo = data.LetterNo;
                    responseData.LetterDate = data.LetterDate;
                }
            }
            else
            {
                responseData.StateName = "تحت الإجراء";
                if (request.TransactionType == SystemEnums.TransactionTypes.Incoming)
                {
                    responseData.CanFeedback = true;
                    responseData.IncomingNumber = data.IntNumber;
                    responseData.IncomingDate = data.StartDate;
                    responseData.IncomingEntityName = await GetIncomingEntityName(transaction, data.ExternalEntity, data.SubExternalEntity, data.SubSubExternalEntity);
                }
                else
                {
                    responseData.OutgoingNumber = data.IntNumber;
                    responseData.OutgoingDate = data.StartDate;
                    responseData.OutgoingEntityName = await GetIncomingEntityName(transaction, data.ExternalEntity, data.SubExternalEntity, data.SubSubExternalEntity);
                }
                if (!string.IsNullOrEmpty(data.LetterNo))
                {
                    responseData.LetterNo = data.LetterNo;
                    responseData.LetterDate = data.LetterDate;
                }
            }
            return new ApiResponse { IsSuccess = true, Data = responseData };
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
        private async Task<string> GetIncomingEntityNameFull(InqueryReference.RPINQUERYSoapClient transaction, string externalEntity, string subExternalEntity, string subSubExternalEntity)
        {
            string subExternalEntityName = "";
            if(!string.IsNullOrEmpty(externalEntity))
            {
                var externalEntities = (List<EntityTableDto>)(await GetExternalEntityAsync()).Data;
                subExternalEntityName += externalEntities.Where(x => x.Id.ToString() == externalEntity).FirstOrDefault()?.Name;
            }
            if (!string.IsNullOrEmpty(subExternalEntity))
            {
                var response = await transaction.getSubExternalEntityAsync(externalEntity, (int)Provices.EmirateCourt);
                if (response != null && response.Nodes.Count > 1)
                {
                    var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
                    var data = await ReadXMLString<ExternalEntityDto>(firstNode);
                    subExternalEntityName += $" - {data.ExternalEntityTables.Where(x => x.Id.ToString() == subExternalEntity).FirstOrDefault()?.Name}";
                }
            }
            if (!string.IsNullOrEmpty(subSubExternalEntity))
            {
                var response = await transaction.getSubSubExternalEntityAsync((int)Provices.EmirateCourt, externalEntity, subExternalEntity);
                if (response != null && response.Nodes.Count > 1)
                {
                    var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
                    var data = await ReadXMLString<ExternalEntityDto>(firstNode);
                    subExternalEntityName += $" - {data.ExternalEntityTables.Where(x => x.Id.ToString() == subSubExternalEntity).FirstOrDefault()?.Name}";
                }
            }
            return subExternalEntityName;
        }
        private async Task<string> GetIncomingEntityName(InqueryReference.RPINQUERYSoapClient transaction, string externalEntity, string subExternalEntity, string subSubExternalEntity)
        {
            if (!string.IsNullOrEmpty(subSubExternalEntity))
            {
                var response = await transaction.getSubSubExternalEntityAsync((int)Provices.EmirateCourt, externalEntity, subExternalEntity);
                if (response != null && response.Nodes.Count > 1)
                {
                    var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
                    var data = await ReadXMLString<ExternalEntityDto>(firstNode);
                    return data.ExternalEntityTables.Where(x => x.Id.ToString() == subSubExternalEntity).FirstOrDefault()?.Name;
                }
            }
            if (!string.IsNullOrEmpty(subExternalEntity))
            {
                var response = await transaction.getSubExternalEntityAsync(externalEntity, (int)Provices.EmirateCourt);
                if (response != null && response.Nodes.Count > 1)
                {
                    var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
                    var data = await ReadXMLString<ExternalEntityDto>(firstNode);
                    return data.ExternalEntityTables.Where(x => x.Id.ToString() == subExternalEntity).FirstOrDefault()?.Name;
                }
            }
            if (!string.IsNullOrEmpty(externalEntity))
            {
                var externalEntities = (List<EntityTableDto>)(await GetExternalEntityAsync()).Data;
                return externalEntities.Where(x => x.Id.ToString() == externalEntity).FirstOrDefault()?.Name;
            }
            return "";
        }
        private async Task<TransactionById> GetTransactionByRefId(InqueryReference.RPINQUERYSoapClient transaction, string refId)
        {
            var response = await transaction.getMoamalahByRefIDAsync(refId, (int)Provices.EmirateCourt);
            if (response == null || response.Nodes.Count <= 1)
                return null;

            var firstNode = response.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
            var data = (await ReadXMLString<TransactionByRefIdDto>(firstNode)).TransactionByRefIds.FirstOrDefault();
            if(data != null && !string.IsNullOrEmpty(data.CorrespondanceId))
            {
                var transactionResponse = await transaction.getMoamlahByIDAsync(data.CorrespondanceId, (int)Provices.EmirateCourt);
                if (transactionResponse == null || transactionResponse.Nodes.Count <= 1)
                    return null;

                var transactionFirstNode = transactionResponse.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
                var transactionData = (await ReadXMLString<TransactionByIdDto>(transactionFirstNode)).TransactionByIds.FirstOrDefault();
                return transactionData;
            }
            return null;
        }
        private async Task<TransactionById> GetTransactionById(InqueryReference.RPINQUERYSoapClient transaction, string id)
        {
            var transactionResponse = await transaction.getMoamlahByIDAsync(id, (int)Provices.EmirateCourt);
            if (transactionResponse == null || transactionResponse.Nodes.Count <= 1)
                throw new BusinessException("بيانات الطلب غير صحيحة");

            var transactionFirstNode = transactionResponse.Nodes[1].Elements().ToList().FirstOrDefault().ToString();
            var transactionData = (await ReadXMLString<TransactionByIdDto>(transactionFirstNode)).TransactionByIds.FirstOrDefault();
            return transactionData;
        }
    }
}
