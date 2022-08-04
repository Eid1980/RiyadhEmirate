using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Application.Dtos
{
    public class GetRequestDetailsDto
    {
        public Guid Id { get; set; }
        public int ServiceId { get; set; }
        public string RequestNumber { get; set; }
        public DateTime RequestDate { get; set; }
        public int StageId { get; set; }
        public bool CanEdit { get; set; }
        public string Notes { get; set; }
        public Guid ConcurrencyStamp { get; set; }
        public int CreatedBy { get; set; }

    }
}
