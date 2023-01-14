using AutoMapper;
using Emirates.Core.Application.Shared;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;

namespace Emirates.Core.Application.Services.ServiceConditions
{
    public class ServiceConditionService : BaseService, IServiceConditionService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        public ServiceConditionService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
        }

        public IApiResponse GetById(int id)
        {
            var serviceCondition = _emiratesUnitOfWork.ServiceConditions.FirstOrDefault(l => l.Id.Equals(id));
            if (serviceCondition == null)
                throw new NotFoundException(typeof(ServiceCondition).Name);
            return GetResponse(data: _mapper.Map<GetServiceConditionDetailsDto>(serviceCondition));
        }
        public IApiResponse GetByServiceId(int serviceId)
        {
            var serviceConditions = _emiratesUnitOfWork.ServiceConditions.Where(l => l.ServiceId.Equals(serviceId)).OrderBy(x => x.Order).ThenBy(x => x.Id).ToList();
            var mappedModel = _mapper.Map<List<GetServiceConditionListDto>>(serviceConditions);
            return GetResponse(data: mappedModel);
        }
        public IApiResponse Create(CreateServiceConditionDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.ServiceConditions.Add(_mapper.Map<ServiceCondition>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateServiceConditionDto updateModel)
        {
            var serviceCondition = _emiratesUnitOfWork.ServiceConditions.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (serviceCondition == null)
                throw new NotFoundException(typeof(ServiceCondition).Name);

            _emiratesUnitOfWork.ServiceConditions.Update(serviceCondition, _mapper.Map<ServiceCondition>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse Delete(int id)
        {
            var serviceCondition = _emiratesUnitOfWork.ServiceConditions.FirstOrDefault(n => n.Id == id);
            if (serviceCondition == null)
                throw new NotFoundException(typeof(ServiceCondition).Name);

            _emiratesUnitOfWork.ServiceConditions.Remove(serviceCondition);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
