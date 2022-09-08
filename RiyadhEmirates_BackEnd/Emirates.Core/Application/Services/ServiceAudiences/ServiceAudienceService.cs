using AutoMapper;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Emirates.Core.Application.Services.ServiceAudiences
{
    public class ServiceAudienceService : BaseService, IServiceAudienceService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        public ServiceAudienceService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
        }
        public IApiResponse GetByServiceId(int serviceId)
        {
            var serviceAudiences = _emiratesUnitOfWork.ServiceAudiences.Where(l => l.ServiceId.Equals(serviceId)).Include(x => x.Audience).ToList();
            var mappedModel = _mapper.Map<List<GetServiceAudienceListDto>>(serviceAudiences);
            return GetResponse(data: mappedModel);
        }
        public IApiResponse Create(CreateServiceAudienceDto createModel)
        {
            if (_emiratesUnitOfWork.ServiceAudiences.Where(x => x.ServiceId.Equals(createModel.ServiceId) && x.AudienceId.Equals(createModel.AudienceId)).Any())
                throw new BusinessException("تمت اضافة هذا الجمهور المستهدف علي الخدمة مسبقا");

            var addedModel = _emiratesUnitOfWork.ServiceAudiences.Add(_mapper.Map<ServiceAudience>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Delete(int id)
        {
            var serviceAudience = _emiratesUnitOfWork.ServiceAudiences.FirstOrDefault(n => n.Id == id);
            if (serviceAudience == null)
                throw new NotFoundException(typeof(ServiceAudience).Name);

            _emiratesUnitOfWork.ServiceAudiences.Remove(serviceAudience);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());

        }

    }
}
