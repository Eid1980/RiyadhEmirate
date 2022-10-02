using AutoMapper;
using AutoMapper.QueryableExtensions;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Dtos.Search;
using Emirates.Core.Application.DynamicSearch;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Application.Services.InternalPortal.FileManager;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;
using X.PagedList;

namespace Emirates.Core.Application.Services.EmiratesPrinces
{
    public class EmiratesPrinceService : BaseService, IEmiratesPrinceService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        private readonly IFileManagerService _fileManagerService;

        public EmiratesPrinceService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper,
            IFileManagerService fileManagerService)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
            _fileManagerService = fileManagerService;
        }

        public IApiResponse GetById(int id)
        {
            var emiratesPrince = _emiratesUnitOfWork.EmiratesPrinces.FirstOrDefault(l => l.Id.Equals(id));
            if (emiratesPrince == null)
                throw new NotFoundException(typeof(EmiratesPrince).Name);
            var mappedModel = _mapper.Map<GetEmiratesPrinceDetailsDto>(emiratesPrince);
            mappedModel.Image = _fileManagerService.GetBase64File(id, "EmiratesPrince");
            return GetResponse(data: mappedModel);
        }
        public IApiResponse GetAll(SearchModel searchModel)
        {
            var serchResult = _emiratesUnitOfWork.EmiratesPrinces.GetQueryable()
               .ProjectTo<GetEmiratesPrinceListDto>(_mapConfig)
               .DynamicSearch(searchModel)
               .ToPagedList(searchModel.PageNumber, searchModel.PageSize);

            return GetResponse(data: new ListPageModel<GetEmiratesPrinceListDto>
            {
                GridItemsVM = serchResult,
                PagingMetaData = serchResult.GetMetaData()
            });
        }
        public IApiResponse GetAll()
        {
            var emiratesPrincesQuerable = _emiratesUnitOfWork.EmiratesPrinces.GetQueryable().OrderByDescending(d => d.FromDate);
            var query = from emiratesPrinces in emiratesPrincesQuerable
                         where emiratesPrinces.IsActive
                         select new GetEmiratesPrinceListDto
                         {
                             Id = emiratesPrinces.Id,
                             NameAr = emiratesPrinces.NameAr,
                             NameEn = emiratesPrinces.NameEn,
                             BehalfToAr = emiratesPrinces.BehalfToAr,
                             BehalfToEn = emiratesPrinces.BehalfToEn,
                             FromDate = emiratesPrinces.FromDate.ToString("yyyy-MM-dd"),
                             ToDate = emiratesPrinces.ToDate == null ? "حتى الان" : emiratesPrinces.ToDate.Value.ToString("yyyy-MM-dd"),
                             Image = _fileManagerService.GetBase64File(emiratesPrinces.Id, "EmiratesPrince")
                         };
            return GetResponse(data: query.ToList());
        }

        public IApiResponse Create(CreateEmiratesPrinceDto createModel)
        {
            var addedModel = _emiratesUnitOfWork.EmiratesPrinces.Add(_mapper.Map<EmiratesPrince>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }
        public IApiResponse Update(UpdateEmiratesPrinceDto updateModel)
        {
            var emiratesPrince = _emiratesUnitOfWork.EmiratesPrinces.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (emiratesPrince == null)
                throw new NotFoundException(typeof(EmiratesPrince).Name);

            _emiratesUnitOfWork.EmiratesPrinces.Update(emiratesPrince, _mapper.Map<EmiratesPrince>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
        public IApiResponse ChangeStatus(int id)
        {
            var emiratesPrince = _emiratesUnitOfWork.EmiratesPrinces.FirstOrDefault(n => n.Id == id);
            if (emiratesPrince == null)
                throw new NotFoundException(typeof(EmiratesPrince).Name);

            emiratesPrince.IsActive = !emiratesPrince.IsActive;
            _emiratesUnitOfWork.Complete();
            return GetResponse();
        }
        public IApiResponse Delete(int id)
        {
            var emiratesPrince = _emiratesUnitOfWork.EmiratesPrinces.FirstOrDefault(n => n.Id == id);
            if (emiratesPrince == null)
                throw new NotFoundException(typeof(EmiratesPrince).Name);

            _emiratesUnitOfWork.EmiratesPrinces.Remove(emiratesPrince);
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.DeleteSuccess());
        }
    }
}
