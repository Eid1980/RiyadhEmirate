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
            var response = new GetServiceRateDto
            {
                ServiceRate = serviceRates.Count > 0 ? serviceRates.Sum(x => x.StarsCount) / serviceRates.Count : 0,
                CanRate = serviceRates.Count > 0 ? !serviceRates.Where(x => x.CreatedBy.Equals(requestDto.UserId)).Any() : true
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

    }
}
