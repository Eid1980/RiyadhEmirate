using AutoMapper;
using Emirates.Core.Application.CustomExceptions;
using Emirates.Core.Application.Dtos.AboutUs;
using Emirates.Core.Application.Dtos.MainPoints;
using Emirates.Core.Application.Enums;
using Emirates.Core.Application.Interfaces.Helpers;
using Emirates.Core.Application.Response;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;

namespace Emirates.Core.Application.Services.AboutUs
{
    public class AboutUsService : BaseService, IAboutUsService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        private readonly IConfigurationProvider _mapConfig;
        public AboutUsService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
            _mapConfig = mapper.ConfigurationProvider;
        }

        public IApiResponse Create(CreateAboutUsDto createModel)
        {
            if (_emiratesUnitOfWork.CaseTypes.Where(x => x.NameAr.Equals(createModel.PageContentType)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");


            var addedModel = _emiratesUnitOfWork.PageContent.Add(_mapper.Map<PageContent>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }

        public IApiResponse CreateMainPoint(CreateMainPoints createMainPoints)
        {
            var aboutUsContent = _emiratesUnitOfWork.PageContent.Include(p => p.MainPagePoints).Where(p => p.PageContentType == PageContentTypeEnum.AboutUs.ToString()).FirstOrDefault();

            createMainPoints.PageContentId = aboutUsContent.Id;
            var mainPagePoint = _mapper.Map<MainPagePoints>(createMainPoints);

            _emiratesUnitOfWork.PageMainPoints.Add(mainPagePoint);

            _emiratesUnitOfWork.Complete();

            return GetResponse(message: CustumMessages.SaveSuccess(), data: aboutUsContent);
        }

        public IApiResponse GetAll()
        {
            var aboutUsContent = _emiratesUnitOfWork.PageContent.Include(p => p.MainPagePoints).Where(p => p.PageContentType == PageContentTypeEnum.AboutUs.ToString());
            return GetResponse(data: _mapper.Map<List<GetAboutUsDto>>(aboutUsContent));
        }

        public IApiResponse Update(UpdateAboutUsDto updateModel)
        {
            var pageContent = _emiratesUnitOfWork.PageContent.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (pageContent == null)
                throw new NotFoundException(typeof(PageContent).Name);

            _emiratesUnitOfWork.PageContent.Update(pageContent, _mapper.Map<PageContent>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }
    }
}
