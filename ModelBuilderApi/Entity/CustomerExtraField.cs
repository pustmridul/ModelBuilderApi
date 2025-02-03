using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class CustomerExtraField
    {
        public bool? MainChannel { get; set; }
        public bool? Zone { get; set; }
        public bool? CustomerCategory { get; set; }
        public bool? CustomerSubCategory { get; set; }
        public bool? LinkId { get; set; }
        public bool? CustomerGroup { get; set; }
        public bool CUSTOMER_BIN_LABEL { get; set; }
        public bool Discount_Percentage_Edit { get; set; }
    }
}
