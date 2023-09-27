using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("EmployeeAttachedStore")]
    public class EmployeeAttachedStore
    {
        public decimal ID { get; set; }
        public string? EMPLOYEE_CODE { get; set; }
        public string? STORE_CODE { get; set; }
        public string? UPDATED_BY { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
    }
}
