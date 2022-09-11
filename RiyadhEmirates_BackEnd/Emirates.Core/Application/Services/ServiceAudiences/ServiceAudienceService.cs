using AutoMapper;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.InternalPortal.FileManager;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Emirates.Core.Application.Services.ServiceAudiences
{
    public class ServiceAudienceService : BaseService, IServiceAudienceService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IFileManagerService _fileManagerService;
        private readonly IMapper _mapper;
        public ServiceAudienceService(IEmiratesUnitOfWork emiratesUnitOfWork, IFileManagerService fileManagerService, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _fileManagerService = fileManagerService;
            _mapper = mapper;
        }
        public IApiResponse GetByServiceId(int serviceId)
        {
            var serviceAudiences = _emiratesUnitOfWork.ServiceAudiences.Where(l => l.ServiceId.Equals(serviceId)).Include(x => x.Audience).ToList();
            var mappedModel = _mapper.Map<List<GetServiceAudienceListDto>>(serviceAudiences);
            return GetResponse(data: mappedModel);
        }
        public IApiResponse GetCheckedAudience(int serviceId)
        {
            var service = _emiratesUnitOfWork.Services.FirstOrDefault(l => l.Id.Equals(serviceId));
            if (service == null)
                throw new NotFoundException(typeof(Service).Name);

            List<CheckedAudience> checkedAudiences = new List<CheckedAudience>();
            var audiences = _emiratesUnitOfWork.Audiences.Where(x => x.IsActive).ToList();
            if (audiences.Any())
            {
                var serviceAudiences = _emiratesUnitOfWork.ServiceAudiences.Where(l => l.ServiceId.Equals(serviceId)).ToList();
                audiences.ForEach(item =>
                {
                    var addedItem = serviceAudiences.FirstOrDefault(x => x.AudienceId.Equals(item.Id));
                    if (addedItem == null)
                        checkedAudiences.Add(new CheckedAudience
                        {
                            AudienceId = item.Id,
                            AudienceName = item.NameAr,
                            IsChecked = false
                        });
                    else
                        checkedAudiences.Add(new CheckedAudience
                        {
                            Id = addedItem.Id,
                            AudienceId = item.Id,
                            AudienceName = item.NameAr,
                            IsChecked = true
                        });
                });
            }
            return GetResponse(data: new GetCheckedAudienceDto
            {
                CheckedAudiences = checkedAudiences,
                Image = _fileManagerService.GetBase64File(serviceId, "ServiceExplain")
            });
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
