using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Domain.Entities
{
    public class Request : AuditFullData<Guid>
    {
        public int ServiceId { get; set; }
        public string RequestNumber { get; set; }
        public DateTime RequestDate { get; set; }
        public int StageId { get; set; }
        public string Notes { get; set; }

        public virtual Service Service { get; set; }
        public virtual Stage Stage { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }
        public virtual ICollection<RequestStageLog> RequestStageLogs { get; set; }

        public virtual RequestElectronicBoard RequestElectronicBoard { get; set; }
        public virtual RequestPrisonerTempRelease RequestPrisonerTempRelease { get; set; }
        public virtual RequestPrisonersService RequestPrisonersService { get; set; }
        public virtual RequestLandsInfringement RequestLandsInfringement { get; set; }
        public virtual RequestElectronicSummon RequestElectronicSummon { get; set; }
        public virtual RequestMarriageCertificate RequestMarriageCertificate { get; set; }
        public virtual RequestJudgmentExecution RequestJudgmentExecution { get; set; }
    }
}
