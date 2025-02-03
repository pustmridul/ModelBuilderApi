using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class PACK_SIZE_LIST
    {
        public decimal CODE { get; set; }
       
        public string DESCRIPTION { get; set; }
       
        public string COMPANY_CODE { get; set; }
        public string ENTRY_BY { get; set; }
        public DateTime ENTRY_DATE { get; set; }
    }
}
