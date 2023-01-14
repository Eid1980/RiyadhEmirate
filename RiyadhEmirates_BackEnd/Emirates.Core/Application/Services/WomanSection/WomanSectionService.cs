using AutoMapper;
using Emirates.Core.Application.Shared;
using Emirates.Core.Application.Dtos.MainPoints;
using Emirates.Core.Application.Dtos.WomanSection;
using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces;

namespace Emirates.Core.Application.Services.WomanSection
{
    public class WomanSectionService : BaseService, IWomanSectionService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        private readonly IMapper _mapper;
        public WomanSectionService(IEmiratesUnitOfWork emiratesUnitOfWork, IMapper mapper)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
            _mapper = mapper;
        }

        public IApiResponse Create(CreateWomanSectionDto createModel)
        {
            if (_emiratesUnitOfWork.CaseTypes.Where(x => x.NameAr.Equals(createModel.PageContentType)).Any())
                throw new BusinessException("الاسم عربي مضاف مسبقا");


            var addedModel = _emiratesUnitOfWork.PageContent.Add(_mapper.Map<PageContent>(createModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.SaveSuccess(), data: addedModel.Id);
        }

        public IApiResponse CreateMainPoint(CreateMainPoints createMainPoints)
        {
            var womanSectionContent = _emiratesUnitOfWork.PageContent.Include(p => p.MainPagePoints).Where(p => p.PageContentType == SystemEnums.PageContentTypeEnum.WomanSection.ToString()).FirstOrDefault();

            bool isExist = _emiratesUnitOfWork.PageMainPoints.Any(p => p.PageContentId == womanSectionContent.Id && p.Order == createMainPoints.Order);

            if (isExist)
            {
                throw new Exception("يوجد نقاط بنفس الترتيب");
            }
            createMainPoints.PageContentId = womanSectionContent.Id;
            var mainPagePoint = _mapper.Map<MainPagePoints>(createMainPoints);

            _emiratesUnitOfWork.PageMainPoints.Add(mainPagePoint);

            _emiratesUnitOfWork.Complete();

            return GetResponse(message: CustumMessages.SaveSuccess(), data: womanSectionContent);
        }

        public IApiResponse DeleteMainPoint(int id)
        {
            var mainPagePoint = _emiratesUnitOfWork.PageMainPoints.FirstOrDefault(p => p.Id == id);
            if (mainPagePoint == null)
                throw new NotFoundException(typeof(ServiceCondition).Name);

            _emiratesUnitOfWork.PageMainPoints.Remove(mainPagePoint);
            _emiratesUnitOfWork.Complete();

            return GetResponse(message: CustumMessages.DeleteSuccess());

        }

        public IApiResponse GetAll()
        {
            try
            {
                var aboutUsContent = _emiratesUnitOfWork.PageContent.Include(p => p.MainPagePoints).FirstOrDefault(p => p.PageContentType == SystemEnums.PageContentTypeEnum.WomanSection.ToString());

                aboutUsContent.MainPagePoints = aboutUsContent.MainPagePoints.OrderBy(p => p.Order).ToList();

                return GetResponse(data: _mapper.Map<GetWomanSectionDto>(aboutUsContent));
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public IApiResponse Update(UpdateWomanSectionDto updateModel)
        {
            var pageContent = _emiratesUnitOfWork.PageContent.FirstOrDefault(n => n.Id.Equals(updateModel.Id));
            if (pageContent == null)
                throw new NotFoundException(typeof(PageContent).Name);

            updateModel.PageContentType = SystemEnums.PageContentTypeEnum.WomanSection.ToString();

            _emiratesUnitOfWork.PageContent.Update(pageContent, _mapper.Map<PageContent>(updateModel));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: updateModel.Id);
        }

        public IApiResponse UpdateMainPoint(UpdateMainPoint updateMainPoint)
        {
            var mainPoint = _emiratesUnitOfWork.PageMainPoints.FirstOrDefault(n => n.Id.Equals(updateMainPoint.Id));
            if (mainPoint == null)
                throw new NotFoundException(typeof(MainPagePoints).Name);

            updateMainPoint.PageContentId = mainPoint.PageContentId;

            _emiratesUnitOfWork.PageMainPoints.Update(mainPoint, _mapper.Map<MainPagePoints>(updateMainPoint));
            _emiratesUnitOfWork.Complete();
            return GetResponse(message: CustumMessages.UpdateSuccess(), data: mainPoint.Id);
        }
    }
}
