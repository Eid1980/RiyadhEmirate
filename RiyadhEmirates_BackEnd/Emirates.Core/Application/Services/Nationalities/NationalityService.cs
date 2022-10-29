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

namespace Emirates.Core.Application.Services.Nationalities
{
    public class NationalityService : BaseService, INationalityService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public NationalityService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse GetById(int id)
        {
            var nationality = _emiratesUnitOfWork.Nationalities.FirstOrDefault(l => l.Id.Equals(id));
            if (nationality == null)
                throw new NotFoundException(typeof(Nationality).Name);
            return GetResponse(data: _mapper.Map<GetNationalityDetailsDto>(nationality));
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.Nationalities.GetQueryable()
               .ProjectTo<GetNationalityListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetNationalityListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var Nationalities = _emiratesUnitOfWork.Nationalities.Where(l => l.IsActive).OrderByDescending(s => s.CreatedDate);
            return GetResponse(data: _mapper.Map<List<GetNationalityListDto>>(Nationalities));
        }

        public IApiResponse Create(CreateNationalityDto createModel)
        {
            if (_emiratesUnitOfWork.Nationalities.Where(x => x.NameAr.Equals(createModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Nationalities.Where(x => x.NameEn.Equals(createModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            var addedModel = _emiratesUnitOfWork.Nationalities.Add(_mapper.Map<Nationality>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateNationalityDto updateModel)
        {
            var nationality = _emiratesUnitOfWork.Nationalities.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (nationality == null)
                throw new NotFoundException(typeof(Nationality).Name);

            if (_emiratesUnitOfWork.Nationalities.Where(x => x.Id != updateModel.Id && x.NameAr.Equals(updateModel.NameAr)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");
            if (_emiratesUnitOfWork.Nationalities.Where(x => x.Id != updateModel.Id && x.NameEn.Equals(updateModel.NameEn)).Any())
                throw new BusinessException("الاسم انجليزي مضاف مسبقا");

            _emiratesUnitOfWork.Nationalities.Update(nationality, _mapper.Map<Nationality>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var nationality = _emiratesUnitOfWork.Nationalities.FirstOrDefault(n => n.Id == id);
            if (nationality == null)
                throw new NotFoundException(typeof(Nationality).Name);

            nationality.IsActive = !nationality.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var nationality = _emiratesUnitOfWork.Nationalities.FirstOrDefault(n => n.Id == id, x => x.Users);
            if (nationality == null)
                throw new NotFoundException(typeof(Nationality).Name);
            if (nationality.Users.Count > 0)
                throw new BusinessException("الجنسية مرتبطة بمستخدمين");

            _emiratesUnitOfWork.Nationalities.Remove(nationality);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
