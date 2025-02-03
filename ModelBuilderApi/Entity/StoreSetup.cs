using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    
    public class StoreSetup
    {

        public string? COMPANY_CODE { get; set; }
        public string? COMPANY_NAME { get; set; }
        public string? Company_Status { get; set; }
        public DateTime? Date_of_Expire { get; set; }
        public string? Prefix { get; set; }
        public string? Store_Code { get; set; }
        public string? Store_Name { get; set; }
        public string? StoreType { get; set; }
        public string? SALE_ON { get; set; }
        public decimal? LNH { get; set; }
        public bool? CSA { get; set; }
        public bool? BSA { get; set; }
        public string? CENTRAL_STORE { get; set; }
        public string? APP_VERSION { get; set; }
        public decimal? MP_ENABLED { get; set; }
        public bool? MEM_CRD_ENABLED { get; set; }
        public bool? GIFT_VOUCHER_ENABLED { get; set; }
        public bool? NO_VAT_SAL { get; set; }
        public bool? IS_SHOP_WISE_SAL_PRICE { get; set; }
        public bool? IS_VAT_BEFORE_DISC { get; set; }
        public bool IS_CUSTOMER_WISE_PRICE { get; set; }
    }
}
