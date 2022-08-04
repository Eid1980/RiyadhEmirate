using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Application.Dtos
{
    public class RequestChangeStageDto
    {
        public Guid Id { get; set; }
        public int StageId { get; set; }
        public string Notes { get; set; }
    }
}
