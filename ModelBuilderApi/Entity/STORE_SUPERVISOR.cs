using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class STORE_SUPERVISOR
    {
        public string COMPANY_CODE { get; set; }
        public string EMPLOYEE_CODE { get; set; }
        public string STORE_CODE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
    }
}
