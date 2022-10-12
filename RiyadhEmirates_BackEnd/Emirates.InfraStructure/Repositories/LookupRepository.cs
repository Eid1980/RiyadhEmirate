using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class LookupRepository : ILookupRepository
    {
        private EmiratesContext _context;
        public LookupRepository(EmiratesContext context)
        {
            _context = context;
        }

        public IQueryable<MaritalStatus> GetMaritalStatus()
        {
            return _context.MaritalStatuses.AsQueryable();
        }
        public IQueryable<Governorate> GetGovernorates()
        {
            return _context.Governorates.AsQueryable();
        }
        public IQueryable<Nationality> GetNationalities()
        {
            return _context.Nationalities.AsQueryable();
        }
        public IQueryable<DefendantType> GetDefendantTypes()
        {
            return _context.DefendantTypes.AsQueryable();
        }
        public IQueryable<BuildingType> GetBuildingTypes()
        {
            return _context.BuildingTypes.AsQueryable();
        }
        public IQueryable<Religion> GetReligions()
        {
            return _context.Religions.AsQueryable();
        }
        public IQueryable<CommentStage> GetCommentStages()
        {
            return _context.CommentStages.AsQueryable();
        }
        public IQueryable<ContactUsMessageType> GetContactUsMessageTypes()
        {
            return _context.ContactUsMessageTypes.AsQueryable();
        }
    }
}
