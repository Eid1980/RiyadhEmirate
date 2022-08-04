using Emirates.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Domain.Entities
{
    public class RequestStageLog : AuditFullData<Guid>
    {
        public Guid RequestId { get; set; }
        public int StageId { get; set; }
        public DateTime? EndDate { get; set; }       
        public string Notes { get; set; }

        public virtual Request Request { get; set; }
        public virtual Stage Stage { get; set; }
        public virtual User CreatedUser { get; set; }
        public virtual User ModifiedUser { get; set; }



    }
}
