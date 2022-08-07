using Emirates.Core.Application.Dtos;
using Emirates.Core.Application.Response;
using Emirates.Core.Domain.Interfaces;

namespace Emirates.Core.Application.Services.Lookups
{
    public class LookupService: BaseService, ILookupService
    {
        private readonly IEmiratesUnitOfWork _emiratesUnitOfWork;
        public LookupService(IEmiratesUnitOfWork emiratesUnitOfWork)
        {
            _emiratesUnitOfWork = emiratesUnitOfWork;
        }

        public IApiResponse GetMaritalStatusLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.Lookups.GetMaritalStatus().Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
        public IApiResponse GetGovernorateLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.Lookups.GetGovernorates().Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
        public IApiResponse GetNationalityLookupList()
        {
            return GetResponse(data: _emiratesUnitOfWork.Lookups.GetNationalities().Where(l => l.IsActive).Select(item =>
            new LookupDto<int>
            {
                Id = item.Id,
                Name = item.NameAr
            }).ToList());
        }
    }
}
