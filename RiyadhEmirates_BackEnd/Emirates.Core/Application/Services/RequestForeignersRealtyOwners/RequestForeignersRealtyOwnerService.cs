using AutoMapper;
using Emirates.Core.Application.Shared;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;

namespace Emirates.Core.Application.Services.RequestForeignersRealtyOwners
{
    public class RequestForeignersRealtyOwnerService : BaseService, IRequestForeignersRealtyOwnerService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        public RequestForeignersRealtyOwnerService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
        }

        public IApiResponse GetById(Guid id)
        {
            var request = _emiratesUnitOfWork.Requests.FirstOrDefault(l => l.Id.Equals(id), x => x.RequestForeignersRealtyOwner, x => x.Stage);
            if (request == null)
                throw new NotFoundException(typeof(Request).Name);
            var response = _mapper.Map<RequestForeignersRealtyOwnerDto>(request.RequestForeignersRealtyOwner);
            if (response == null)
                throw new BusinessException("بيانات الطلب غير صحيحة, برجاء اختيار الطلب بطريقة صحيحة");
            response.CanEdit = request.Stage.CanEdit;
            response.Notes = request.Notes;
            response.ConcurrencyStamp = request.ConcurrencyStamp;
            return GetResponse(data: response);
        }
        public IApiResponse GetDetailsById(Guid id)
        {
            var request = _emiratesUnitOfWork.Requests.FirstOrDefault(l => l.Id.Equals(id),
                x => x.RequestForeignersRealtyOwner,
                x => x.RequestForeignersRealtyOwner.BuildingType,
                x => x.RequestForeignersRealtyOwner.Governorate,
                x => x.RequestForeignersRealtyOwner.Religion,
                x => x.Stage, x => x.Service);
            if (request == null)
                throw new NotFoundException(typeof(Request).Name);
            var response = _mapper.Map<GetRequestForeignersRealtyOwnerDetailsDto>(request);
            if (response == null)
                throw new BusinessException("بيانات الطلب غير صحيحة, برجاء اختيار الطلب بطريقة صحيحة");
            return GetResponse(data: response);
        }
        public IApiResponse Create(CreateRequestForeignersRealtyOwnerDto createModel)
        {
            if (CanCreate(createModel.UserId))
            {
                Request request = new Request()
                {
                    ServiceId = (int)SystemEnums.Services.ForeignersRealtyOwner,
                    RequestNumber = _emiratesUnitOfWork.Requests.GetNextRequestNumber().ToString(),
                    RequestDate = DateTime.Now,
                    StageId = (int)SystemEnums.Stages.Draft,
                    Notes = createModel.Notes
                };
                _emiratesUnitOfWork.Requests.Add(request);

                RequestStageLog requestStageLog = new RequestStageLog
                {
                    RequestId = request.Id,
                    StageId = (int)SystemEnums.Stages.Draft,
                    Notes = createModel.Notes
                };
                _emiratesUnitOfWork.RequestStageLogs.Add(requestStageLog);

                var addedModel = _mapper.Map<RequestForeignersRealtyOwner>(createModel);
                addedModel.Id = request.Id;
                _emiratesUnitOfWork.RequestForeignersRealtyOwners.Add(addedModel);

                _emiratesUnitOfWork.Complete();
                return GetResponse(message: CustumMessages.SaveSuccess(), data: request.Id);
            }
            throw new BusinessException("لا يمكن اضافة طلب جديد لوجود طلب أخر لم يتم الرد علية");
        }
        public IApiResponse Update(UpdateRequestForeignersRealtyOwnerDto updateModel)
        {
            var request = _emiratesUnitOfWork.Requests.FirstOrDefault(x => x.Id.Equals(updateModel.Id), x => x.Stage, x => x.RequestForeignersRealtyOwner);
            if (request == null)
                throw new NotFoundException(typeof(Request).Name);
            if (!request.Stage.CanEdit)
                throw new BusinessException("لا يمكن تعديل الطلب في الوقت الحالي");

            request.Notes = updateModel.Notes;

            _emiratesUnitOfWork.RequestForeignersRealtyOwners.Update(request.RequestForeignersRealtyOwner, _mapper.Map<RequestForeignersRealtyOwner>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        private bool CanCreate(int userId)
        {
            return !_emiratesUnitOfWork.Requests.Where(x => x.ServiceId.Equals((int)SystemEnums.Services.ForeignersRealtyOwner) &&
                    x.CreatedBy.Equals(userId) && !x.Stage.CanAddNew).Any();
        }
    }
}
