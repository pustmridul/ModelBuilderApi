namespace ModelBuilderApi.New_Entity
{
    public class PAYMENT_METHOD_Log
    {
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string COMPANY_CODE { get; set; }
        public string CRATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string UPDATED_BY { get; set; }
        public DateTime UPDATED_DATE { get; set; }
        public string? ActCodeDr { get; set; }
        public string? ActCodeCr { get; set; }
        public decimal? cCom { get; set; }
        public string? ActCodeChrg { get; set; }
        
        public string? STATUS { get; set; }
    }
}
