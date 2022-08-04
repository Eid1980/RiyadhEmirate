using System.ComponentModel.DataAnnotations.Schema;

namespace Emirates.Core.Domain.Entities
{
    [Table("RolesScreen", Schema = "Security")]
    public class RolesScreen : AuditFullData<int>
    {
        public int RoleId { get; set; }
        public int ScreenId { get; set; }
        public bool CanCreate { get; set; }
        public bool CanRead { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
    }
}
