
using Emirates.Core.Domain.Entities;

namespace Emirates.Core.Domain.Interfaces.Repositories
{
    public interface ILookupRepository
    {
        IQueryable<MaritalStatus> GetMaritalStatus();
        IQueryable<Governorate> GetGovernorates();
        IQueryable<Nationality> GetNationalities();
        IQueryable<DefendantType> GetDefendantTypes();
        IQueryable<BuildingType> GetBuildingTypes();
        IQueryable<Religion> GetReligions();
        IQueryable<CommentStage> GetCommentStages();
        IQueryable<ContactUsMessageType> GetContactUsMessageTypes();
    }
}
