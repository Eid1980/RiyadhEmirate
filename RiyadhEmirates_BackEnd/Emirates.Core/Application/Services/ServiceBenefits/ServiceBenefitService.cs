using AutoMapper;
using Emirates.Core.Application.Dtos.ServiceBenefits;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;

namespace Emirates.Core.Application.Services.ServiceBenefits
{
    public class ServiceBenefitService : BaseService, IServiceBenefitService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        public ServiceBenefitService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
        }

        public IApiResponse GetAllCountByServiceId(int serviceId)
        {
            var count = _emiratesUnitOfWork.ServiceBenefits.Where(x => x.ServiceId.Equals(serviceId)).Count();
            return GetResponse(data: count);
        }
        public IApiResponse GetBenefitCountByServiceId(int serviceId)
        {
            var count = _emiratesUnitOfWork.ServiceBenefits.Where(x => x.ServiceId.Equals(serviceId) && x.IsBenefit).Count();
            return GetResponse(data: count);
        }
        public IApiResponse Create(CreateServiceBenefitDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.ServiceBenefits.Add(_mapper.Map<ServiceBenefit>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
    }
}
