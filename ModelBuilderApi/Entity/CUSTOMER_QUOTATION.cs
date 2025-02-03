using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
   
    public class CUSTOMER_QUOTATION
    {
        public string CHALLAN_NO { get; set; }
        public string? CUSTOMER_ID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string? CUSTOMER_ADDRESS { get; set; }
        public string COMPANY_CODE { get; set; }
        public string PRODUCT_CODE { get; set; }
        public decimal MRP { get; set; }
        public decimal VAT { get; set; }
        public decimal QTY { get; set; }
        public decimal SUB_TOTAL { get; set; }
        public decimal DISCOUNT_PRCNT { get; set; }
        public decimal DISCOUNT { get; set; }
        public decimal NET_AMOUNT { get; set; }
        public string? IMAGE_URL { get; set; }
        public string? CREATED_BY { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public string? PARENT_CHALLAN_NO { get; set; }
    }
}
