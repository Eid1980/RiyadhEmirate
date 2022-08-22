using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
