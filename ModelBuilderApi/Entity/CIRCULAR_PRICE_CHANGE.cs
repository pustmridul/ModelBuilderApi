using System.ComponentModel.DataAnnotations.Schema;

namespace ModelBuilderApi.Entity
{
    [Table("CIRCULAR_PRICE_CHANGE")]
    public class CIRCULAR_PRICE_CHANGE
    {
        public string CIRCULAR_NO { get; set; }
        public string CIRCULAR_NAME { get; set; }
        public DateTime CIRCULAR_DATE { get; set; }
        public string COMPANY_CODE { get; set; }
        public DateTime EFFECTIVE_DATE { get; set; }
        public string PRODUCT_CODE { get; set; }
        public decimal PRV_MRP { get; set; }
        public decimal? MRP { get; set; }
        public decimal? WSP { get; set; }
        public decimal? PRICE1 { get; set; }
        public decimal? PRICE2 { get; set; }
        public decimal? PRICE3 { get; set; }
        public decimal? PRICE4 { get; set; }
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string STATUS { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public bool IS_CARTON { get; set; }
        public string REF_CODE { get; set; }
        public decimal? PRV_CPU { get; set; }
        public decimal? CPU { get; set; }
        public string? APPROVED_BY { get; set; }
        public DateTime? APPROVED_DATE { get; set; }
        public string? REMARKS { get; set; }
        public int ID { get; set; }
        public string? SAL_BARCODE { get; set; }
        public decimal? S0001 { get; set; }
        public decimal? S0002 { get; set; }
        public decimal? S0003 { get; set; }
        public decimal? S0004 { get; set; }
        public decimal? S0005 { get; set; }
        public decimal? S0006 { get; set; }
        public decimal? S0007 { get; set; }
        public decimal? S0008 { get; set; }
        public decimal? S0009 { get; set; }
        public decimal? S0010 { get; set; }
        public decimal? S0011 { get; set; }
        public decimal? S0012 { get; set; }
        public decimal? S0013 { get; set; }
        public decimal? S0014 { get; set; }
        public decimal? S0015 { get; set; }
        public decimal? S0016 { get; set; }
        public decimal? S0017 { get; set; }
        public decimal? S0018 { get; set; }
        public decimal? S0019 { get; set; }
        public decimal? S0020 { get; set; }
        public decimal? PRV_WSP { get; set; }
        public decimal? PRV_PRICE1 { get; set; }
        public decimal? PRV_PRICE2 { get; set; }
        public decimal? PRV_PRICE3 { get; set; }
        public decimal? PRV_PRICE4 { get; set; }
        public string? STORE_CODE { get; set; }
        public string PC_FOR_PRODUCT { get; set; }
        public bool CATEGORY_WISE_COST_PRICE_CHANGE { get; set; }
        public bool EFFECT_PRICE_CHANGE_ALL_TRANSECTION { get; set; }
        public DateTime? FROM_DATE { get; set; }
        public DateTime? TO_DATE { get; set; }
    }
}
