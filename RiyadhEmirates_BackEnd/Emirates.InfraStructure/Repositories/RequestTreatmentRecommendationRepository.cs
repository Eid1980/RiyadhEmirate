using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;
using Emirates.InfraStructure.Repositories.Security;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestTreatmentRecommendationRepository : Repository<RequestTreatmentRecommendation, EmiratesContext>, IRequestTreatmentRecommendationRepository
    {
        public RequestTreatmentRecommendationRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
