using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("PACK_SIZE_LIST_Log")]
    public class PACK_SIZE_LIST_Log
    {
        public decimal CODE { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? COMPANY_CODE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
    }
}
