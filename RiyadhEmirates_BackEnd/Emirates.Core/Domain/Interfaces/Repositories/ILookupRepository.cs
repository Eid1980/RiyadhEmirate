﻿
using Emirates.Core.Domain.Entities;

namespace Emirates.Core.Domain.Interfaces.Repositories
{
    public interface ILookupRepository
    {
        IQueryable<MaritalStatus> GetMaritalStatus();
        IQueryable<Governorate> GetGovernorates();
        IQueryable<Nationality> GetNationalities();
    }
}