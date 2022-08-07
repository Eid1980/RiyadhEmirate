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
    }
}
