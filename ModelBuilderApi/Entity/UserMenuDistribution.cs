using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class UserMenuDistribution
    {
        public string? UserName { get; set; }
        public string? PermissionName { get; set; }
        public string? EntryBy { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
