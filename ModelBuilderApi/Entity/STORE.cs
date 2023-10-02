using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("STORE")]
    public class STORE
    {
        public string STORE_CODE { get; set; }
        [Key]
        public string STORE_NAME { get; set; }
        [Key]
        public string COMPANY_CODE { get; set; }
        public string ADDRESS1 { get; set; }
        public string? ADDRESS2 { get; set; }
        public string POSTAL_CODE { get; set; }
        public string CITY { get; set; }
        public string COUNTRY { get; set; }
        public string PHONE { get; set; }
        public string? EMAIL { get; set; }
        public DateTime DOE { get; set; }
        public string? VATREGNO { get; set; }
        public string? TIN { get; set; }
        public string? TRADE_LICENSE_NO { get; set; }
        public string? DRUG_LICENSE_NO { get; set; }
        public string STORETYPE { get; set; }
        public decimal LATE_NIGHT_HOUR { get; set; }
        public string SALE_ON { get; set; }
        public decimal BARGAIN_SALE { get; set; }
        public string? LATITUDE { get; set; }
        public string? LONGITUDE { get; set; }
        public string? AREA_CODE { get; set; }
        public string STATUS { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? EmailSender { get; set; }
        public string? EmailSenderPW { get; set; }
        public string? EmailReceiver { get; set; }
        public bool? NO_VAT_SAL { get; set; }
        public decimal? FRANCHISE_DISC_PRCNT { get; set; }
        public string? BRAND_CODE { get; set; }
        public string? Branchcode { get; set; }
        public string? CENTRAL_STORE { get; set; }
        public bool SDC_ENABLED { get; set; }
        public bool? IS_DIRECT_RECEIVE_FROM_WH { get; set; }
        public string? SHOP_CATEGORY_CODE { get; set; }
        public string? SHOP_TYPE_CODE { get; set; }
        public string? DIVISION_CODE { get; set; }
        public string? DISTRICT_CODE { get; set; }
        public string? LINKID { get; set; }
        public bool IS_MANAGE_STOCK { get; set; }
        public string? STORE_OPENING_TIME { get; set; }
        public string? STORE_CLOSING_TIME { get; set; }
        public string? StoreCategory { get; set; }
        public int STORE_SERIAL { get; set; }
        public string PRIORITY_CODE { get; set; }
        public bool DAY_CLOSE { get; set; }
        public string? SLNO { get; set; }
        public int CategoryOrder { get; set; }

    }
}
