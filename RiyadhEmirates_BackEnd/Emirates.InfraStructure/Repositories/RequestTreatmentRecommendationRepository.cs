using Emirates.Core.Domain.Entities;
using Emirates.Core.Domain.Interfaces.Repositories;
using Emirates.InfraStructure.Contexts;

namespace Emirates.InfraStructure.Repositories
{
    public class RequestTreatmentRecommendationRepository : Repository<RequestTreatmentRecommendation, EmiratesContext>, IRequestTreatmentRecommendationRepository
    {
        public RequestTreatmentRecommendationRepository(EmiratesContext context) : base(context)
        {
        }
    }
}
