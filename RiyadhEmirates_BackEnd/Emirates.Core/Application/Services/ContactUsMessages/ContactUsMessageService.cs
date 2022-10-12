using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using X.PagedList;

namespace Emirates.Core.Application.Services.ContactUsMessages
{
    public class ContactUsMessageService : BaseService, IContactUsMessageService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public ContactUsMessageService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var ContactUsMessage = _emiratesUnitOfWork.ContactUsMessages.FirstOrDefault(l => l.Id.Equals(id));
            if (ContactUsMessage == null)
                throw new NotFoundException(typeof(ContactUsMessage).Name);
            return GetResponse(data: _mapper.Map<GetContactUsMessageDetailsDto>(ContactUsMessage));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.ContactUsMessages.GetQueryable()
               .ProjectTo<GetContactUsMessageListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetContactUsMessageListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }

        public IApiResponse Create(CreateContactUsMessageDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.ContactUsMessages.Add(_mapper.Map<ContactUsMessage>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var contactUsMessage = _emiratesUnitOfWork.ContactUsMessages.FirstOrDefault(n => n.Id == id);
            if (contactUsMessage == null)
                throw new NotFoundException(typeof(ContactUsMessage).Name);

            contactUsMessage.IsReplied = !contactUsMessage.IsReplied;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var contactUsMessage = _emiratesUnitOfWork.ContactUsMessages.FirstOrDefault(n => n.Id == id);
            if (contactUsMessage == null)
                throw new NotFoundException(typeof(ContactUsMessage).Name);

            _emiratesUnitOfWork.ContactUsMessages.Remove(contactUsMessage);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
