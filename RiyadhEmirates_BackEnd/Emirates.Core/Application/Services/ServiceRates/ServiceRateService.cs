using AutoMapper;
using Emirates.Core.Domain.Interfaces;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Dtos.ServiceRates;

namespace Emirates.Core.Application.Services.ServiceRates
{
    public class ServiceRateService : BaseService, IServiceRateService
    {
        private readonly IMapper _mapper;
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IConfigurationProvider _mapConfig;

        public ServiceRateService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _emiratesUnitOfWork = emiratesUnitOfWork;
        }

        public IApiResponse GetByServiceId(int serviceId)
        {
            throw new NotImplementedException();
        }
        public IApiResponse GetServiceRate(int serviceId)
        {
            var serviceRates = _emiratesUnitOfWork.ServiceRates.Where(x => x.ServiceId.Equals(serviceId)).ToList();
            var response = serviceRates.Sum(x => x.StarsCount) / serviceRates.Count;
            return GetResponse(data: response);
        }
        public IApiResponse GetServiceRateToUser(GetServiceRateToUserRequestDto requestDto)
        {
            var serviceRates = _emiratesUnitOfWork.ServiceRates.Where(x => x.ServiceId.Equals(requestDto.ServiceId)).ToList();
            double rateValue = serviceRates.Count > 0 ? (double)serviceRates.Sum(x => x.StarsCount) / (double)serviceRates.Count : 0;
            var response = new GetServiceRateDto
            {
                ServiceRate = Convert.ToInt32(rateValue),
                CanRate = requestDto.UserId == 0 ? false : serviceRates.Count > 0 ? !serviceRates.Where(x => x.CreatedBy.Equals(requestDto.UserId)).Any() : true,
                RateCout = serviceRates.Count,
                LastRateDate =  serviceRates.Count > 0 ? serviceRates.OrderByDescending(x => x.CreatedDate).FirstOrDefault().CreatedDate.ToString("yyyy-MM-dd hh:mm") : "",
                ServiceRatePercentage = rateValue,
                RatePercentage = GetRatePercentage(rateValue)
            };
            return GetResponse(data: response);
        }
        public IApiResponse CanRate(int serviceId)
        {
            throw new NotImplementedException();
        }
        public IApiResponse Create(CreateServiceRateDto createModel)
        {
            var serviceRate = _mapper.Map<Domain.Entities.ServiceRate>(createModel);
            var addedModel = _emiratesUnitOfWork.ServiceRates.Add(serviceRate);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.MsgSuccess("تم تقييم الخدمة بنجاح شكرا لك"), data: addedModel.Id);
        }

        private string GetRatePercentage(double rate)
        {
            if (rate >= 0 && rate < 1)
                return "ضعيف";
            else if (rate >= 1 && rate < 2)
                return "مقبول";
            else if (rate >= 2 && rate < 3)
                return "جيد";
            else if (rate >= 3 && rate < 4)
                return "جيد جدا";
            else if (rate >= 4 && rate <= 5)
                return "ممتاز";
            else
                return "";
        }

    }
}
