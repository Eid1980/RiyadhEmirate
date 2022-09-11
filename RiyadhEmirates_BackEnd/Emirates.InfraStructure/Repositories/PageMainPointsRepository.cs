﻿using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class PageMainPointsRepository : Repository<MainPagePoints, EmiratesContext>, IPageMainPointsRepository
    {
        public PageMainPointsRepository(EmiratesContext context) : base(context)
        {

        }
    }
}
