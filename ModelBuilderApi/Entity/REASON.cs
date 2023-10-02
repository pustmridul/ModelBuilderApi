using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("REASON")]
    public class REASON
    {
        public string CODE { get; set; }
        //public string REASON { get; set; } table and column name are same ...this column is Primary Key
        public string REASON_TYPE { get; set; }
        public string COMPANY_CODE { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }

    }
}
