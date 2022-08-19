using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emirates.Core.Domain.Entities
{
    public class RequestMarriageCertificate
    {
        public Guid Id { get; set; }
        public int RequestTypeId { get; set; }
        public string EmployeeSide { get; set; }
        public string JobOccupation { get; set; }
        public int MaritalStatusId { get; set; }
        public int ChildrenCount { get; set; }

        public virtual Request Request { get; set; }
        public virtual RequestType RequestType { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
    }
}
