using Emirates.Core.Application.Response;

namespace Emirates.Core.Application.Services.Lookups
{
    public interface ILookupService
    {
        IApiResponse GetMaritalStatusLookupList();
        IApiResponse GetGovernorateLookupList();
        IApiResponse GetNationalityLookupList();
        IApiResponse GetDefendantTypeLookupList();
        IApiResponse GetBuildingTypeLookupList();
        IApiResponse GetReligionLookupList();
        IApiResponse GetCommentStageLookupList();
        IApiResponse GetContactUsMessageTypeLookupList();
    }
}
